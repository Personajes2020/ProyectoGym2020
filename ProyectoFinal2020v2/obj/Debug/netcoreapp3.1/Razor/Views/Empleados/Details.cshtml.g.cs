#pragma checksum "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2be34ae36ddbc571f86aa15a09b27f537f771f4a"
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
#line 1 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be34ae36ddbc571f86aa15a09b27f537f771f4a", @"/Views/Empleados/Details.cshtml")]
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
#line 2 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
   Layout = "~/Views/Shared/_AdminLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h4 class=""container p-3 my-3 bg-secondary text-white text-center rounded-l""><i class=""fas fa-align-justify ""></i> Detalle Empleado</h4>

<div>

    <hr />
    <div class=""container"">
        <div class=""row"">
            <dl class=""col"">
                <dt class=""col-sm-2"">
                    ");
#nullable restore
#line 15 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Identificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.Identificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 24 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Apellido1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.Apellido1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Apellido2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.Apellido2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 39 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.FechaNac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 42 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.FechaNac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 45 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 48 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 51 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 54 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 57 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 60 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 63 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 66 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n            <dl class=\"col\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 71 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Area));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 74 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.Area));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 77 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.TipoDeEmp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 80 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.TipoDeEmp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 83 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.NumeroSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 86 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.NumeroSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 89 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.NumeroBancario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 92 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.NumeroBancario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 95 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Ccss));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 98 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.Ccss));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 101 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Profesion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 104 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.Profesion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 107 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.FechaContrato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 110 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.FechaContrato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 113 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 116 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
               Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2be34ae36ddbc571f86aa15a09b27f537f771f4a18070", async() => {
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
#line 125 "C:\Users\elder\Desktop\ProyectoGym\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Details.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2be34ae36ddbc571f86aa15a09b27f537f771f4a20329", async() => {
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
            WriteLiteral("\r\n</div>\r\n");
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
