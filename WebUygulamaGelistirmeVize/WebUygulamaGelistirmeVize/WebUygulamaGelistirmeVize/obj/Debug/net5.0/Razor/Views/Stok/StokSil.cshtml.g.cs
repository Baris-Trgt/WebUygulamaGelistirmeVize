#pragma checksum "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\StokSil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "905e7fcf00c178c80915f2a72db52fc5a4caf133"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stok_StokSil), @"mvc.1.0.view", @"/Views/Stok/StokSil.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905e7fcf00c178c80915f2a72db52fc5a4caf133", @"/Views/Stok/StokSil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd2d752a97723776494ae273b83f58135a0ca9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Stok_StokSil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebUygulamaGelistirmeVize.Models.Stok>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Durum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StokSil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\StokSil.cshtml"
  
    ViewData["Title"] = "StokSil";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Yukar??da sayfanin hangi model tipinde calisacagini belirtir-->
<!-- Stok class?? i??erisinde her bir eleman sayilabilir duruma gelir -->

<h4>Stok Silme</h4> <!--Baslik Kismi-->

<div>
    <hr />
    <dl class=""row"">
        <dt class=""col-sm-2"">
            ");
#nullable restore
#line 17 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\StokSil.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\StokSil.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\StokSil.cshtml"
       Write(Html.DisplayNameFor(model => model.Urun_Adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\StokSil.cshtml"
       Write(Html.DisplayFor(model => model.Urun_Adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\StokSil.cshtml"
       Write(Html.DisplayNameFor(model => model.Urun_Fiyat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\StokSil.cshtml"
       Write(Html.DisplayFor(model => model.Urun_Fiyat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\StokSil.cshtml"
       Write(Html.DisplayNameFor(model => model.Marka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\StokSil.cshtml"
       Write(Html.DisplayFor(model => model.Marka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\StokSil.cshtml"
       Write(Html.DisplayNameFor(model => model.Stok_Durumu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\StokSil.cshtml"
       Write(Html.DisplayFor(model => model.Stok_Durumu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "905e7fcf00c178c80915f2a72db52fc5a4caf1338109", async() => {
                WriteLiteral(" <!--method olarak StokSil kullanilacak -->\r\n        <input type=\"submit\" value=\"Sil\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "905e7fcf00c178c80915f2a72db52fc5a4caf1338496", async() => {
                    WriteLiteral("Stok Listesine Geri D??n");
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
                WriteLiteral(" <!--method olarak Durum kullanilacak -->\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebUygulamaGelistirmeVize.Models.Stok> Html { get; private set; }
    }
}
#pragma warning restore 1591
