#pragma checksum "D:\ornek\LeetSpeakTranslatorMVCApp\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07fcb018c45e0df05dcdbd5cd120c8226a20ddbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AllSearchHistory), @"mvc.1.0.view", @"/Views/Admin/AllSearchHistory.cshtml")]
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
#line 1 "D:\ornek\LeetSpeakTranslatorMVCApp\LeetSpeakTranslatorMVCApp\Views\_ViewImports.cshtml"
using LeetSpeakTranslatorMVCApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ornek\LeetSpeakTranslatorMVCApp\LeetSpeakTranslatorMVCApp\Views\_ViewImports.cshtml"
using LeetSpeakTranslatorMVCApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ornek\LeetSpeakTranslatorMVCApp\LeetSpeakTranslatorMVCApp\Views\_ViewImports.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\ornek\LeetSpeakTranslatorMVCApp\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistory.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07fcb018c45e0df05dcdbd5cd120c8226a20ddbe", @"/Views/Admin/AllSearchHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878732f8be61ceb1df3c0c6349cdc7cb08149711", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_AllSearchHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contents>>
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
#line 3 "D:\ornek\LeetSpeakTranslatorMVCApp\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistory.cshtml"
  
    ViewData["Title"] = "Search History";
    Layout = "~/Views/Shared/WebGridLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Search History</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "07fcb018c45e0df05dcdbd5cd120c8226a20ddbe4692", async() => {
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
                        <th>Text</th>
                        <th>Translated</th>
                        <th>Translation</th>
                        <th></th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Translated</th>
                        <th>Text</th>
                        <th>Translation</th>
                        <th></th>
                    </tr>
                </tfoot>
                <tbody>
");
#nullable restore
#line 37 "D:\ornek\LeetSpeakTranslatorMVCApp\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistory.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 40 "D:\ornek\LeetSpeakTranslatorMVCApp\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistory.cshtml"
                           Write(item.text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "D:\ornek\LeetSpeakTranslatorMVCApp\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistory.cshtml"
                           Write(item.translated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "D:\ornek\LeetSpeakTranslatorMVCApp\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistory.cshtml"
                           Write(item.translation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1444, "\"", 1489, 2);
            WriteAttributeValue("", 1451, "/User/DeleteContent?contentId=", 1451, 30, true);
#nullable restore
#line 43 "D:\ornek\LeetSpeakTranslatorMVCApp\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistory.cshtml"
WriteAttributeValue("", 1481, item.Id, 1481, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" />Delete The Search</td>\r\n                        </tr>\r\n");
#nullable restore
#line 45 "D:\ornek\LeetSpeakTranslatorMVCApp\LeetSpeakTranslatorMVCApp\Views\Admin\AllSearchHistory.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contents>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
