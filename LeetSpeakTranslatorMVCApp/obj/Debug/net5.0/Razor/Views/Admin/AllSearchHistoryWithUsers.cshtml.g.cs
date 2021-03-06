#pragma checksum "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistoryWithUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b0a1a4ea8d9eb6007dccbe139c77f050cde879c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AllSearchHistoryWithUsers), @"mvc.1.0.view", @"/Views/Admin/AllSearchHistoryWithUsers.cshtml")]
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
#line 1 "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\_ViewImports.cshtml"
using LeetSpeakTranslatorMVCApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\_ViewImports.cshtml"
using LeetSpeakTranslatorMVCApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistoryWithUsers.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0a1a4ea8d9eb6007dccbe139c77f050cde879c", @"/Views/Admin/AllSearchHistoryWithUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878732f8be61ceb1df3c0c6349cdc7cb08149711", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_AllSearchHistoryWithUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserContentListVM>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dataTables.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistoryWithUsers.cshtml"
  
    ViewData["Title"] = "Search History With Users";
     Layout = "~/Views/Shared/WebGridLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Search History With Users</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b0a1a4ea8d9eb6007dccbe139c77f050cde879c4684", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">Search History</h6>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>UserName</th>
                        <th>FirstName</th>
                        <th>LastName</th>
                        <th>Translated</th>
                        <th>Text</th>
                        <th>Translation</th>
                        <th></th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>UserName</th>
                        <th>FirstName</th>
                        <th>LastName</th>
                        <th>Translated</th>
     ");
            WriteLiteral(@"                   <th>Text</th>
                        <th>Translation</th>
                        <th></th>
                        <th></th>
                        <th></th>
                    </tr>
                </tfoot>
                <tbody>
");
#nullable restore
#line 47 "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistoryWithUsers.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 50 "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistoryWithUsers.cshtml"
                           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 51 "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistoryWithUsers.cshtml"
                           Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 52 "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistoryWithUsers.cshtml"
                           Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 53 "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistoryWithUsers.cshtml"
                           Write(item.Translated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 54 "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistoryWithUsers.cshtml"
                           Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 55 "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistoryWithUsers.cshtml"
                           Write(item.Translation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2038, "\"", 2085, 2);
            WriteAttributeValue("", 2045, "/User/UpdateUser?userName=", 2045, 26, true);
#nullable restore
#line 56 "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistoryWithUsers.cshtml"
WriteAttributeValue("", 2071, item.UserName, 2071, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" />Edit User\'s Profile</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2173, "\"", 2217, 2);
            WriteAttributeValue("", 2180, "/Admin/DeleteUser?userId=", 2180, 25, true);
#nullable restore
#line 57 "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistoryWithUsers.cshtml"
WriteAttributeValue("", 2205, item.UserId, 2205, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" />Delete The User</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2301, "\"", 2353, 2);
            WriteAttributeValue("", 2308, "/User/DeleteContent?contentId=", 2308, 30, true);
#nullable restore
#line 58 "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistoryWithUsers.cshtml"
WriteAttributeValue("", 2338, item.ContentId, 2338, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" />Delete The Search</td>\r\n                        </tr>\r\n");
#nullable restore
#line 60 "D:\Documents\GitHub\leetspeak-translator-mvc-project\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistoryWithUsers.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserContentListVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
