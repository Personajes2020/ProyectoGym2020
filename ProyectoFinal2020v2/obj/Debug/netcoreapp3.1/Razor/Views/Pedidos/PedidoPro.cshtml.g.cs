#pragma checksum "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\PedidoPro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a14068d556dc3f4144d876743e13c11986e317a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_PedidoPro), @"mvc.1.0.view", @"/Views/Pedidos/PedidoPro.cshtml")]
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
#line 1 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a14068d556dc3f4144d876743e13c11986e317a7", @"/Views/Pedidos/PedidoPro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91eb63b7429581f3b7b57ba3bcdbd293f2c271e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_PedidoPro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoFinal2020v2.Models.Pedido>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fechaCompra"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:325px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fechaEntrega"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Pedidos/Guardar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\PedidoPro.cshtml"
   Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">

<h1 class=""container p-3 my-3 text-white text-center rounded-l"" style=""background:#217e7e""><i class=""fas fa-box-open""></i>Pedidos</h1>

<div class=""container"">
    <div class=""card col-span-12"">
        <div class=""card-body"">
            <div class=""column"">
                <div class=""col-3"">
                    <div class=""form-group"">
                        <label>Producto</label>
                        <div class=""input-group"">
                            <input type=""number"" class=""form-control"" id=""IdProducto"" name=""IdProducto"" readonly style=""width:225px"" />
                            <div class=""input-group-btn"">
                                <button type=""button"" class="" btn btn-info"" style=""height:34px; color:#ffffff;"" data-toggle=""modal"" data-target=""#modalPedido"">Seleccionar</button>
                            </div>
                        </div>
                      ");
            WriteLiteral(@"  <div class=""from-group"">
                            <label>Precio</label>
                            <input type=""number"" class=""form-control"" id=""precio"" name=""PrecioUnidad"" readonly style=""width:325px"" />
                        </div>
                        <div class=""from-group"">
                            <label>Proveedor</label>
                            <input type=""text"" class=""form-control"" id=""proveedor"" name=""IdProveedor"" readonly style=""width:325px"" />
                        </div>
                        <div class=""from-group"">
                            <label>Categoria</label>
                            <input type=""text"" class=""form-control"" id=""categoria"" name=""IdCategoria"" readonly style=""width:325px"" />
                        </div>
                        <br />
                        <button onclick=""agregarFila()"" class=""btn btn-success btn-block"" type=""button"" style=""width:325px"">Agregar</button>
                    </div>
                </div>
          ");
            WriteLiteral("  </div>\r\n            <div class=\"column\">\r\n                <div class=\"col-3\">\r\n                    <div class=\"from-group\">\r\n                        <label>F.Compra </label>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a14068d556dc3f4144d876743e13c11986e317a78528", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 43 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\PedidoPro.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FechaCompra);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\PedidoPro.cshtml"
                                                                                                                               WriteLiteral(DateTime.Now);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"from-group\">\r\n                        <label>F.Entrega</label>\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a14068d556dc3f4144d876743e13c11986e317a711750", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 48 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\PedidoPro.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FechaLlegada);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""from-group"">
                        <label>F.Caducidad</label>
                        <input type=""date"" id=""fechaCaducidad"" name=""FechaCaducidad"" class=""form-control"" style=""width:325px"" />
                    </div>
                    <div class=""from-group"">
                        <label>Cantidad</label>
                        <input type=""number"" class=""form-control"" id=""cantidad"" name=""UnidadesSolicitadas"" style=""width:325px"" />
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-12"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a14068d556dc3f4144d876743e13c11986e317a714138", async() => {
                WriteLiteral(@"
                <table id=""tablaPedido"" class=""table table-bordered"">
                    <thead>
                        <tr>
                            <td>Producto</td>
                            <td>Precio</td>
                            <td>Proveedor</td>
                            <td>Categoria</td>
                            <td>F.Compra</td>
                            <td>F.Entrega</td>
                            <td>F.Caducidad</td>
                            <td>Cantidad</td>
                            <td>Subtotal</td>
                        </tr>
                    </thead>
                    <tbody>
                    </tbody>
                    <tfoot>
                        <tr>
                            <td colspan=""3"" class=""text-center"">
                                <h3>Total:<span id=""total"">0.0</span> </h3>
                                <input type=""hidden"" name=""Total"" id=""Total"" />
                            </td>
                        </t");
                WriteLiteral("r>\r\n                    </tfoot>\r\n                </table>\r\n                <button type=\"submit\" class=\"btn btn-success btn-block\">Guardar</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <div class=""modal fade"" id=""modalPedido"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title container p-3 my-3 text-white text-center rounded-l"" id=""exampleModalLabel"" style=""background:#DF3A01""><i class=""fas fa-gifts"">Productos</i></h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">

                    <table id=""tableProductos"" class=""display"" style=""width:100%"">
                        <thead>
                            <tr>
                                <th>
                                    #Producto
                                </th>
                     ");
            WriteLiteral(@"           <th>
                                    Precio
                                </th>
                                <th>
                                    Proveedor
                                </th>
                                <th>
                                    Categoria
                                </th>
                                <th>


                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 125 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\PedidoPro.cshtml"
                             foreach (Producto item in (List<Producto>)TempData["Produc"])
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 129 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\PedidoPro.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.IdProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 132 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\PedidoPro.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.PrecioUnidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 135 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\PedidoPro.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.IdProveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 138 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\PedidoPro.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.IdCategoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 7261, "\"", 7351, 9);
            WriteAttributeValue("", 7271, "recibir(", 7271, 8, true);
#nullable restore
#line 141 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\PedidoPro.cshtml"
WriteAttributeValue("", 7279, item.IdProducto, 7279, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7295, ",", 7295, 1, true);
#nullable restore
#line 141 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\PedidoPro.cshtml"
WriteAttributeValue("", 7296, item.PrecioUnidad, 7296, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7314, ",", 7314, 1, true);
#nullable restore
#line 141 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\PedidoPro.cshtml"
WriteAttributeValue("", 7315, item.IdProveedor, 7315, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7332, ",", 7332, 1, true);
#nullable restore
#line 141 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\PedidoPro.cshtml"
WriteAttributeValue("", 7333, item.IdCategoria, 7333, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7350, ")", 7350, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Seleccionar</a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 144 "C:\Users\Jose JFajardo\OneDrive\Escritorio\AAAAAAA\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\PedidoPro.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>

            </div>
        </div>
    </div>
</div>
<script>
    $(document).ready(function () {
        $('#tableProductos').DataTable({
            ""language"": {
                ""url"": ""//cdn.datatables.net/plug-ins/1.10.15/i18n/Spanish.json""
            }
        });
    });
</script>
<script>
    function recibir(a, b, c, d) {
        var valor = a;
        document.getElementById(""IdProducto"").value = valor;
        var valor2 = b;
        document.getElementById(""precio"").value = valor2;
        var valor3 = c;
        document.getElementById(""proveedor"").value = valor3;
        var valor4 = d;
        document.getElementById(""categoria"").value = valor4;

    }

</script>
<script>
    var cont = 0;
    function agregarFila() {
        let _prod = $(""#IdProducto"");
        let _a = $(""#precio"");
        let _b = $(""#proveedor"");
        let _c = $(""#categoria"");
        let _d = $(""");
            WriteLiteral(@"#fechaCompra"");
        let _e = $(""#fechaEntrega"");
        let _f = $(""#fechaCaducidad"");
        let _g = $(""#cantidad"");
        let total = $(""#Total"").val() || 0;
        $(""#tablaPedido"").append(`
         <tr>
            <td>
                <input type=""hidden"" name=""detalles[${cont}].IdProducto"" value=""${_prod.val()}"" />
                ${_prod.val()}
            </td>
            <td>
                <input type=""hidden"" name=""detalles[${cont}].PrecioUnidad"" value=""${_a.val()}"" />
                ${_a.val()}
            </td>
            <td>
                <input type=""hidden"" name=""detalles[${cont}].IdProveedor"" value=""${_b.val()}"" />
                ${_b.val()}
            </td>
            <td>
                <input type=""hidden"" name=""detalles[${cont}].IdCategoria"" value=""${_c.val()}"" />
                ${_c.val()}
            </td>
            <td>
                <input type=""hidden"" name=""FechaCompra"" value=""${_d.val()}"" />
                ${_d.val()}
          ");
            WriteLiteral(@"  </td>
            <td>
                <input type=""hidden"" name=""FechaLLegada"" value=""${_e.val()}"" />
                ${_e.val()}
            </td>
            <td>
                <input type=""hidden"" name=""detalles[${cont}].FechaCaducidad"" value=""${_f.val()}"" />
                ${_f.val()}
            </td>
            <td>
                <input type=""hidden"" name=""detalles[${cont}].UnidadesSolicitadas"" value=""${_g.val()}"" />
                ${_g.val()}
            </td>
            <td>

                ${_g.val() * _a.val()}
            </td>
         </tr>
        `);

        let suma = parseInt(total) + parseInt(_g.val() * _a.val());
        $(""#total"").text(suma);
        $(""#Total"").val(suma);
        cont++;
    }
</script>   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoFinal2020v2.Models.Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
