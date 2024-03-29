#pragma checksum "D:\Projects\Chuvsu\Chuvsu_2Kurs_Database\WebApplicationDataBase\WebApplicationDataBase\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6ea65719b26a7ab00045fb3896b859211e91be8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Projects\Chuvsu\Chuvsu_2Kurs_Database\WebApplicationDataBase\WebApplicationDataBase\Views\_ViewImports.cshtml"
using WebApplicationDataBase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Chuvsu\Chuvsu_2Kurs_Database\WebApplicationDataBase\WebApplicationDataBase\Views\_ViewImports.cshtml"
using WebApplicationDataBase.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6ea65719b26a7ab00045fb3896b859211e91be8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05309d1b1323054bd32e1b3fe384cde3c3b96557", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#line 1 "D:\Projects\Chuvsu\Chuvsu_2Kurs_Database\WebApplicationDataBase\WebApplicationDataBase\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Добро пожаловать!</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6ea65719b26a7ab00045fb3896b859211e91be83656", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-10"">
                        <input type=""text"" class=""form-control"" aria-describedby=""emailHelp"" placeholder=""Введите ФИО клиента"">
                    </div>
                    <div class=""col-1 bt-search"">
                        <button type=""submit"" class=""btn btn-primary""><ion-icon name=""search-outline""></ion-icon></button>
                    </div>
                    <div class=""col-1 bt-update"">
                        <button type=""submit"" class=""btn btn-primary""><ion-icon name=""refresh-outline""></ion-icon></button>
                    </div>
                    <div class=""col-auto"">
                        <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#modalAddClient""><ion-icon name=""add-circle-outline""></ion-icon></button>
                    </div>
                </div>
                <div class=""row"">
 ");
                WriteLiteral("                   <div class=\"col-10\">\r\n                        <small id=\"information\" class=\"form-text text-muted\">Напишите ФИО для поиск по таблице</small>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <table class=""table table-striped"">
        <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Код клиента</th>
            <th scope=""col"">Фамилия</th>
            <th scope=""col"">Имя</th>
            <th scope=""col"">Отчество</th>
            <th scope=""col"">Номер телефона</th>
            <th scope=""col"">Адрес проживания</th>
            <th scope=""col"">Номер паспорта</th>
            <th scope=""col"">Серия паспорта</th>
            <th scope=""col"">Адрес регистрации</th>
            <th scope=""col"">ИНН</th>
            <th scope=""col"">Лицевой счет</th>
            <th scope=""col"">Навигация</th>
        </tr>
        </thead>
        <tbody>
            <tr>
              <th scope=""row"">1</th>
              <td>Mark</td>
              <td>Otto</td>
              <td>mdo</td>
              <td>mdo</td>
              <td>mdo</td>
              <td>mdo</td>
              <td>mdo</td>
              <td>mdo</td>
              <td>mdo</td>
    ");
            WriteLiteral(@"          <td>mdo</td>
              <td>mdo</td>
                <td>
                    <div class=""row"">
                        <div class=""col-1 bt-nav"">
                            <button type=""submit"" class=""btn btn-secondary btn-sm""><ion-icon name=""close-circle-outline""></ion-icon></button>
                        </div>
                        <div class=""col-1"">
");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
