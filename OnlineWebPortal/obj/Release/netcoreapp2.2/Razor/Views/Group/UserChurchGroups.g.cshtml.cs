#pragma checksum "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Group\UserChurchGroups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dbb66c68e4d5aaaf5cde6df2a8bbc1828be389a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_UserChurchGroups), @"mvc.1.0.view", @"/Views/Group/UserChurchGroups.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Group/UserChurchGroups.cshtml", typeof(AspNetCore.Views_Group_UserChurchGroups))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dbb66c68e4d5aaaf5cde6df2a8bbc1828be389a", @"/Views/Group/UserChurchGroups.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5d96f4b846b31290d57b3069f126f47d25886e", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_UserChurchGroups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineWebPortal.Models.RegUserChurchGroup>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Portal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Group\UserChurchGroups.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(108, 141, true);
            WriteLiteral("\r\n    <div class=\"content\">\r\n        <h3>Your Groups</h3>\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                <ul>\r\n");
            EndContext();
#line 11 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Group\UserChurchGroups.cshtml"
                     foreach (var group in Model)
                    {

#line default
#line hidden
            BeginContext(323, 28, true);
            WriteLiteral("                        <li>");
            EndContext();
            BeginContext(352, 50, false);
#line 13 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Group\UserChurchGroups.cshtml"
                       Write(Html.DisplayFor(m => group.ChurchGroups.GroupName));

#line default
#line hidden
            EndContext();
            BeginContext(402, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 14 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Group\UserChurchGroups.cshtml"
                    }

#line default
#line hidden
            BeginContext(432, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 15 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Group\UserChurchGroups.cshtml"
                     if (Model.Count() == 0)
                    {

#line default
#line hidden
            BeginContext(501, 78, true);
            WriteLiteral("                        <li><h4>You are not part of any group yet!</h4></li>\r\n");
            EndContext();
#line 18 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Group\UserChurchGroups.cshtml"
                    }

#line default
#line hidden
            BeginContext(602, 124, true);
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n\r\n        <hr />\r\n        <div class=\"content-nav\">\r\n            ");
            EndContext();
            BeginContext(726, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dbb66c68e4d5aaaf5cde6df2a8bbc1828be389a6026", async() => {
                BeginContext(771, 17, true);
                WriteLiteral("Back to dashboard");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(792, 28, true);
            WriteLiteral("\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineWebPortal.Models.RegUserChurchGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
