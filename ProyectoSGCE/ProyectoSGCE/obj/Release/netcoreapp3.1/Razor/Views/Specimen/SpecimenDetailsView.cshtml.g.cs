#pragma checksum "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f77e18984d8911becf25c6613aee4ee51daab73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Specimen_SpecimenDetailsView), @"mvc.1.0.view", @"/Views/Specimen/SpecimenDetailsView.cshtml")]
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
#line 1 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\_ViewImports.cshtml"
using ProyectoSGCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\_ViewImports.cshtml"
using ProyectoSGCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f77e18984d8911becf25c6613aee4ee51daab73", @"/Views/Specimen/SpecimenDetailsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"462e8c52e2502b63baa94683e189ff8fcd449436", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Specimen_SpecimenDetailsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProyectoSGCE.Models.SpecimenDetails>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
  
    Layout = "_LayoutStudent";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container my-4 content"">
    <div class=""row g-3 form-input"">
        <div class=""text-center"">
            <h2 class=""title"">Espécimen</h2>
            <hr class=""border-success  border-3"">
            <div class=""col-12 mb-3 d-flex justify-content-center"">
                <div class=""col-xl-12 col-md-12 col-sm-12 carrousel"">
                    <div id=""carouselExample"" class=""carousel slide"">
                        <div class=""carousel-inner "">
");
#nullable restore
#line 16 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
                             foreach (string image in ViewBag.Img)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"carousel-item active\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=", 774, "", 785, 1);
#nullable restore
#line 19 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
WriteAttributeValue("", 779, image, 779, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"especimen.jpg\">\r\n                                </div> \r\n");
#nullable restore
#line 21 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        
                        <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExample"" data-bs-slide=""prev"">
                            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                            <span class=""visually-hidden"">Previous</span>
                        </button>
                        <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExample"" data-bs-slide=""next"">
                            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                            <span class=""visually-hidden"">Next</span>
                        </button>
                    </div>
                </div>
            </div>

");
#nullable restore
#line 37 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
             foreach (SpecimenDetails specimen in ViewBag.Specimens)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-12 mb-3 d-flex justify-content-center row"">
                    <div class=""col-xl-4 col-md-6 mb-3"">
                        <div class=""card"" style=""border-radius: 0.5em;"">
                            <div class=""card-header font-card"" style=""color:black"">
                                Información recolección
                            </div>
                            <ul class=""list-group list-group-flush"" style=""border-radius: 0.5em;"">
                                <li class=""list-group-item"">
                                    País: ");
#nullable restore
#line 48 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
                                     Write(specimen.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Provincia: ");
#nullable restore
#line 51 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
                                          Write(specimen.Province);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Cantón: ");
#nullable restore
#line 54 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
                                       Write(specimen.Canton);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Distrito: ");
#nullable restore
#line 57 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
                                         Write(specimen.District);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Recolector: ");
#nullable restore
#line 60 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
                                           Write(specimen.Collector);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Fecha de recolección: ");
#nullable restore
#line 63 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
                                                     Write(specimen.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-xl-4 col-md-6 mb-3"">
                        <div class=""card"" style=""border-radius: 0.5em;"">
                            <div class=""card-header font-card"" style=""color:black"">
                                Información taxonómica
                            </div>
                            <ul class=""list-group list-group-flush"">
                                <li class=""list-group-item text-start"">
                                    <pre class=""indent"">Orden: ");
#nullable restore
#line 75 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
                                                          Write(specimen.Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n                                </li>\r\n                                <li class=\"list-group-item text-start\">\r\n                                    <pre class=\"indent\">﹂Familia: ");
#nullable restore
#line 78 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
                                                             Write(specimen.Family);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n                                </li>\r\n                                <li class=\"list-group-item text-start\">\r\n                                    <pre class=\"indent\">﹂Subfamilia: ");
#nullable restore
#line 81 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
                                                                Write(specimen.Subfamily);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n                                </li>\r\n                                <li class=\"list-group-item text-start\">\r\n                                    <pre class=\"indent\">﹂Género: ");
#nullable restore
#line 84 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
                                                            Write(specimen.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n                                </li>\r\n                                <li class=\"list-group-item text-start\">\r\n                                    <pre class=\"indent\">﹂Especie: ");
#nullable restore
#line 87 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
                                                             Write(specimen.specie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 93 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""col-12 mb-3 d-flex justify-content-center"">
            <div class=""col-md-4 card"">
                <div class=""card"" style=""border-radius: 0.5em;"">
                    <div class=""card-header font-card"" style=""color:black"">
                        Plantas hospedadoras
                    </div>
                    <ul class=""list-group list-group-flush"" style=""border-radius: 0.5em;"">
");
#nullable restore
#line 102 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
                         foreach (PlantName plant in ViewBag.Plants)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"list-group-item\">\r\n                                ");
#nullable restore
#line 105 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
                           Write(plant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 107 "C:\Users\losre\OneDrive\Escritorio\SGCECristianHernandezCarlosTencioSemestreIAnno2023\ProyectoSGCE .NET\ProyectoSGCE\ProyectoSGCE\Views\Specimen\SpecimenDetailsView.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>       \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProyectoSGCE.Models.SpecimenDetails>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
