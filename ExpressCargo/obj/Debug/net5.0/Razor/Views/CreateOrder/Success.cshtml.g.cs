#pragma checksum "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\CreateOrder\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0126dd0b5f3a35a42184bd3d64829605169fc08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CreateOrder_Success), @"mvc.1.0.view", @"/Views/CreateOrder/Success.cshtml")]
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
#line 1 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\_ViewImports.cshtml"
using ExpressCargo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\_ViewImports.cshtml"
using ExpressCargo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0126dd0b5f3a35a42184bd3d64829605169fc08", @"/Views/CreateOrder/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9489323ef84ef353244979bf42b48210c99030a8", @"/Views/_ViewImports.cshtml")]
    public class Views_CreateOrder_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\CreateOrder\Success.cshtml"
  
    ViewData["Title"] = "Express Kargo - Kayıt Başarılı";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card text-center"">
            <br />
            <h2 class=""text-success"">Kargo Kaydı Başarıyla Tamamlandı</h2>
            <hr />
            <div class=""alert alert-success mt-3"">
                <h4>
                    Lütfen aşağıdaki takip numarasını müşteri ile paylaşınız.
                </h4><br />
                <h1>
                    Takip Numarası: <bold>");
#nullable restore
#line 17 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\CreateOrder\Success.cshtml"
                                     Write(TempData["TrackNumber"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</bold>\r\n                </h1>\r\n                <br />\r\n            </div>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 684, "\"", 725, 1);
#nullable restore
#line 21 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\CreateOrder\Success.cshtml"
WriteAttributeValue("", 691, Url.Action("Index","CreateOrder"), 691, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Yeni Kayıt Gir</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 785, "\"", 820, 1);
#nullable restore
#line 22 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\CreateOrder\Success.cshtml"
WriteAttributeValue("", 792, Url.Action("Index","Admin"), 792, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Ana Sayfaya Dön</a>\r\n             <br /><br />\r\n        </div>\r\n    </div>\r\n</div>");
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
