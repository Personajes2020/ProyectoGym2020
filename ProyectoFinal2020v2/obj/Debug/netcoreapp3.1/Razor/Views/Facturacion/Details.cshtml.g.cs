#pragma checksum "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fab3cf27ae8946949957f49bd6827b6dd444e42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Facturacion_Details), @"mvc.1.0.view", @"/Views/Facturacion/Details.cshtml")]
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
#line 1 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fab3cf27ae8946949957f49bd6827b6dd444e42", @"/Views/Facturacion/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91eb63b7429581f3b7b57ba3bcdbd293f2c271e", @"/Views/_ViewImports.cshtml")]
    public class Views_Facturacion_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoFinal2020v2.Models.Compra>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h3 class=""container p-3 my-3 bg-secondary text-white text-center rounded-l""><i class=""fas fa-align-justify ""></i> Detalle de Factura</h3>
<div class=""container"">

    <hr />

    <dl class=""row"">
        <div class=""column"">
            <dt class=""col-sm-4"">

            </dt>
            <dd class=""col-sm-8"">

            </dd>
            <dt class=""col-sm-4"">
                ");
#nullable restore
#line 22 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 25 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
           Write(Html.DisplayFor(model => model.IdCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                Identificación\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 31 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
           Write(Html.DisplayFor(model => model.IdClienteNavigation.Identificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                Cliente\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 37 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
           Write(Html.DisplayFor(model => model.IdClienteNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 37 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
                                                                       Write(Html.DisplayFor(model => model.IdClienteNavigation.Apellido1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 37 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
                                                                                                                                      Write(Html.DisplayFor(model => model.IdClienteNavigation.Apellido2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 40 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.IdEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 43 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
           Write(Html.DisplayFor(model => model.IdEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                Identificación\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 49 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
           Write(Html.DisplayFor(model => model.IdEmpleadoNavigation.Identificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                Empleado\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 55 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
           Write(Html.DisplayFor(model => model.IdEmpleadoNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 55 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
                                                                        Write(Html.DisplayFor(model => model.IdEmpleadoNavigation.Apellido1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 55 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
                                                                                                                                        Write(Html.DisplayFor(model => model.IdEmpleadoNavigation.Apellido2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n        </div>\r\n        <div class=\"column\">\r\n            <dt class=\"col-sm-3\"></dt>\r\n");
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 63 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-1\">\r\n                ");
#nullable restore
#line 66 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
           Write(Html.DisplayFor(model => model.IdCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-1\">\r\n                ");
#nullable restore
#line 69 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-3\">\r\n                ");
#nullable restore
#line 72 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
           Write(Html.DisplayFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </dd>
        </div>


    </dl>
</div>
<div class=""container"">
    <div class=""row"">
        <table class=""table"" id=""tableDetalle"">
            <thead>
                <tr>
                    <th>
                        Id Producto
                    </th>
                    <th>
                        Nombre
                    </th>
                    <th>
                        Cantidad
                    </th>
                    <th>
                        Precio Unidad
                    </th>
                    <th>
                        SubTotal
                    </th>
                    <th>

                    </th>
                </tr>

            </thead>
            <tbody>
");
#nullable restore
#line 106 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
                 foreach (DetalleCompra item in (List<DetalleCompra>)ViewData["Detalles"])
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 110 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 113 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdProductoNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 116 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"hidden\" id=\"cantidad\"");
            BeginWriteAttribute("value", " value=\"", 3953, "\"", 3975, 1);
#nullable restore
#line 117 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
WriteAttributeValue("", 3961, item.Cantidad, 3961, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 121 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PrecioUnidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"hidden\" id=\"precioUnidad\"");
            BeginWriteAttribute("value", " value=\"", 4186, "\"", 4212, 1);
#nullable restore
#line 122 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
WriteAttributeValue("", 4194, item.PrecioUnidad, 4194, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </td>
                        <td>
                            <h5><span id=""suma""></span> </h5>
                            <script>
                                $('#suma').text(parseInt($('#precioUnidad').val()) * parseInt($('#cantidad').val()));
                            </script>
                        </td>
                        <td>
                        </td>
                    </tr>
");
#nullable restore
#line 133 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n            <tfoot>\r\n                <tr>\r\n                    <td colspan=\"6\" class=\"text-center\">\r\n                        <h3>Total: ");
#nullable restore
#line 138 "C:\Users\reymo\Downloads\ProyectoGym2020\ProyectoFinal2020v2\Views\Facturacion\Details.cshtml"
                              Write(Html.DisplayFor(model => model.Importe));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fab3cf27ae8946949957f49bd6827b6dd444e4215579", async() => {
                WriteLiteral("Atras");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoFinal2020v2.Models.Compra> Html { get; private set; }
    }
}
#pragma warning restore 1591
