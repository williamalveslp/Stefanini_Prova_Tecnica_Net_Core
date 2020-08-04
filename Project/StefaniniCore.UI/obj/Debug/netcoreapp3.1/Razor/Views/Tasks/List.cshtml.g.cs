#pragma checksum "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ae3e528135bb0e688b8bd71515bd6596c873895"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_List), @"mvc.1.0.view", @"/Views/Tasks/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ae3e528135bb0e688b8bd71515bd6596c873895", @"/Views/Tasks/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6a395eadf5937604e79acec228111308e71ff4", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StefaniniCore.Application.ViewModels.TaskListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/my-scripts/tasks/list.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
  
    ViewData["Title"] = "Listagem de Funcionalidades";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ol class=\"breadcrumb linkMapPage\">\r\n    <li><a href=\"/\">Home /</a></li>\r\n    <li class=\"active\">Funcionalidades</li>\r\n</ol>\r\n\r\n<h2 class=\"title\">\r\n    <i class=\"glyphicon glyphicon-tag\"></i> Listagem de Funcionalidades\r\n\r\n");
#nullable restore
#line 15 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
     if (Model.Tasks != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <label style=\"font-weight:normal\">(");
#nullable restore
#line 17 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
                                      Write(Model.TotalRecords);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</label>\r\n");
#nullable restore
#line 18 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"buttonPageList\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 516, "\"", 553, 1);
#nullable restore
#line 22 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
WriteAttributeValue("", 523, Url.Action("Detail", "Tasks"), 523, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">\r\n        <span class=\"glyphicon glyphicon-plus\"></span>\r\n        Nova Funcionalidade\r\n    </a>\r\n</div>\r\n\r\n<div>\r\n");
#nullable restore
#line 29 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
     if (Model.Tasks == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <div class=\"alert alert-danger\" role=\"alert\">\r\n            Erro ao carregar os dados.\r\n        </div>\r\n");
#nullable restore
#line 35 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
    }
    else if (!Model.Tasks.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <div class=\"alert alert-warning\" role=\"alert\">\r\n            Não há dados cadastrados.\r\n        </div>\r\n");
#nullable restore
#line 42 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-hover tableList"" id=""tableTask"">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Nome da Funcionalidade</th>
                    <th>Ação</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 54 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
                 foreach (var item in Model.Tasks)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 57 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 58 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1612, "\"", 1674, 1);
#nullable restore
#line 60 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
WriteAttributeValue("", 1619, Url.Action("Detail","Tasks", new { taskId = item.Id }), 1619, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar <span class=\"glyphicon glyphicon-pencil\"></span></a>\r\n                            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1776, "\"", 1822, 3);
            WriteAttributeValue("", 1786, "showModalToConfirmDelete(\'", 1786, 26, true);
#nullable restore
#line 61 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
WriteAttributeValue("", 1812, item.Id, 1812, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1820, "\')", 1820, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Excluir <span class=\"glyphicon glyphicon-trash\"></span></a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 64 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 67 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<div class=""modal fade"" id=""modalConfirmDelete"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                Exclusão
            </div>
            <div class=""modal-body"">
                Tem certeza que deseja excluir este item?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Cancelar</button>
                <a id=""btnConfirmDelete"" entityid onclick=""deleteTask(this)"" class=""btn btn-danger btn-ok textColorDeleteButton"">Sim</a>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        var URL_DELETE_TASK = \'");
#nullable restore
#line 89 "C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\StefaniniCore.UI\Views\Tasks\List.cshtml"
                          Write(Url.Action("Remove", "Tasks"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n    </script>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ae3e528135bb0e688b8bd71515bd6596c87389510660", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StefaniniCore.Application.ViewModels.TaskListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
