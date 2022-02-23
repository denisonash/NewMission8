﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Mission7.Models
{
    public class Cart
    {
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>();

        public void AddItem(Books book, int qty)
        {
            CartLineItem line = Items
                .Where(b => b.Books.BookID == book.BookID)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new CartLineItem
                {
                    Books = book,
                    Quantity = qty,
                    Price = book.Price
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public double CalculateTotal()
        {
            double sum = Items.Sum(b => b.Quantity * b.Price);

            return sum;
        }
    }

    public class CartLineItem
    {
        public int LineID { get; set; }

        public Books Books { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }
    }
}
