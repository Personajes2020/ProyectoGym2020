#pragma checksum "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35d83bc03dd745b00478ecef833749e345d211c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DetallesPedidos_Index), @"mvc.1.0.view", @"/Views/DetallesPedidos/Index.cshtml")]
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
#line 1 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d83bc03dd745b00478ecef833749e345d211c4", @"/Views/DetallesPedidos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91eb63b7429581f3b7b57ba3bcdbd293f2c271e", @"/Views/_ViewImports.cshtml")]
    public class Views_DetallesPedidos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoFinal2020v2.Models.DetallesPedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedidos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/tablas.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
   Layout = "~/Views/Shared/_AdminLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">

<h1 class=""container p-3 my-3 text-white text-center rounded-l"" style=""background:#217e7e""><i class=""fas fa-scroll""></i>Detalles de Pedidos</h1>



<div class=""container"">

    <table id=""table"" class=""table table-striped table-bordered"" cellspacing=""0"" style=""width:100%"">
        <thead>
            <tr>
                <th>
                    ");
#nullable restore
#line 19 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PrecioUnidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.UnidadesSolicitadas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FechaCaducidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 28 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.IdCategoriaNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 31 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.IdPedidoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.IdProductoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.IdProveedorNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PrecioUnidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UnidadesSolicitadas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FechaCaducidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IdCategoriaNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IdPedidoNavigation.IdPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IdProductoNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IdProveedorNavigation.NombreRepresentante));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 67 "C:\Users\reymo\Downloads\Parte-Elder\ProyectoGym2020\ProyectoFinal2020v2\Views\DetallesPedidos\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35d83bc03dd745b00478ecef833749e345d211c412013", async() => {
                WriteLiteral("\r\n        Volver a pedidos\r\n        <i class=\"fas fa-undo\"></i>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "35d83bc03dd745b00478ecef833749e345d211c413539", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
                        onclick: 'columna',
                        extend: 'print',
                        text: '<i class");
                WriteLiteral("=\"fa fa-print\"></i> \',\r\n                        titleAttr: \'Imprimir\',\r\n                        className: \'btn btn-info\'\r\n\r\n                    },\r\n\r\n                ]\r\n\r\n\r\n\r\n            });\r\n        });\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoFinal2020v2.Models.DetallesPedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
