#pragma checksum "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa73593ff8267b3ce2d969c8ffcbd99c1ac662e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Formation_ConsultFormation), @"mvc.1.0.view", @"/Views/Formation/ConsultFormation.cshtml")]
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
#line 1 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\_ViewImports.cshtml"
using CoopDogsFormation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\_ViewImports.cshtml"
using CoopDogsFormation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
using CoopDogsFormation.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa73593ff8267b3ce2d969c8ffcbd99c1ac662e3", @"/Views/Formation/ConsultFormation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51c4979ce773dfeb683eede83372e4e875719c43", @"/Views/_ViewImports.cshtml")]
    public class Views_Formation_ConsultFormation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Formation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FormationList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
  
    Layout = "_LayoutLogin";
    ViewData["Title"] = "Formation: " + @ViewBag.Formation.Title;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa73593ff8267b3ce2d969c8ffcbd99c1ac662e35221", async() => {
                WriteLiteral("<span>Revenir à la liste des formations</span>");
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
            WriteLiteral("\r\n<h1>Formation: ");
#nullable restore
#line 7 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
          Write(ViewBag.Formation.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p class=\"lines\">");
#nullable restore
#line 9 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
            Write(ViewBag.Formation.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<div class=\"accordion accordion-flush\" id=\"accordionFormation\">\r\n\r\n");
#nullable restore
#line 13 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
     foreach (ChapterFormationDto chapter in ViewBag.Formation.ChapterFormations)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"accordion-item\">\r\n            <h2 class=\"accordion-header\"");
            BeginWriteAttribute("id", " id=\"", 583, "\"", 605, 2);
            WriteAttributeValue("", 588, "h_", 588, 2, true);
#nullable restore
#line 16 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
WriteAttributeValue("", 590, chapter.Number, 590, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#c_");
#nullable restore
#line 17 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
                                                                                                                 Write(chapter.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 765, "\"", 798, 2);
            WriteAttributeValue("", 781, "c_", 781, 2, true);
#nullable restore
#line 17 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
WriteAttributeValue("", 783, chapter.Number, 783, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    Chapitre ");
#nullable restore
#line 18 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
                        Write(chapter.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 18 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
                                          Write(chapter.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n            </h2>\r\n            <div");
            BeginWriteAttribute("id", " id=\"", 927, "\"", 949, 2);
            WriteAttributeValue("", 932, "c_", 932, 2, true);
#nullable restore
#line 21 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
WriteAttributeValue("", 934, chapter.Number, 934, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"accordion-collapse collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 986, "\"", 1021, 2);
            WriteAttributeValue("", 1004, "h_", 1004, 2, true);
#nullable restore
#line 21 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
WriteAttributeValue("", 1006, chapter.Number, 1006, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-parent=\"#accordionFormation\">\r\n                <div class=\"accordion-body\">\r\n                    <p class=\"lines\">");
#nullable restore
#line 23 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
                                Write(chapter.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 24 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
                     if (!string.IsNullOrEmpty(chapter.UrlVideo))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <video controls width=\"560\"\r\n                               height=\"315\"\r\n                               style=\"margin:5px auto 2px auto; display:block;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aa73593ff8267b3ce2d969c8ffcbd99c1ac662e311646", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1482, "~/Files/Videos/", 1482, 15, true);
#nullable restore
#line 29 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
AddHtmlAttributeValue("", 1497, chapter.UrlVideo, 1497, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </video>\r\n");
#nullable restore
#line 31 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 35 "F:\dev\ProjetManonFormation\CoopDogsFormation\CoopDogsFormation\Views\Formation\ConsultFormation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa73593ff8267b3ce2d969c8ffcbd99c1ac662e313850", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa73593ff8267b3ce2d969c8ffcbd99c1ac662e314950", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
