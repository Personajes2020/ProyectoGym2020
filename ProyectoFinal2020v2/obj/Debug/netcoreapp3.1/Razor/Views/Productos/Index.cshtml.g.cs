#pragma checksum "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59a69e5e90687a6dfc2c3b4f109cd2d1deb760fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Index), @"mvc.1.0.view", @"/Views/Productos/Index.cshtml")]
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
#line 1 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59a69e5e90687a6dfc2c3b4f109cd2d1deb760fc", @"/Views/Productos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91eb63b7429581f3b7b57ba3bcdbd293f2c271e", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoFinal2020v2.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
   Layout = "~/Views/Shared/_AdminLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4 class=\"container p-3 my-3 bg-danger text-white text-center rounded-l\"><i class=\"fas fa-trash\"></i>Productos</h4>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Existencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaCadu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrecioUnidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCategoriaNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdProveedorNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59a69e5e90687a6dfc2c3b4f109cd2d1deb760fc9424", async() => {
                WriteLiteral("\r\n                    Crear Nuevo\r\n                    <i class=\"fas fa-plus-square\"></i>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 42 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"edit\"");
            BeginWriteAttribute("id", " id=\"", 1411, "\"", 1433, 2);
#nullable restore
#line 45 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
WriteAttributeValue("", 1416, item.IdProducto, 1416, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1432, "", 1433, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-propertyName=\"Nombre\">\r\n                    ");
#nullable restore
#line 46 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"edit\"");
            BeginWriteAttribute("id", " id=\"", 1583, "\"", 1605, 2);
#nullable restore
#line 48 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
WriteAttributeValue("", 1588, item.IdProducto, 1588, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1604, "", 1605, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-propertyName=\"Descripcion\">\r\n                    ");
#nullable restore
#line 49 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"edit\"");
            BeginWriteAttribute("id", " id=\"", 1765, "\"", 1787, 2);
#nullable restore
#line 51 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
WriteAttributeValue("", 1770, item.IdProducto, 1770, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1786, "", 1787, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-propertyName=\"Existencia\">\r\n                    ");
#nullable restore
#line 52 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Existencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"edit\"");
            BeginWriteAttribute("id", " id=\"", 1945, "\"", 1967, 2);
#nullable restore
#line 54 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
WriteAttributeValue("", 1950, item.IdProducto, 1950, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1966, "", 1967, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-propertyName=\"FechaCadu\">\r\n                    ");
#nullable restore
#line 55 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechaCadu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"edit\"");
            BeginWriteAttribute("id", " id=\"", 2123, "\"", 2145, 2);
#nullable restore
#line 57 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
WriteAttributeValue("", 2128, item.IdProducto, 2128, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2144, "", 2145, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-propertyName=\"PrecioUnidad\">\r\n                    ");
#nullable restore
#line 58 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PrecioUnidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"edit\"");
            BeginWriteAttribute("id", " id=\"", 2307, "\"", 2329, 2);
#nullable restore
#line 60 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
WriteAttributeValue("", 2312, item.IdProducto, 2312, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2328, "", 2329, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-propertyName=\"Nombre\">\r\n                    ");
#nullable restore
#line 61 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdCategoriaNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"edit\"");
            BeginWriteAttribute("id", " id=\"", 2501, "\"", 2523, 2);
#nullable restore
#line 63 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
WriteAttributeValue("", 2506, item.IdProducto, 2506, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2522, "", 2523, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-propertyName=\"NombreProducto\">\r\n                    ");
#nullable restore
#line 64 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdProveedorNavigation.NombreProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <div class=\"btn-group\" style=\'font-size: 5px\'>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59a69e5e90687a6dfc2c3b4f109cd2d1deb760fc17833", async() => {
                WriteLiteral("Editar<i class=\"fas fa-pen\"></i>");
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
#line 68 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
                                               WriteLiteral(item.IdProducto);

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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59a69e5e90687a6dfc2c3b4f109cd2d1deb760fc20194", async() => {
                WriteLiteral("Detalle<i class=\"fas fa-align-justify \"></i>");
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
#line 69 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
                                                  WriteLiteral(item.IdProducto);

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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59a69e5e90687a6dfc2c3b4f109cd2d1deb760fc22570", async() => {
                WriteLiteral("Eliminar<i class=\"fas fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
                                                 WriteLiteral(item.IdProducto);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 74 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\VersionFinal\ProyectoGym2020\ProyectoFinal2020v2\Views\Productos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#table\').DataTable();\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoFinal2020v2.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
