#pragma checksum "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Login\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c404e2efa84ab00316fb019c8cf7e98fbf69739"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index2), @"mvc.1.0.view", @"/Views/Login/Index2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c404e2efa84ab00316fb019c8cf7e98fbf69739", @"/Views/Login/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart.Models.User>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Login\Index2.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c404e2efa84ab00316fb019c8cf7e98fbf697393522", async() => {
                WriteLiteral("\r\n    <title>Login</title>\r\n    <style>\r\n        #login-div {\r\n            position: absolute;\r\n            left: 40%;\r\n            top: 40%;\r\n            border: 1px solid #000;\r\n            padding: 20px 20px;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c404e2efa84ab00316fb019c8cf7e98fbf697394744", async() => {
                WriteLiteral("\r\n    <div id=\"login-div\">\r\n");
#nullable restore
#line 24 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Login\Index2.cshtml"
         using (Html.BeginForm("Authenticate2", "Login", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <table>\r\n                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 29 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Login\Index2.cshtml"
                   Write(Html.LabelFor(model => model.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Login\Index2.cshtml"
                   Write(Html.EditorFor(model => model.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Login\Index2.cshtml"
                   Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Login\Index2.cshtml"
                   Write(Html.EditorFor(model => model.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td align=""right"">
                        <input type=""submit"" name=""name"" value=""login"" />
                    </td>
                </tr>
            </table>
");
#nullable restore
#line 50 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Login\Index2.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591