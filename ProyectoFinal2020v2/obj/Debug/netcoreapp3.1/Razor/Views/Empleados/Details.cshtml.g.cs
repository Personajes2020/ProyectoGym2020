#pragma checksum "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c27dcf9cc7539b6662b3ec4372d063559484c7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_Details), @"mvc.1.0.view", @"/Views/Empleados/Details.cshtml")]
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
#line 1 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c27dcf9cc7539b6662b3ec4372d063559484c7d", @"/Views/Empleados/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91eb63b7429581f3b7b57ba3bcdbd293f2c271e", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoFinal2020v2.Models.Empleado>
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
#nullable restore
#line 2 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
   Layout = "~/Views/Shared/_AdminLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">

<h4 class=""container p-3 my-3 bg-secondary text-white text-center rounded-l""><i class=""fas fa-align-justify ""></i> Detalle Empleado</h4>


<hr />
<div class=""container"">
    <dl class=""row"">
");
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Identificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Identificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellido1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Apellido1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellido2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Apellido2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaNac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaNac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("    </dl>\r\n\r\n\r\n    \r\n    <dl class=\"column\">\r\n        <div class=\"container\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 78 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Area));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 81 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayFor(model => model.Area));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 84 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoDeEmp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 87 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayFor(model => model.TipoDeEmp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 90 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.NumeroSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 93 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayFor(model => model.NumeroSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 96 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.NumeroBancario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 99 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayFor(model => model.NumeroBancario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 102 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Ccss));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 105 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayFor(model => model.Ccss));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 108 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Profesion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 111 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayFor(model => model.Profesion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 114 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaContrato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 117 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayFor(model => model.FechaContrato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 120 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 123 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
           Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n    </dl>\r\n\r\n</div>\r\n\r\n<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c27dcf9cc7539b6662b3ec4372d063559484c7d17985", async() => {
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
#line 131 "C:\Users\Jose JFajardo\OneDrive\Escritorio\uLTIMA\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
                           WriteLiteral(Model.IdEmpleado);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c27dcf9cc7539b6662b3ec4372d063559484c7d20259", async() => {
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
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoFinal2020v2.Models.Empleado> Html { get; private set; }
    }
}
#pragma warning restore 1591
