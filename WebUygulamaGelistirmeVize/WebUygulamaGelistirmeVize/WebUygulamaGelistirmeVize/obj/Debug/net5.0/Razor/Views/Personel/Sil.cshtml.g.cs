#pragma checksum "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8548ed4b6a947d7e8e69f326466c110332f32382"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_Sil), @"mvc.1.0.view", @"/Views/Personel/Sil.cshtml")]
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
#line 1 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\_ViewImports.cshtml"
using WebUygulamaGelistirmeVize;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\_ViewImports.cshtml"
using WebUygulamaGelistirmeVize.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8548ed4b6a947d7e8e69f326466c110332f32382", @"/Views/Personel/Sil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd2d752a97723776494ae273b83f58135a0ca9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Personel_Sil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebUygulamaGelistirmeVize.Models.Personel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Listele", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
  
    ViewData["Title"] = "Sil";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Yukarıda sayfanin hangi model tipinde calisacagini belirtir-->
<!-- Personel classı içerisinde her bir eleman sayilabilir duruma gelir -->

<h4>Personeli Sil</h4> <!--Baslik Kismi-->


<div>
    <hr />
    <dl class=""row"">
        <dt class=""col-sm-2"">
            ");
#nullable restore
#line 18 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayNameFor(model => model.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayFor(model => model.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayNameFor(model => model.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayFor(model => model.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 36 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayNameFor(model => model.Dogum_Tarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayFor(model => model.Dogum_Tarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 42 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayNameFor(model => model.Kimlik_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 45 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayFor(model => model.Kimlik_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 48 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayNameFor(model => model.Departman_Tipi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 51 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayFor(model => model.Departman_Tipi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 54 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayNameFor(model => model.Giris_Yil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 57 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayFor(model => model.Giris_Yil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 60 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayNameFor(model => model.Sozlesme_Bitis_Tarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 63 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Personel\Sil.cshtml"
       Write(Html.DisplayFor(model => model.Sozlesme_Bitis_Tarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8548ed4b6a947d7e8e69f326466c110332f3238210219", async() => {
                WriteLiteral(" <!--method olarak Sil kullanilacak -->\r\n        <input type=\"submit\" value=\"Sil\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8548ed4b6a947d7e8e69f326466c110332f3238210603", async() => {
                    WriteLiteral("Listeye Geri Dön");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" <!--method olarak Listele kullanilacak -->\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebUygulamaGelistirmeVize.Models.Personel> Html { get; private set; }
    }
}
#pragma warning restore 1591
