#pragma checksum "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5e53da79a4e5c2a8cb46ffe8169bca6b7a89a7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5e53da79a4e5c2a8cb46ffe8169bca6b7a89a7f", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9489323ef84ef353244979bf42b48210c99030a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Express Kargo - Şube İşlemleri";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""dashboard-cards"">
    <div class=""row"">
        <h1 class=""text-center"">Express Kargo Şube İşlemleri</h1><hr />
        <div class=""col-xs-12 col-sm-6 col-md-3"">
            <a href=""/AdminOrder/Index/1"">

                <div class=""card horizontal cardIcon waves-effect waves-dark"">
                    <div class=""card-image red"">
                        <i class=""material-icons dp48"">call_made</i>
                    </div>
                    <div class=""card-stacked red"">
                        <div class=""card-content"">
                            <h3>Sevk Bekleyenler</h3>
                        </div>
                        <div class=""card-action"">
                            <strong>");
#nullable restore
#line 22 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
                               Write(Model.Waiting);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                        </div>
                    </div>
                </div>
            </a>

        </div>
        <div class=""col-xs-12 col-sm-6 col-md-3"">
            <a href=""/AdminOrder/Index/2"">

                <div class=""card horizontal cardIcon waves-effect waves-dark"">
                    <div class=""card-image orange"">
                        <i class=""material-icons dp48"">swap_vertical_circle</i>
                    </div>
                    <div class=""card-stacked orange"">
                        <div class=""card-content"">
                            <h3>Yola Çıktı</h3>
                        </div>
                        <div class=""card-action"">
                            <strong>");
#nullable restore
#line 41 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
                               Write(Model.OnRoad);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                        </div>
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-xs-12 col-sm-6 col-md-3"">
            <a href=""/AdminOrder/Index/3"">

                <div class=""card horizontal cardIcon waves-effect waves-dark"">
                    <div class=""card-image blue"">
                        <i class=""material-icons dp48"">business</i>
                    </div>
                    <div class=""card-stacked blue"">
                        <div class=""card-content"">
                            <h3>Varış Şubesinde</h3>
                        </div>
                        <div class=""card-action"">
                            <strong>");
#nullable restore
#line 59 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
                               Write(Model.OnArrival);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                        </div>
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-xs-12 col-sm-6 col-md-3"">
            <a href=""/AdminOrder/Index/5"">

                <div class=""card horizontal cardIcon waves-effect waves-dark"">
                    <div class=""card-image green"">
                        <i class=""material-icons dp48"">done</i>
                    </div>
                    <div class=""card-stacked green"">
                        <div class=""card-content"">
                            <h3>Teslim Edildi</h3>
                        </div>
                        <div class=""card-action"">
                            <strong>");
#nullable restore
#line 77 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
                               Write(Model.Completed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </a>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3340, "\"", 3381, 1);
#nullable restore
#line 86 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
WriteAttributeValue("", 3347, Url.Action("Index","CreateOrder"), 3347, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""card horizontal cardIcon waves-effect waves-dark"">
                    <div class=""card-image blue-grey"">
                        <i class=""material-icons dp48"">assignment</i>
                    </div>
                    <div class=""card-stacked blue-grey"">
                        <div class=""card-content"">
                            <h3>Yeni Kargo Girişi</h3>
                        </div>
                        <div class=""card-action"">
                            <strong>Yeni bir kayıt yapmak için tıklayın.</strong>
                        </div>
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-md-6"">
            <a href=""/AdminOrder/Index/"">
                <div class=""card horizontal cardIcon waves-effect waves-dark"">
                    <div class=""card-image purple"">
                        <i class=""material-icons dp48"">mode_edit</i>
                    </div>
                    <div class");
            WriteLiteral("=\"card-stacked purple\">\r\n                        <div class=\"card-content\">\r\n                            <h3>Tüm Kargolar</h3>\r\n                        </div>\r\n                        <div class=\"card-action\">\r\n                            <strong>");
#nullable restore
#line 113 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
                               Write(Model.All);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                </a>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <br /><br />\r\n        <h1 class=\"text-center\">Son Mesajlar</h1><hr />\r\n");
#nullable restore
#line 123 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
         foreach (var item in Model.LastContacts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 col-sm-4\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-content\">\r\n                        <span class=\"card-title\">");
#nullable restore
#line 128 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
                                            Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 128 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
                                                            Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <p>\r\n                            ");
#nullable restore
#line 130 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
                       Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <br />\r\n                        <sub style=\"float:right;\">");
#nullable restore
#line 133 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
                                             Write(item.ContactDate.ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</sub>\r\n                    </div>\r\n                    <div class=\"card-action\">\r\n                        <p>İletişim Adresi: ");
#nullable restore
#line 136 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
                                       Write(item.ContactMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 140 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 5670, "\"", 5712, 1);
#nullable restore
#line 142 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
WriteAttributeValue("", 5677, Url.Action("Index","AdminContact"), 5677, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-block\">Tümünü Gör</a>\r\n\r\n    <div class=\"row\">\r\n        <br /><br />\r\n        <h1 class=\"text-center\">Son Yorumlar</h1><hr />\r\n");
#nullable restore
#line 147 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
         foreach (var item in Model.LastComments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 col-sm-4\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-content\">\r\n                        <span class=\"card-title\">");
#nullable restore
#line 152 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
                                            Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 152 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
                                                            Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <p>\r\n                            ");
#nullable restore
#line 154 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
                       Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <br />\r\n                        <sub style=\"float:right;\">");
#nullable restore
#line 157 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
                                             Write(item.CommentDate.ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</sub>\r\n                    </div>\r\n                    <div class=\"card-action\">\r\n                        <p>Durum: ");
#nullable restore
#line 160 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
                              Write((item.IsActive) ? "Onaylı": "Onay Bekliyor");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 164 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 6654, "\"", 6696, 1);
#nullable restore
#line 166 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Admin\Index.cshtml"
WriteAttributeValue("", 6661, Url.Action("Index","AdminComment"), 6661, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-block\">Tümünü Gör</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
