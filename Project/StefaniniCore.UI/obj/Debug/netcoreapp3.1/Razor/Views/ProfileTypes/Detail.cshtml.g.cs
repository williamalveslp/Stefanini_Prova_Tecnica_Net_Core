#pragma checksum "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e85152438ea1a3e7ee96cb4c6d66132a3a046eb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProfileTypes_Detail), @"mvc.1.0.view", @"/Views/ProfileTypes/Detail.cshtml")]
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
#line 1 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\_ViewImports.cshtml"
using StefaniniCore.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\_ViewImports.cshtml"
using StefaniniCore.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e85152438ea1a3e7ee96cb4c6d66132a3a046eb1", @"/Views/ProfileTypes/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6a395eadf5937604e79acec228111308e71ff4", @"/Views/_ViewImports.cshtml")]
    public class Views_ProfileTypes_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StefaniniCore.Application.ViewModels.ProfileTypeDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formProfileType"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/my-scripts/profile-types/detail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
  
    ViewData["Title"] = "Cadastro de Perfis";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<ol class=\"breadcrumb\">\r\n    <li><a href=\"/\">Home</a> /</li>\r\n    <li>");
#nullable restore
#line 9 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
   Write(Html.ActionLink("Perfis", "List", "ProfileTypes"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" /</li>\r\n    <li class=\"active\">Cadastro</li>\r\n</ol>\r\n\r\n<div>\r\n    <h2>Cadastro de Perfis</h2>\r\n    <label class=\"requiredFields\">*</label> Campos obrigatórios.\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e85152438ea1a3e7ee96cb4c6d66132a3a046eb15094", async() => {
                WriteLiteral("\r\n        ");
#nullable restore
#line 20 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
   Write(Html.HiddenFor(f => f.Id, new { @id = "hddProfileTypeId", @name = "hddProfileTypeId" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <div class=\"form-group\">\r\n                    <label>Nome do Perfil<i class=\"requiredField\">*</i>:</label>\r\n                    ");
#nullable restore
#line 25 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
               Write(Html.TextBoxFor(f => f.Name, new { @id = "txtName", @name = "txtName", @class = "form-control", @type = "text", @maxlength = "30" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <br />
                </div>
            </div>

            <div class=""col-md-6"">

            </div>
        </div>


        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""form-group"">
                    <h3>Listagem das Funcionalidades Disponíveis</h3>
                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Nome</th>
                                <th>Ação</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 49 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
                             foreach (var item in Model.Tasks)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 52 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 53 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>\r\n                                        <button");
                BeginWriteAttribute("onclick", " onclick=\"", 1930, "\"", 1971, 6);
                WriteAttributeValue("", 1940, "addTask(", 1940, 8, true);
#nullable restore
#line 55 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
WriteAttributeValue("", 1948, item.Id, 1948, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1956, ",", 1956, 1, true);
                WriteAttributeValue(" ", 1957, "\'", 1958, 2, true);
#nullable restore
#line 55 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
WriteAttributeValue("", 1959, item.Name, 1959, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1969, "\')", 1969, 2, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"button\" class=\"btn btn-primary\">Adicionar</button>\r\n                                        <button");
                BeginWriteAttribute("onclick", " onclick=\"", 2078, "\"", 2122, 6);
                WriteAttributeValue("", 2088, "removeTask(", 2088, 11, true);
#nullable restore
#line 56 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
WriteAttributeValue("", 2099, item.Id, 2099, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2107, ",", 2107, 1, true);
                WriteAttributeValue(" ", 2108, "\'", 2109, 2, true);
#nullable restore
#line 56 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
WriteAttributeValue("", 2110, item.Name, 2110, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2120, "\')", 2120, 2, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"button\" class=\"btn btn-danger\">Remover</button>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 59 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </tbody>
                    </table>
                    <br />
                    <br />
                </div>
            </div>

            <div class=""col-md-6"">
                <div class=""form-group"">
                    <h3>Funcionalidades associadas ao seu Perfil</h3>

                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Nome</th>
                            </tr>
                        </thead>
                        <tbody id=""tBodyIdNewRows"">

");
#nullable restore
#line 80 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
                             if (Model.TasksByProfileType.Any())
                            {
                                foreach (var item in Model.TasksByProfileType)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr");
                BeginWriteAttribute("id", " id=\"", 3201, "\"", 3222, 2);
                WriteAttributeValue("", 3206, "taskRow_", 3206, 8, true);
#nullable restore
#line 84 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
WriteAttributeValue("", 3214, item.Id, 3214, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <td>");
#nullable restore
#line 85 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 86 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 88 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </tbody>
                    </table>

                    <div id=""divTasks"" name=""divTasks"">

                    </div>

                </div>
            </div>

        </div>


        <div class=""row"">
            <div class=""text-center"">
                <button type=""button"" id=""btnSave"" name=""btnSave"" class=""btn btn-primary"">Salvar</button>
                <button type=""button"" id=""btnClear"" name=""btnClear"" class=""btn btn-default"">Limpar</button>
                <a");
                BeginWriteAttribute("href", " href=\"", 3978, "\"", 4020, 1);
#nullable restore
#line 108 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
WriteAttributeValue("", 3985, Url.Action("List", "ProfileTypes"), 3985, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\" btn btn-default\">Voltar</a>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        var URL_SAVE_PROFILE_TYPE = \'");
#nullable restore
#line 116 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
                                Write(Url.Action("Save", "ProfileTypes"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n        var TASKS_ARRAY = ");
#nullable restore
#line 117 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\ProfileTypes\Detail.cshtml"
                      Write(Json.Serialize(Model.TasksByProfileType));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    </script>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e85152438ea1a3e7ee96cb4c6d66132a3a046eb115979", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StefaniniCore.Application.ViewModels.ProfileTypeDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
