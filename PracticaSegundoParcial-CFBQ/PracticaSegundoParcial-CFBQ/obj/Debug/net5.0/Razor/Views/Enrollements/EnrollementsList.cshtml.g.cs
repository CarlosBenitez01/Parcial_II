#pragma checksum "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Enrollements\EnrollementsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbb6b83ac41c1e7f99e5c604fbbf40b7b94d1b19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enrollements_EnrollementsList), @"mvc.1.0.view", @"/Views/Enrollements/EnrollementsList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbb6b83ac41c1e7f99e5c604fbbf40b7b94d1b19", @"/Views/Enrollements/EnrollementsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08732044e175e48374365e1a953f6eb649c48cfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Enrollements_EnrollementsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PracticaSegundoParcial_CFBQ.Dominio.Enrollements>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Enrollements\EnrollementsList.cshtml"
  
    ViewData["Title"] = "EnrollementsList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>EnrollementsList</h1>\r\n\r\n<br />\r\n<h3>");
#nullable restore
#line 9 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Enrollements\EnrollementsList.cshtml"
Write(Html.ActionLink("Register", "EnrollStudents"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<br />\r\n<table id=\"mitabla\" class=\"table table-dark table-striped\">\r\n    <th>\r\n        Title\r\n    </th>\r\n    <th>\r\n        Last Name\r\n    </th>\r\n    <th>\r\n        First Midle Name\r\n    </th>\r\n    <th>\r\n        Grade\r\n    </th>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Enrollements\EnrollementsList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Enrollements\EnrollementsList.cshtml"
               Write(item.Course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Enrollements\EnrollementsList.cshtml"
               Write(item.Students.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Enrollements\EnrollementsList.cshtml"
               Write(item.Students.FirtsMidName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Enrollements\EnrollementsList.cshtml"
               Write(item.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\cb272\Desktop\PracticaSegundoParcial-CFBQ\PracticaSegundoParcial-CFBQ\Views\Enrollements\EnrollementsList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PracticaSegundoParcial_CFBQ.Dominio.Enrollements>> Html { get; private set; }
    }
}
#pragma warning restore 1591
