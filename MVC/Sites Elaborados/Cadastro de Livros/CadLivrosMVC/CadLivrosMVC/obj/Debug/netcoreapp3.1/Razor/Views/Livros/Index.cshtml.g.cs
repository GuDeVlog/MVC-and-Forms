#pragma checksum "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\Livros\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b50c70f6db677f5c358e86f88db71c6a470faee930414ef6395affd96b4aee9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livros_Index), @"mvc.1.0.view", @"/Views/Livros/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\_ViewImports.cshtml"
using CadLivrosMVC

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\_ViewImports.cshtml"
using CadLivrosMVC.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b50c70f6db677f5c358e86f88db71c6a470faee930414ef6395affd96b4aee9f", @"/Views/Livros/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e1dd75e10e87d85c5b1494fb9fb4926437252ed4ee81ef839e8969cb30a8709f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Livros_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LivrosViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\Livros\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"<h2>Listagem de Livros</h2>

<a href=""/livros/create"" class=""btn btn-info"">Novo Registro</a>
<br />

<table class=""table table-responsive table-striped"">
    <tr>
        <th>Ações</th>
        <th>ID</th>
        <th>Titulo</th>
        <th>Autor1</th>
        <th>Autor2</th>
        <th>Editora</th>
        <th>Ano</th>
        <th>Editora</th>
        <th>Preço Sugerido</th>
    </tr>
");
#nullable restore
#line 22 "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\Livros\Index.cshtml"
     foreach (var livro in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 584, "\"", 616, 2);
            WriteAttributeValue("", 591, "/livros/edit?id=", 591, 16, true);
            WriteAttributeValue("", 607, 
#nullable restore
#line 26 "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\Livros\Index.cshtml"
                                          livro.Id

#line default
#line hidden
#nullable disable
            , 607, 9, false);
            EndWriteAttribute();
            WriteLiteral(" title=\"Editar\" >\r\n                    <img src=\"/assets/Edit.png\" alt=\"Editar\" style=\"width:30px !important; height:30px !important;\" />\r\n                </a>\r\n                &nbsp;&nbsp;\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 826, "\"", 860, 2);
            WriteAttributeValue("", 833, "/livros/delete?id=", 833, 18, true);
            WriteAttributeValue("", 851, 
#nullable restore
#line 30 "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\Livros\Index.cshtml"
                                            livro.Id

#line default
#line hidden
#nullable disable
            , 851, 9, false);
            EndWriteAttribute();
            WriteLiteral(" title=\"Delete\">\r\n                    <img src=\"/assets/Delete.png\" alt=\"Delete\" style=\"width:30px !important; height:30px !important;\" />\r\n                </a>\r\n            </td>\r\n            <td>");
            Write(
#nullable restore
#line 34 "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\Livros\Index.cshtml"
                 livro.Id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 35 "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\Livros\Index.cshtml"
                 livro.Titulo

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 36 "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\Livros\Index.cshtml"
                 livro.Autor1

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 37 "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\Livros\Index.cshtml"
                 livro.Autor2

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 38 "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\Livros\Index.cshtml"
                 livro.Editora

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 39 "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\Livros\Index.cshtml"
                 livro.Ano

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 40 "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\Livros\Index.cshtml"
                 livro.Edicao

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 41 "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\Livros\Index.cshtml"
                 livro.PrecoSugerido.ToString("0.00")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Testwork\Desktop\Moodle\Cadastro de Livros\CadLivrosMVC\CadLivrosMVC\Views\Livros\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LivrosViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
