#pragma checksum "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Giving\ListOfStatements.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7522a90f0f6e0b61fd2cda0d10cdd16dfeff1760"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Giving_ListOfStatements), @"mvc.1.0.view", @"/Views/Giving/ListOfStatements.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Giving/ListOfStatements.cshtml", typeof(AspNetCore.Views_Giving_ListOfStatements))]
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
#line 1 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\_ViewImports.cshtml"
using OnlineWebPortal;

#line default
#line hidden
#line 2 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\_ViewImports.cshtml"
using OnlineWebPortal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7522a90f0f6e0b61fd2cda0d10cdd16dfeff1760", @"/Views/Giving/ListOfStatements.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5d96f4b846b31290d57b3069f126f47d25886e", @"/Views/_ViewImports.cshtml")]
    public class Views_Giving_ListOfStatements : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineWebPortal.Models.Payment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Giving", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StatementDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OnlineGiving", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Giving\ListOfStatements.cshtml"
  
    ViewData["Title"] = "Statements";

#line default
#line hidden
            BeginContext(100, 284, true);
            WriteLiteral(@"
<h1>List Of Statements</h1>

<div>
    <h4>Payments</h4>
    <hr />
    <table class=""table"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Type</th>
                <th>Member</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Giving\ListOfStatements.cshtml"
             foreach (var payment in Model)
            {

#line default
#line hidden
            BeginContext(444, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(483, 40, false);
#line 24 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Giving\ListOfStatements.cshtml"
               Write(Html.DisplayFor(modelItem => payment.ID));

#line default
#line hidden
            EndContext();
            BeginContext(523, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(551, 49, false);
#line 25 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Giving\ListOfStatements.cshtml"
               Write(Html.DisplayFor(modelItem => payment.PaymentType));

#line default
#line hidden
            EndContext();
            BeginContext(600, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(628, 55, false);
#line 26 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Giving\ListOfStatements.cshtml"
               Write(Html.DisplayFor(modelItem => payment.RegUser.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(683, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(686, 54, false);
#line 26 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Giving\ListOfStatements.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => payment.RegUser.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(740, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(767, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7522a90f0f6e0b61fd2cda0d10cdd16dfeff17606784", async() => {
                BeginContext(850, 6, true);
                WriteLiteral("Detail");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Giving\ListOfStatements.cshtml"
                                                                              WriteLiteral(payment.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(860, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 29 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Giving\ListOfStatements.cshtml"
            }

#line default
#line hidden
            BeginContext(901, 55, true);
            WriteLiteral("            </tbody>\r\n    </table>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(956, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7522a90f0f6e0b61fd2cda0d10cdd16dfeff17609707", async() => {
                BeginContext(1009, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1017, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineWebPortal.Models.Payment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
