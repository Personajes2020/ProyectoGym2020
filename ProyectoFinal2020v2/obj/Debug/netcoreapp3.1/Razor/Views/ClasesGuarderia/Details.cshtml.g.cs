#pragma checksum "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0083cc57043df3623ef4b474e3a0ad068d0a339b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClasesGuarderia_Details), @"mvc.1.0.view", @"/Views/ClasesGuarderia/Details.cshtml")]
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
#line 1 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0083cc57043df3623ef4b474e3a0ad068d0a339b", @"/Views/ClasesGuarderia/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91eb63b7429581f3b7b57ba3bcdbd293f2c271e", @"/Views/_ViewImports.cshtml")]
    public class Views_ClasesGuarderia_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoFinal2020v2.Models.ClaseGuarderiaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
   Layout = "~/Views/Shared/_AdminLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">



<h4 class=""container p-3 my-3 bg-secondary text-white text-center rounded-l""><i class=""fas fa-align-justify ""></i> Detalle Clase</h4>


<div class=""container"">
    <div class=""row"">

        <div class=""column"">
            <h4>ClaseGuarderia</h4>
            <dl class=""row"">
");
#nullable restore
#line 22 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
                 foreach (var guarderia in Model.ClaseGuarderia)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-4\">\r\n                        HoraInicio\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
                   Write(guarderia.HoraInicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        Hora Fin\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 34 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
                   Write(guarderia.HoraFin);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        Fecha\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 40 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
                   Write(guarderia.Fecha.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        Cupo\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 46 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
                   Write(guarderia.Cupo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
            WriteLiteral("                    <dt class=\"col-sm-4\">\r\n                        Estado\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 58 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
                   Write(guarderia.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\"></dt>\r\n                    <dd class=\"col-sm-8\"></dd>\r\n                    <dt class=\"col-sm-4\">\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0083cc57043df3623ef4b474e3a0ad068d0a339b8643", async() => {
                WriteLiteral("Editar");
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
#nullable restore
#line 64 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
                                               WriteLiteral(guarderia.IdClaseGuarderia);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0083cc57043df3623ef4b474e3a0ad068d0a339b10978", async() => {
                WriteLiteral("Atras");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </dt>\r\n");
#nullable restore
#line 67 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dl>\r\n        </div>\r\n        <div class=\"column\">\r\n            <h4>\r\n                Cuidador\r\n            </h4>\r\n            <dl class=\"row\">\r\n\r\n");
#nullable restore
#line 78 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
                 foreach (var empleado in Model.ClaseGuarderiaEmpleado)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-4\">\r\n                        Id Empleado\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 85 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
                   Write(empleado.IdEmpleado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        Empleado\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n");
#nullable restore
#line 91 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
                         foreach (Empleado emp in (List<Empleado>)ViewData["Empleados"])
                        {
                            if (empleado.IdEmpleado == emp.IdEmpleado)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
                           Write(emp.Nombre);

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
                                       Write(emp.Apellido1);

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
                                                          
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </dd>\r\n");
#nullable restore
#line 99 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Version Final\ProyectoGym2020\ProyectoFinal2020v2\Views\ClasesGuarderia\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dl>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoFinal2020v2.Models.ClaseGuarderiaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
