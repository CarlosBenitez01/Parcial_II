#pragma checksum "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Course\RegisterCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9ebd962f1a28de0c8c1eedc47cb47637056354e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_RegisterCourse), @"mvc.1.0.view", @"/Views/Course/RegisterCourse.cshtml")]
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
#line 1 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\_ViewImports.cshtml"
using PracticaSegundoParcial_CFBQ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\_ViewImports.cshtml"
using PracticaSegundoParcial_CFBQ.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ebd962f1a28de0c8c1eedc47cb47637056354e", @"/Views/Course/RegisterCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08732044e175e48374365e1a953f6eb649c48cfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_RegisterCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PracticaSegundoParcial_CFBQ.Models.ViewModel.CourseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Students.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Course\RegisterCourse.cshtml"
  
    ViewData["Title"] = "RegisterCourse";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9ebd962f1a28de0c8c1eedc47cb47637056354e4215", async() => {
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
            WriteLiteral("\r\n<h1>RegisterCourse</h1>\r\n<div class=\"form\">\r\n");
#nullable restore
#line 8 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Course\RegisterCourse.cshtml"
     using (Html.BeginForm("Ins_mod_Course", "Course"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Course\RegisterCourse.cshtml"
   Write(Html.TextBoxFor(m => m.Id, new { type = "hidden" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Course\RegisterCourse.cshtml"
   Write(Html.LabelFor(m => m.Title, new { @class = "form__label" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Course\RegisterCourse.cshtml"
   Write(Html.TextBoxFor(m => m.Title, new { @class = "form__input" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Course\RegisterCourse.cshtml"
   Write(Html.ValidationMessageFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br>\r\n");
#nullable restore
#line 16 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Course\RegisterCourse.cshtml"
   Write(Html.LabelFor(m => m.Credits, new { @class = "form__label" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Course\RegisterCourse.cshtml"
   Write(Html.TextBoxFor(m => m.Credits, new { @class = "form__input" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Course\RegisterCourse.cshtml"
   Write(Html.ValidationMessageFor(m => m.Credits));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br>\r\n");
            WriteLiteral("        <input class=\"button\" type =\"submit\" value=\"Register/Update\">\r\n");
#nullable restore
#line 22 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Course\RegisterCourse.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PracticaSegundoParcial_CFBQ.Models.ViewModel.CourseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591