#pragma checksum "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Home\Portal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b9d8d248418b4ec1ef27bbd514ed9e8662f1f71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Portal), @"mvc.1.0.view", @"/Views/Home/Portal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Portal.cshtml", typeof(AspNetCore.Views_Home_Portal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b9d8d248418b4ec1ef27bbd514ed9e8662f1f71", @"/Views/Home/Portal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5d96f4b846b31290d57b3069f126f47d25886e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Portal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineWebPortal.Models.RegUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Group", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FindGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserChurchGroups", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Giving", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OnlineGiving", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Enquiry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateEnquiry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EventList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Home\Portal.cshtml"
  
    ViewData["Title"] = "Portal Page";

#line default
#line hidden
            BeginContext(86, 1259, true);
            WriteLiteral(@"

    <style>

        .tile-nav span {
            font-size: 3em;
        }

        

        .tile-nav {
            position:relative;
            background: transparent;
            width: 100%;
            min-height: 80px;
            padding:0;
            text-align: center;
        }
        .tile-nav li {
            position:relative;
            display: inline-block;
            width: 30%;
            margin: 0 100px;
            padding: 0;
            border: 6px solid white;
        }
        .tile-nav li:hover {
            background:#ffffff;
        }
         .tile-nav li a{
             color:#FFB90F;
             margin: 100px 0;
         }
         .tile-nav p {
            font-size: 1.1em;
            color:#aaaaaa;
            color:#555555;
        }
         .tile-nav p:hover {        
            color:#808080;
        }
            .tile-nav li a:hover {
                text-decoration: none;
                color:darkorange;

    ");
            WriteLiteral("        }\r\n        #verse{\r\n            position:relative;\r\n            background: ;\r\n            margin: 40px 0;\r\n            padding:0 80px;\r\n        }\r\n\r\n\r\n            /*// Small devices (landscape phones, 576px and up)*/\r\n        ");
            EndContext();
            BeginContext(1346, 1528, true);
            WriteLiteral(@"@media (max-width: 576px) {
             h1{
                    font-size:2.2em;
                    font-weight:normal;
                    text-align:center;
                    margin-bottom: 20px;
                }
              #verse{
                    position:relative;
                    background: ;
                    margin: 40px 0;
                    padding:0 30px;
                }
                    .tile-nav {
                        position:relative;
                        background: transparent;
                        width: 100%;
                        min-height: 80px;
                        margin:0;
                        padding:0;
                        /*text-align: center;*/
                    }

                    .tile-nav li {
                        position:relative;
                        display: inline-block;
                        width: 50%;
                        height:140px;
                        margin: 0 auto;
        ");
            WriteLiteral(@"                margin-left: -4.6px;
                        padding: 0;
                        /*text-align:center;*/
                    }
                    .tile-nav li a {
                        position:absolute;
                        width:100%;
                        height:140px;
                        /*text-align:center;*/

                        margin:0;
                        left:0;
                        padding:0;
                    }
        }
            ");
            EndContext();
            BeginContext(2875, 1400, true);
            WriteLiteral(@"@media (min-width: 576px) {
                .heading{
                    font-size:2.2em;
                    font-weight:lighter;
                    text-align:center;
                    margin-bottom: 20px;
                }
                    .tile-nav {
                        position:relative;
                        background: transparent;
                        width: 100%;
                        min-height: 80px;
                        margin:0;
                        padding:0;
                        text-align: center;
                    }

                    .tile-nav li {
                        position:relative;
                        display: inline-block;
                        width: 50%;
                        height:140px;
                        margin: 0 auto;
                        margin-left: -4.6px;
                        padding: 0;
                        text-align:center;
                    }
                    .tile-nav li a {
     ");
            WriteLiteral(@"                   position:absolute;
                        width:100%;
                        height:140px;
                        text-align:center;

                        margin:0;
                        left:0;
                        padding:0;
                    }
            }

            /*// Medium devices (tablets, 768px and up)*/
            ");
            EndContext();
            BeginContext(4276, 119, true);
            WriteLiteral("@media (min-width: 768px) {\r\n\r\n            }\r\n\r\n            /*// Large devices (desktops, 992px and up)*/\r\n            ");
            EndContext();
            BeginContext(4396, 850, true);
            WriteLiteral(@"@media (min-width: 992px) {
                .heading{
                    font-size:2.4em;
                    font-weight:lighter;
                    text-align:center;
                    margin-bottom: 20px;
                }
                .tile-nav span {
                    font-size: 4em;
                }

                .tile-nav p {
                    font-size: 1.2em;
                }
                    .tile-nav li a {
                        position:absolute;
                        width:100%;
                        height:140px;
                        text-align:center;

                        margin:0;
                        left:0;
                        padding:0;
                    }
            }

            /*// Extra large devices (large desktops, 1200px and up)*/
            ");
            EndContext();
            BeginContext(5247, 100, true);
            WriteLiteral("@media (min-width: 1200px) {\r\n            }\r\n    </style>\r\n   \r\n        <h1>Welcome to your portal, ");
            EndContext();
            BeginContext(5348, 18, false);
#line 180 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Home\Portal.cshtml"
                               Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5366, 791, true);
            WriteLiteral(@"</h1>
        

        
            <div id=""verse"" class="""">
                <p>
                    <i>
                        ""For the wrath of God is revealed from heaven against all ungodliness and
                        unrighteousness of men, who by their unrighteousness suppress the truth. For what can be known about God
                        is plain to them, because God has shown it to them. For his invisible attributes, namely, his eternal
                        power and divine nature, have been clearly perceived, ever since the creation of the world, in the things
                        that have been made. So they are without excuse.""
                    </i>
                    <b>  Romans 1:18-20</b>
                </p>
            </div>

");
            EndContext();
#line 197 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Home\Portal.cshtml"
         if (TempData["message"] != null)
        {

#line default
#line hidden
            BeginContext(6211, 83, true);
            WriteLiteral("            <p class=\"alert alert-success alert-dismissible fade show text-center\">");
            EndContext();
            BeginContext(6295, 19, false);
#line 199 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Home\Portal.cshtml"
                                                                              Write(TempData["message"]);

#line default
#line hidden
            EndContext();
            BeginContext(6314, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 200 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Home\Portal.cshtml"
        }

#line default
#line hidden
            BeginContext(6331, 13, true);
            WriteLiteral("        <div>");
            EndContext();
            BeginContext(6345, 19, false);
#line 201 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Home\Portal.cshtml"
        Write(ViewData["message"]);

#line default
#line hidden
            EndContext();
            BeginContext(6364, 84, true);
            WriteLiteral("</div>\r\n                <div class=\"tile-nav col-sm-12\">\r\n                    <ul>\r\n");
            EndContext();
#line 204 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Home\Portal.cshtml"
                         if (User.IsInRole("Admin"))
                        {

#line default
#line hidden
            BeginContext(6529, 81, true);
            WriteLiteral("                            <li class=\"tile-1\">\r\n                                ");
            EndContext();
            BeginContext(6610, 220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b9d8d248418b4ec1ef27bbd514ed9e8662f1f7116525", async() => {
                BeginContext(6654, 172, true);
                WriteLiteral("\r\n                                    <span><i class=\"fa fa-users\"></i></span>\r\n                                    <p>List Of Members</p>\r\n                                ");
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
            BeginContext(6830, 37, true);
            WriteLiteral("\r\n                            </li>\r\n");
            EndContext();
#line 212 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Home\Portal.cshtml"
                         }

#line default
#line hidden
            BeginContext(6895, 73, true);
            WriteLiteral("                        <li class=\"tile-2\">\r\n                            ");
            EndContext();
            BeginContext(6968, 235, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b9d8d248418b4ec1ef27bbd514ed9e8662f1f7118648", async() => {
                BeginContext(7043, 156, true);
                WriteLiteral("\r\n                                <span><i class=\"fa fa-user\"></i></span>\r\n                                <p>Your Profile</p>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 214 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Home\Portal.cshtml"
                                                                                WriteLiteral(Model.ID);

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
            BeginContext(7203, 106, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li class=\"tile-3\">\r\n                            ");
            EndContext();
            BeginContext(7309, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b9d8d248418b4ec1ef27bbd514ed9e8662f1f7121498", async() => {
                BeginContext(7358, 159, true);
                WriteLiteral("\r\n                                <span><i class=\"fa fa-search\"></i></span>\r\n                                <p>Church Groups</p>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7521, 106, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li class=\"tile-4\">\r\n                            ");
            EndContext();
            BeginContext(7627, 242, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b9d8d248418b4ec1ef27bbd514ed9e8662f1f7123353", async() => {
                BeginContext(7708, 157, true);
                WriteLiteral("\r\n                                <span><i class=\"fa fa-trophy\"></i></span>\r\n                                <p>Your Groups</p>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 226 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Home\Portal.cshtml"
                                                                                      WriteLiteral(Model.ID);

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
            BeginContext(7869, 106, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li class=\"tile-5\">\r\n                            ");
            EndContext();
            BeginContext(7975, 245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b9d8d248418b4ec1ef27bbd514ed9e8662f1f7126210", async() => {
                BeginContext(8053, 163, true);
                WriteLiteral("\r\n                                <span><i class=\"fas fa-hand-holding-usd\"></i></span>\r\n                                <p>Giving</p>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 232 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Home\Portal.cshtml"
                                                                                   WriteLiteral(Model.ID);

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
            BeginContext(8220, 106, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li class=\"tile-6\">\r\n                            ");
            EndContext();
            BeginContext(8326, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b9d8d248418b4ec1ef27bbd514ed9e8662f1f7129070", async() => {
                BeginContext(8406, 155, true);
                WriteLiteral("\r\n                                <span><i class=\"fa fa-envelope\"></i></span>\r\n                                <p>Enquiry</p>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 238 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Home\Portal.cshtml"
                                                                                     WriteLiteral(Model.ID);

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
            BeginContext(8565, 110, true);
            WriteLiteral("\r\n                        </li>\r\n\r\n\r\n                        <li class=\"tile-6\">\r\n                            ");
            EndContext();
            BeginContext(8675, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b9d8d248418b4ec1ef27bbd514ed9e8662f1f7131932", async() => {
                BeginContext(8724, 159, true);
                WriteLiteral("\r\n                                <span><i class=\"fas fa-calendar-alt\"></i></span>\r\n                                <p>Events</p>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8887, 106, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li class=\"tile-6\">\r\n                            ");
            EndContext();
            BeginContext(8993, 220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b9d8d248418b4ec1ef27bbd514ed9e8662f1f7133791", async() => {
                BeginContext(9053, 156, true);
                WriteLiteral("\r\n                                <span><i class=\"fa fa-church\"></i></span>\r\n                                <p>Ministries</p>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 252 "C:\Users\CCUK\Desktop\OnlineWebPortal\OnlineWebPortal\Views\Home\Portal.cshtml"
                                                                 WriteLiteral(Model.ID);

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
            BeginContext(9213, 105, true);
            WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n\r\n\r\n\r\n               ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineWebPortal.Models.RegUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
