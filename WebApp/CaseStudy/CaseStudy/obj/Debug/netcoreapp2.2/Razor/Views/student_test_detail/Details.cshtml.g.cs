#pragma checksum "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5beb8fbdb7495868d633bdef9c9798fe8ffd91b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_student_test_detail_Details), @"mvc.1.0.view", @"/Views/student_test_detail/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/student_test_detail/Details.cshtml", typeof(AspNetCore.Views_student_test_detail_Details))]
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
#line 1 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy;

#line default
#line hidden
#line 2 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy.Models;

#line default
#line hidden
#line 3 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy.ViewModels;

#line default
#line hidden
#line 4 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5beb8fbdb7495868d633bdef9c9798fe8ffd91b", @"/Views/student_test_detail/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed97f03465a014740c128c8c7ba5c10f4e5d1ac9", @"/Views/_ViewImports.cshtml")]
    public class Views_student_test_detail_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CaseStudy.Model.student_test_detail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(89, 142, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>student_test_detail</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(232, 43, false);
#line 14 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.student));

#line default
#line hidden
            EndContext();
            BeginContext(275, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(339, 50, false);
#line 17 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayFor(model => model.student.id_student));

#line default
#line hidden
            EndContext();
            BeginContext(389, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(452, 44, false);
#line 20 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.question));

#line default
#line hidden
            EndContext();
            BeginContext(496, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(560, 52, false);
#line 23 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayFor(model => model.question.id_question));

#line default
#line hidden
            EndContext();
            BeginContext(612, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(675, 44, false);
#line 26 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.answer_a));

#line default
#line hidden
            EndContext();
            BeginContext(719, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(783, 40, false);
#line 29 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayFor(model => model.answer_a));

#line default
#line hidden
            EndContext();
            BeginContext(823, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(886, 44, false);
#line 32 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.answer_b));

#line default
#line hidden
            EndContext();
            BeginContext(930, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(994, 40, false);
#line 35 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayFor(model => model.answer_b));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1097, 44, false);
#line 38 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.answer_c));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1205, 40, false);
#line 41 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayFor(model => model.answer_c));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1308, 44, false);
#line 44 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.answer_d));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1416, 40, false);
#line 47 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayFor(model => model.answer_d));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1519, 50, false);
#line 50 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.student_answer));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1633, 46, false);
#line 53 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayFor(model => model.student_answer));

#line default
#line hidden
            EndContext();
            BeginContext(1679, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1742, 45, false);
#line 56 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.test_code));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1851, 41, false);
#line 59 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
       Write(Html.DisplayFor(model => model.test_code));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1939, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5beb8fbdb7495868d633bdef9c9798fe8ffd91b11401", async() => {
                BeginContext(1985, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "D:\C7\Module2\WebApp\CaseStudy\CaseStudy\Views\student_test_detail\Details.cshtml"
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
            BeginContext(1993, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2001, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5beb8fbdb7495868d633bdef9c9798fe8ffd91b13725", async() => {
                BeginContext(2023, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(2039, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CaseStudy.Model.student_test_detail> Html { get; private set; }
    }
}
#pragma warning restore 1591
