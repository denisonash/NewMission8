#pragma checksum "/Users/ashleydenison/Documents/GitHub/NewMission8/Mission7/Pages/Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "309a0065a942c3c16ac14929d97f40468c3d683d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mission7.Pages.Pages_Buy), @"mvc.1.0.razor-page", @"/Pages/Buy.cshtml")]
namespace Mission7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "/Users/ashleydenison/Documents/GitHub/NewMission8/Mission7/Pages/_ViewImports.cshtml"
using Mission7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"309a0065a942c3c16ac14929d97f40468c3d683d", @"/Pages/Buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42cc7c3599c3dbbc8dcbc03f431f4cae1c208a4d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Buy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Your Basket</h2>

<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Item</th>
            <th>Quantity</th>
            <th>Price Per Book</th>
            <th>Subtotal</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 19 "/Users/ashleydenison/Documents/GitHub/NewMission8/Mission7/Pages/Buy.cshtml"
         foreach (var i in Model.cart.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 22 "/Users/ashleydenison/Documents/GitHub/NewMission8/Mission7/Pages/Buy.cshtml"
               Write(i.Books.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 23 "/Users/ashleydenison/Documents/GitHub/NewMission8/Mission7/Pages/Buy.cshtml"
               Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 24 "/Users/ashleydenison/Documents/GitHub/NewMission8/Mission7/Pages/Buy.cshtml"
               Write(i.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "/Users/ashleydenison/Documents/GitHub/NewMission8/Mission7/Pages/Buy.cshtml"
                Write((i.Quantity * i.Price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 27 "/Users/ashleydenison/Documents/GitHub/NewMission8/Mission7/Pages/Buy.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n\n    <tfoot>\n        <tr>\n            <td colspan=\"3\">Total:</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 34 "/Users/ashleydenison/Documents/GitHub/NewMission8/Mission7/Pages/Buy.cshtml"
           Write(Model.cart.CalculateTotal().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </tfoot>\n</table>\n\n<div>\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 852, "\"", 875, 1);
#nullable restore
#line 40 "/Users/ashleydenison/Documents/GitHub/NewMission8/Mission7/Pages/Buy.cshtml"
WriteAttributeValue("", 859, Model.ReturnUrl, 859, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mission7.Pages.BuyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mission7.Pages.BuyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mission7.Pages.BuyModel>)PageContext?.ViewData;
        public Mission7.Pages.BuyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
