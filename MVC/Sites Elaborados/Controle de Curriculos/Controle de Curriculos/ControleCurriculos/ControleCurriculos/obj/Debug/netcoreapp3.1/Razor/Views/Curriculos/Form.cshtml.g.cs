#pragma checksum "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f31401dcba24d313ec5222c9040c12b1e54c7a326170939b3eaeca3d6c9e40b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curriculos_Form), @"mvc.1.0.view", @"/Views/Curriculos/Form.cshtml")]
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
#line 1 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\_ViewImports.cshtml"
using ControleCurriculos

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\_ViewImports.cshtml"
using ControleCurriculos.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f31401dcba24d313ec5222c9040c12b1e54c7a326170939b3eaeca3d6c9e40b0", @"/Views/Curriculos/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e9a6c0840b8b25f559eed8721b9c862855d6e19bf1792aee7732ad5bc9dc6f0c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Curriculos_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CurriculosViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Salvar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("<h2>Cadastro de Currículos</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f31401dcba24d313ec5222c9040c12b1e54c7a326170939b3eaeca3d6c9e40b04567", async() => {
                WriteLiteral("\r\n    <label for=\"Id\" class=\"control-label\">Código De Cadastro</label>\r\n    <input type=\"number\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 257, "\"", 274, 1);
                WriteAttributeValue("", 265, 
#nullable restore
#line 8 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                           Model.Id

#line default
#line hidden
#nullable disable
                , 265, 9, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"Nome\" class=\"control-label\">Nome</label>\r\n    <input type=\"text\" name=\"Nome\"");
                BeginWriteAttribute("value", " value=\"", 386, "\"", 405, 1);
                WriteAttributeValue("", 394, 
#nullable restore
#line 12 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                           Model.Nome

#line default
#line hidden
#nullable disable
                , 394, 11, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"CPF\" class=\"control-label\">CPF</label>\r\n    <input type=\"text\" name=\"CPF\"");
                BeginWriteAttribute("value", " value=\"", 514, "\"", 532, 1);
                WriteAttributeValue("", 522, 
#nullable restore
#line 16 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                          Model.CPF

#line default
#line hidden
#nullable disable
                , 522, 10, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"Endereço\" class=\"control-label\">Endereço</label>\r\n    <input type=\"text\" name=\"Endereço\"");
                BeginWriteAttribute("value", " value=\"", 656, "\"", 679, 1);
                WriteAttributeValue("", 664, 
#nullable restore
#line 20 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                               Model.Endereço

#line default
#line hidden
#nullable disable
                , 664, 15, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"Telefone\" class=\"control-label\">Telefone</label>\r\n    <input type=\"text\" name=\"Telefone\"");
                BeginWriteAttribute("value", " value=\"", 803, "\"", 826, 1);
                WriteAttributeValue("", 811, 
#nullable restore
#line 24 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                               Model.Telefone

#line default
#line hidden
#nullable disable
                , 811, 15, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"Email\" class=\"control-label\">Email</label>\r\n    <input type=\"email\" name=\"Email\"");
                BeginWriteAttribute("value", " value=\"", 942, "\"", 962, 1);
                WriteAttributeValue("", 950, 
#nullable restore
#line 28 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                             Model.Email

#line default
#line hidden
#nullable disable
                , 950, 12, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"PretensaoSalarial\" class=\"control-label\">Pretensão Salarial</label>\r\n    <input type=\"text\" step=\"0.01\" name=\"PretensaoSalarial\"");
                BeginWriteAttribute("value", " value=\"", 1126, "\"", 1158, 1);
                WriteAttributeValue("", 1134, 
#nullable restore
#line 32 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                                                    Model.PretensaoSalarial

#line default
#line hidden
#nullable disable
                , 1134, 24, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"CargoPretendido\" class=\"control-label\">Cargo Pretendido</label>\r\n    <input type=\"text\" name=\"CargoPretendido\"");
                BeginWriteAttribute("value", " value=\"", 1304, "\"", 1334, 1);
                WriteAttributeValue("", 1312, 
#nullable restore
#line 36 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                                      Model.CargoPretendido

#line default
#line hidden
#nullable disable
                , 1312, 22, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"Curso1\" class=\"control-label\">Curso 1</label>\r\n    <input type=\"text\" name=\"Curso1\"");
                BeginWriteAttribute("value", " value=\"", 1453, "\"", 1474, 1);
                WriteAttributeValue("", 1461, 
#nullable restore
#line 40 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                             Model.Curso1

#line default
#line hidden
#nullable disable
                , 1461, 13, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"Curso2\" class=\"control-label\">Curso 2</label>\r\n    <input type=\"text\" name=\"Curso2\"");
                BeginWriteAttribute("value", " value=\"", 1593, "\"", 1614, 1);
                WriteAttributeValue("", 1601, 
#nullable restore
#line 44 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                             Model.Curso2

#line default
#line hidden
#nullable disable
                , 1601, 13, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"Curso3\" class=\"control-label\">Curso 3</label>\r\n    <input type=\"text\" name=\"Curso3\"");
                BeginWriteAttribute("value", " value=\"", 1733, "\"", 1754, 1);
                WriteAttributeValue("", 1741, 
#nullable restore
#line 48 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                             Model.Curso3

#line default
#line hidden
#nullable disable
                , 1741, 13, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"Curso4\" class=\"control-label\">Curso 4</label>\r\n    <input type=\"text\" name=\"Curso4\"");
                BeginWriteAttribute("value", " value=\"", 1873, "\"", 1894, 1);
                WriteAttributeValue("", 1881, 
#nullable restore
#line 52 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                             Model.Curso4

#line default
#line hidden
#nullable disable
                , 1881, 13, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"Curso5\" class=\"control-label\">Curso 5</label>\r\n    <input type=\"text\" name=\"Curso5\"");
                BeginWriteAttribute("value", " value=\"", 2013, "\"", 2034, 1);
                WriteAttributeValue("", 2021, 
#nullable restore
#line 56 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                             Model.Curso5

#line default
#line hidden
#nullable disable
                , 2021, 13, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"Experiencia1\" class=\"control-label\">Experiência 1</label>\r\n    <input type=\"text\" name=\"Experiencia1\"");
                BeginWriteAttribute("value", " value=\"", 2171, "\"", 2198, 1);
                WriteAttributeValue("", 2179, 
#nullable restore
#line 60 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                                   Model.Experiencia1

#line default
#line hidden
#nullable disable
                , 2179, 19, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"Experiencia2\" class=\"control-label\">Experiência 2</label>\r\n    <input type=\"text\" name=\"Experiencia2\"");
                BeginWriteAttribute("value", " value=\"", 2335, "\"", 2362, 1);
                WriteAttributeValue("", 2343, 
#nullable restore
#line 64 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                                   Model.Experiencia2

#line default
#line hidden
#nullable disable
                , 2343, 19, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"Experiencia3\" class=\"control-label\">Experiência 3</label>\r\n    <input type=\"text\" name=\"Experiencia3\"");
                BeginWriteAttribute("value", " value=\"", 2499, "\"", 2526, 1);
                WriteAttributeValue("", 2507, 
#nullable restore
#line 68 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                                   Model.Experiencia3

#line default
#line hidden
#nullable disable
                , 2507, 19, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"Idioma1\" class=\"control-label\">Idioma 1</label>\r\n    <input type=\"text\" name=\"Idioma1\"");
                BeginWriteAttribute("value", " value=\"", 2648, "\"", 2670, 1);
                WriteAttributeValue("", 2656, 
#nullable restore
#line 72 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                              Model.Idioma1

#line default
#line hidden
#nullable disable
                , 2656, 14, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"Idioma2\" class=\"control-label\">Idioma 2</label>\r\n    <input type=\"text\" name=\"Idioma2\"");
                BeginWriteAttribute("value", " value=\"", 2792, "\"", 2814, 1);
                WriteAttributeValue("", 2800, 
#nullable restore
#line 76 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                              Model.Idioma2

#line default
#line hidden
#nullable disable
                , 2800, 14, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label for=\"Idioma3\" class=\"control-label\">Idioma 3</label>\r\n    <input type=\"text\" name=\"Idioma3\"");
                BeginWriteAttribute("value", " value=\"", 2936, "\"", 2958, 1);
                WriteAttributeValue("", 2944, 
#nullable restore
#line 80 "C:\Users\Testwork\Desktop\Moodle\Controle de Curriculos\Controle de Curriculos\ControleCurriculos\ControleCurriculos\Views\Curriculos\Form.cshtml"
                                              Model.Idioma3

#line default
#line hidden
#nullable disable
                , 2944, 14, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <input type=\"submit\" value=\"Salvar dados\" />\r\n    <br />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CurriculosViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
