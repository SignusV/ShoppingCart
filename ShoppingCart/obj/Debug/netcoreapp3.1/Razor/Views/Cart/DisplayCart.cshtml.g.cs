#pragma checksum "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64d07afbeaac4a5e5db7f697e648efee71b4e737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_DisplayCart), @"mvc.1.0.view", @"/Views/Cart/DisplayCart.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64d07afbeaac4a5e5db7f697e648efee71b4e737", @"/Views/Cart/DisplayCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_DisplayCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/cart/displaycart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
  
    ViewData["Title"] = "View Cart";
    string total = (string)ViewData["total"];
    bool loggedIn = (bool)ViewData["loggedin"];
    List<Cart> cart = (List<Cart>)ViewData["cart"];
    List<string> amt = new List<string>();
    foreach (var item in cart)
    {
        amt.Add((item.Price * item.Quantity).ToString("#0.00"));
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64d07afbeaac4a5e5db7f697e648efee71b4e7374108", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<style>
    #empty {
        text-align: center;
        font-weight: bold;
        font-size: 36px;
    }

    .total {
        font-size: 20px;
        position: fixed;
        top: 75px;
        right: 50px;
    }

    .product_container img {
        width: 200px;
        height: 200px;
        border: solid 1px black;
        display: block;
        margin-left: 50px;
        margin-right: 50px;
        margin-top: 20px;
    }

    table {
        margin: auto;
    }

    .remove_icon {
        cursor: pointer;
        width: 20px;
        height: 20px;
        margin-left: 200px;
    }

    .product_container {
        border: solid black 2px;
        display: block;
        margin: 20px 50px;
    }

    .quantity {
        width: 40px;
    }
</style>

<div id=""header"">
    <span style=""font-size:20px""><b>View Cart</b> </span><a href=""/Product/DisplayProduct""><u>Continue Shopping</u></a> |
");
#nullable restore
#line 66 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
     if (loggedIn)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"/Purchases/DisplayPurchases\" id=\"checkout\"><u>Checkout</u></a>\r\n");
#nullable restore
#line 69 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"/Login/Index2\" id=\"checkout\"><u>Checkout</u></a>\r\n");
#nullable restore
#line 73 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span class=\"total\"><b>Total: $<span id=\"total_price\">");
#nullable restore
#line 74 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
                                                     Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></b></span>\r\n</div>\r\n<div id=\"body\">\r\n");
#nullable restore
#line 77 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
     if (total == "0.00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span id=\"empty\" style=\"display:block\">\r\n            <br /><br /><br />\r\n            Your Cart Is Empty\r\n        </span>\r\n");
#nullable restore
#line 83 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span id=\"empty\" style=\"display:none\">\r\n            <br /><br /><br />\r\n            Your Cart Is Empty\r\n        </span>\r\n        <table>\r\n");
#nullable restore
#line 91 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
             for (int i = 0; i < cart.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("id", " id=", 2123, "", 2138, 1);
#nullable restore
#line 93 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
WriteAttributeValue("", 2127, cart[i].Id, 2127, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>\r\n                        <div class=\"product_container text-center\">\r\n");
#nullable restore
#line 96 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
                              
                                string link = ViewData["images_prefix"] + cart[i].Image;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 2421, "\"", 2432, 1);
#nullable restore
#line 99 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
WriteAttributeValue("", 2427, link, 2427, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <b>");
#nullable restore
#line 100 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
                          Write(cart[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                            <br />\r\n                            ");
#nullable restore
#line 102 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
                       Write(cart[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                    <td align=\"left\">\r\n                        Unit Price: $<span class=\"price\">");
#nullable restore
#line 106 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
                                                    Write(cart[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <br /><br />\r\n                        Quantity: <input class=\"quantity\" type=\"number\"");
            BeginWriteAttribute("value", " value=", 2862, "", 2886, 1);
#nullable restore
#line 108 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
WriteAttributeValue("", 2869, cart[i].Quantity, 2869, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"1\"");
            BeginWriteAttribute("quantity_id", " quantity_id=", 2894, "", 2918, 1);
#nullable restore
#line 108 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
WriteAttributeValue("", 2907, cart[i].Id, 2907, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <br /><br />\r\n                        Amount: $<span class=\"amount\"");
            BeginWriteAttribute("amount_id", " amount_id=", 3012, "", 3034, 1);
#nullable restore
#line 110 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
WriteAttributeValue("", 3023, cart[i].Id, 3023, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 110 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
                                                                       Write(amt[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                    <td><image src=\"/img/remove_icon.png\" class=\"remove_icon\"");
            BeginWriteAttribute("product_id", " product_id=", 3155, "", 3178, 1);
#nullable restore
#line 112 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
WriteAttributeValue("", 3167, cart[i].Id, 3167, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                </tr>\r\n");
#nullable restore
#line 114 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 116 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Cart\DisplayCart.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591