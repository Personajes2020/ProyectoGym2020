#pragma checksum "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19c15b20d2c5eaec3caf82595b0029c4b7fd9db0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_Index), @"mvc.1.0.view", @"/Views/Pedidos/Index.cshtml")]
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
#line 1 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19c15b20d2c5eaec3caf82595b0029c4b7fd9db0", @"/Views/Pedidos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91eb63b7429581f3b7b57ba3bcdbd293f2c271e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoFinal2020v2.Models.Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cancelar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Recibir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detalles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/tablas.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
   Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""container p-3 my-3 text-white text-center rounded-l"" style=""background:#217e7e""><i class=""fas fa-box-open""></i>Pedidos</h1>


<table class=""table table-striped table-bordered"" id=""table"" cellspacing=""0"" style=""width:100%"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 14 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaLlegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Importe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Acciones\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechaCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechaLlegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Importe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n\r\n");
#nullable restore
#line 54 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
                       if (item.Estado.Equals("Cancelado"))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
                       Write(Html.Raw("Se ha cancelado"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
                                                        
                        }
                        else if (item.Estado.Equals("Recibido"))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
                       Write(Html.Raw("Se ha recibido"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
                                                       
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19c15b20d2c5eaec3caf82595b0029c4b7fd9db012720", async() => {
                WriteLiteral("<i class=\"fas fa-ban\"></i> Cancelar");
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
#line 64 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
                                                       WriteLiteral(item.IdPedido);

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
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19c15b20d2c5eaec3caf82595b0029c4b7fd9db015079", async() => {
                WriteLiteral("<i class=\"fas fa-check\"></i> Recibido");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
                                                      WriteLiteral(item.IdPedido);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"


                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                   \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19c15b20d2c5eaec3caf82595b0029c4b7fd9db017744", async() => {
                WriteLiteral("<i class=\"fas fa-align-justify\"></i> Ver detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
                                               WriteLiteral(item.IdPedido);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 74 "C:\Users\Jose JFajardo\OneDrive\Escritorio\Pasar lo de Pedido\ProyectoGym2020\ProyectoFinal2020v2\Views\Pedidos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19c15b20d2c5eaec3caf82595b0029c4b7fd9db020403", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#table').DataTable({
                ""language"": {
                    ""url"": ""//cdn.datatables.net/plug-ins/1.10.15/i18n/Spanish.json""
                },
                responsive: ""true"",
                dom: 'Bfrtilp',

                buttons: [

                    {

                        extend: 'excelHtml5',
                        text: '<i class=""fas fa-file-excel""></i> ',
                        titleAttr: 'Exportar a Excel',
                        className: 'btn btn-success',

                    },
                    {
                        extend: 'pdfHtml5',
                        text: '<i class=""fas fa-file-pdf""></i> ',
                        titleAttr: 'Exportar a PDF',
                        className: 'btn btn-danger'
                    },
                    {

                        extend: 'print',
                        text: '<i class=""fa fa-print""></i> ',
                 ");
                WriteLiteral("       titleAttr: \'Imprimir\',\r\n                        className: \'btn btn-info\'\r\n\r\n                    },\r\n\r\n                ]\r\n\r\n\r\n\r\n            });\r\n        });\r\n    </script>\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoFinal2020v2.Models.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
