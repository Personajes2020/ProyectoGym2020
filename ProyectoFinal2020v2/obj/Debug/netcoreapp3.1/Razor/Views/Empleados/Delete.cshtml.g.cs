#pragma checksum "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fab88266929a1bfd5aea3cf24d2c69514f85ccaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_Delete), @"mvc.1.0.view", @"/Views/Empleados/Delete.cshtml")]
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
#line 1 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\_ViewImports.cshtml"
using ProyectoFinal2020v2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fab88266929a1bfd5aea3cf24d2c69514f85ccaa", @"/Views/Empleados/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91eb63b7429581f3b7b57ba3bcdbd293f2c271e", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoFinal2020v2.Models.Empleado>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Empleados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formulario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/lib/jquery/dist/jquery.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sweetalert2.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
   Layout = "~/Views/Shared/_AdminLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4 class=\"container p-3 my-3 bg-danger text-white text-center rounded-l\"><i class=\"fas fa-trash\"></i> Eliminar Empleado</h4>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Identificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Identificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellido1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Apellido1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellido2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Apellido2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaNac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechaNac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 55 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 61 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 64 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 67 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Area));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 70 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Area));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 73 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoDeEmp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 76 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TipoDeEmp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 79 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 82 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumeroSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 85 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroBancario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 88 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumeroBancario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 91 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ccss));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 94 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ccss));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 97 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Profesion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 100 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Profesion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 103 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaContrato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 106 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechaContrato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 109 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 112 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fab88266929a1bfd5aea3cf24d2c69514f85ccaa20983", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fab88266929a1bfd5aea3cf24d2c69514f85ccaa21250", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 117 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdEmpleado);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"button\" value=\"Eliminar\" class=\"btn btn-danger\" id=\"deleteAjax\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fab88266929a1bfd5aea3cf24d2c69514f85ccaa23137", async() => {
                    WriteLiteral("Atras");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fab88266929a1bfd5aea3cf24d2c69514f85ccaa26117", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 122 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fab88266929a1bfd5aea3cf24d2c69514f85ccaa28072", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
$(document).ready(function () {
    $(""#deleteAjax"").click(function (event) {
        var form = $(""#formulario"");
        Swal.fire({   //Al hacer click en el btn mande la alerta
            title: '¿Está seguro(a) de eliminar?',
            text: ""¡No podrá recuperar este empleado!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Sí, eliminar!'
        }).then((result) => {
            if (result.isConfirmed) {//Si confirmo eliminarla, que llame a traves de ajax el metodo eliminar

                $.ajax({//Llama al metodo eliminar con ajax
                    url: ""/Empleados/DeleteConAjax"",
                    data: form.serialize(),
                    method: ""POST"",
                });
                Swal.fire({    //Mande una alerta de que se eliminó
                    position: 'center',
                    icon: 'success',
           ");
            WriteLiteral("         title: \'Empleado eliminado correctamente.\',\r\n                    showConfirmButton: false,\r\n                    timer: 3000,\r\n                })\r\n                setTimeout(function () {\r\n                    window.location.href = \'");
#nullable restore
#line 152 "E:\Universidad Nacional\UNA 2020\Semestre II\Programacion III\Proyecto-Final-Cambios\ProyectoGym2020\ProyectoFinal2020v2\Views\Empleados\Delete.cshtml"
                                       Write(Url.Action("Index", "Empleados"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n                }, 2000);\r\n            }\r\n        })\r\n        });\r\n    });\r\n</script>");
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
