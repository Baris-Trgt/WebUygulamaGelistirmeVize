#pragma checksum "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f82441de23daf05e0daf9fdba5a781453e6ee61f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stok_Durum), @"mvc.1.0.view", @"/Views/Stok/Durum.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f82441de23daf05e0daf9fdba5a781453e6ee61f", @"/Views/Stok/Durum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd2d752a97723776494ae273b83f58135a0ca9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Stok_Durum : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebUygulamaGelistirmeVize.Models.Stok>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StokEkle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
  
    ViewData["Title"] = "Durum";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--Yukarıda sayfanin hangi model tipinde calisacagini belirtir-->\r\n<!-- Stok classı içerisinde her bir eleman sayilabilir duruma gelir -->\r\n\r\n<h2>Stok Durumu</h2> <!--Baslik kismi-->\r\n<br>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f82441de23daf05e0daf9fdba5a781453e6ee61f4039", async() => {
                WriteLiteral("Stoğa Yeni Ürün Ekle");
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
            WriteLiteral(@"  <!--method olarak StokEkle kullanilacak-->
</p>
<table class=""table text-white bg-dark""> <!--tablonun arka plan ve yazi rengini belirledim-->
    <!--th iclerinde olan olaylar == Veri tipinin icerisinde ayni veri tipine ait olan ozellikleri dondurur -->
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 22 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
           Write(Html.DisplayNameFor(model => model.Urun_Adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
           Write(Html.DisplayNameFor(model => model.Urun_Fiyat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
           Write(Html.DisplayNameFor(model => model.Marka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
           Write(Html.DisplayNameFor(model => model.Stok_Durumu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!--Sayfada dondurulen listenin kendisi yani StokVeri\'nin icerisinde Stoklar tipi kismidir . Model(Liste) icerisnde item ozelliklerini gosterir-->\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
               Write(Html.DisplayFor(modelItem => item.Urun_Adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
               Write(Html.DisplayFor(modelItem => item.Urun_Fiyat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
               Write(Html.DisplayFor(modelItem => item.Marka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
               Write(Html.DisplayFor(modelItem => item.Stok_Durumu));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </td>
                <td>
                    <!-- buton olusturdum , renkler verdim , ilgli Actionlinklerini bagladim -->
                    <!--text isimlerini verdim sonra actionName isimlerini verdim.actionName(StokController icerisinde) -->
                    <button type=""button"" class=""btn btn-success"">");
#nullable restore
#line 62 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
                                                             Write(Html.ActionLink("Güncelle", "StokGuncelle", new { id = item.Id }, new { style = "color: Black;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </button> |\r\n                    <button type=\"button\" class=\"btn btn-warning\">");
#nullable restore
#line 63 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
                                                             Write(Html.ActionLink("Detay", "StokDetay", new { id = item.Id }, new { style = "color: Black;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </button>|\r\n                    <button type=\"button\" class=\"btn btn-danger\">");
#nullable restore
#line 64 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
                                                            Write(Html.ActionLink("Sil", "StokSil", new { id = item.Id }, new { style = "color: Black;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 67 "J:\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\WebUygulamaGelistirmeVize\Views\Stok\Durum.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebUygulamaGelistirmeVize.Models.Stok>> Html { get; private set; }
    }
}
#pragma warning restore 1591