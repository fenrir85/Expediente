#pragma checksum "C:\Users\FENRIUS\proyectos\Expediente\Views\Expediente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18b1d924c7285f09a694e03691a30ea31bc0f874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expediente_Index), @"mvc.1.0.view", @"/Views/Expediente/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Expediente/Index.cshtml", typeof(AspNetCore.Views_Expediente_Index))]
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
#line 1 "C:\Users\FENRIUS\proyectos\Expediente\Views\_ViewImports.cshtml"
using Expediente;

#line default
#line hidden
#line 2 "C:\Users\FENRIUS\proyectos\Expediente\Views\_ViewImports.cshtml"
using Expediente.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18b1d924c7285f09a694e03691a30ea31bc0f874", @"/Views/Expediente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff6df8fde9bb52f69ac42561ff131d82d904144f", @"/Views/_ViewImports.cshtml")]
    public class Views_Expediente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Persona>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\FENRIUS\proyectos\Expediente\Views\Expediente\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_Layout";
    

#line default
#line hidden
            BeginContext(93, 401, true);
            WriteLiteral(@"
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
    </ol>
    <strong>Expedientes</strong>

     <p>
        ID: ");
            EndContext();
            BeginContext(495, 15, false);
#line 17 "C:\Users\FENRIUS\proyectos\Expediente\Views\Expediente\Index.cshtml"
       Write(Model.PersonaId);

#line default
#line hidden
            EndContext();
            BeginContext(510, 23, true);
            WriteLiteral("<br/>\r\n        Nombre: ");
            EndContext();
            BeginContext(534, 12, false);
#line 18 "C:\Users\FENRIUS\proyectos\Expediente\Views\Expediente\Index.cshtml"
           Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(546, 33, true);
            WriteLiteral("<br/>\r\n        Apellido Paterno: ");
            EndContext();
            BeginContext(580, 21, false);
#line 19 "C:\Users\FENRIUS\proyectos\Expediente\Views\Expediente\Index.cshtml"
                     Write(Model.ApellidoPaterno);

#line default
#line hidden
            EndContext();
            BeginContext(601, 34, true);
            WriteLiteral(" <br/>\r\n        Apellido Materno: ");
            EndContext();
            BeginContext(636, 21, false);
#line 20 "C:\Users\FENRIUS\proyectos\Expediente\Views\Expediente\Index.cshtml"
                     Write(Model.ApellidoMaterno);

#line default
#line hidden
            EndContext();
            BeginContext(657, 45, true);
            WriteLiteral(" <br/>\r\n     </p>\r\n    \r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Persona> Html { get; private set; }
    }
}
#pragma warning restore 1591
