#pragma checksum "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8988ddcb2251977b1958ecd39ea5e99f08e351d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Track_Index), @"mvc.1.0.view", @"/Views/Track/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8988ddcb2251977b1958ecd39ea5e99f08e351d0", @"/Views/Track/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9489323ef84ef353244979bf42b48210c99030a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Track_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrackOrderVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/trackpage/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #f8f9fd;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html lang=\"tr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8988ddcb2251977b1958ecd39ea5e99f08e351d05059", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Express Kargo Takip - ");
#nullable restore
#line 11 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                            Write(Model.TrackNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8988ddcb2251977b1958ecd39ea5e99f08e351d05682", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8988ddcb2251977b1958ecd39ea5e99f08e351d06860", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link href=\"//netdna.bootstrapcdn.com/font-awesome/3.2.1/css/font-awesome.css\" rel=\"stylesheet\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8988ddcb2251977b1958ecd39ea5e99f08e351d08850", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"container  px-md-2\">\r\n            <h6 class=\"display-4 mt-5 text-center\"><a style=\"color:#ed563b;\"");
                BeginWriteAttribute("href", " href=\"", 642, "\"", 676, 1);
#nullable restore
#line 19 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
WriteAttributeValue("", 649, Url.Action("Index","Home"), 649, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Express Kargo</a> Takip</h6>
            <hr />
            <div class=""card"">
                <div class=""row d-flex justify-content-between top"">
                    <div class=""d-flex"">
                        <h5>Takip No: <span class=""text-primary font-weight-bold"">");
#nullable restore
#line 24 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                                                             Write(Model.TrackNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h5>\r\n                    </div>\r\n                    <div class=\"d-flex flex-column text-sm-right\">\r\n                        <p class=\"mb-0\"><strong>Kayıt Tarihi: </strong><span>");
#nullable restore
#line 27 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                                                        Write(Model.OrderDate.ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row d-flex justify-content-center\">\r\n                    <div class=\"col-12\">\r\n                        <ul id=\"progressbar\" class=\"text-center\">\r\n");
#nullable restore
#line 33 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                             switch (Model.StatusID)
                            {
                                case 1:

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <li class=""active step0""></li>
                                    <li class=""step0""></li>
                                    <li class=""step0""></li>
                                    <li class=""step0""></li>
                                    <li class=""step0""></li>
");
#nullable restore
#line 41 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                    break;
                                case 2:

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <li class=""active step0""></li>
                                    <li class=""active step0""></li>
                                    <li class=""step0""></li>
                                    <li class=""step0""></li>
                                    <li class=""step0""></li>
");
#nullable restore
#line 48 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                    break;
                                case 3:

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <li class=""active step0""></li>
                                    <li class=""active step0""></li>
                                    <li class=""active step0""></li>
                                    <li class=""step0""></li>
                                    <li class=""step0""></li>
");
#nullable restore
#line 55 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                    break;
                                case 4:

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <li class=""active step0""></li>
                                    <li class=""active step0""></li>
                                    <li class=""active step0""></li>
                                    <li class=""active step0""></li>
                                    <li class=""step0""></li>
");
#nullable restore
#line 62 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                    break;
                                case 5:

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <li class=""active step0""></li>
                                    <li class=""active step0""></li>
                                    <li class=""active step0""></li>
                                    <li class=""active step0""></li>
                                    <li class=""active step0""></li>
");
#nullable restore
#line 69 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                    break;
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </ul>
                    </div>
                </div>
                <div class=""row justify-content-between top"">
                    <div class=""row d-flex icon-content"">
                        <img class=""icon"" src=""https://i.imgur.com/9nnc9Et.png"">
                        <div class=""d-flex flex-column"">
                            <p class=""font-weight-bold"">Çıkış<br />Şubesinde</p>
                        </div>
                    </div>
                    <div class=""row d-flex icon-content"">
                        <img class=""icon"" src=""https://i.imgur.com/TkPm63y.png"">
                        <div class=""d-flex flex-column"">
                            <p class=""font-weight-bold"">Yola<br />Çıktı</p>
                        </div>
                    </div>
                    <div class=""row d-flex icon-content"">
                        <img class=""icon"" src=""https://i.imgur.com/GiWFtVu.png"">
                        <div class=""d-flex flex-column"">
  ");
                WriteLiteral(@"                          <p class=""font-weight-bold"">Varış<br />Şubesinde</p>
                        </div>
                    </div>
                    <div class=""row d-flex icon-content"">
                        <img class=""icon"" src=""https://i.imgur.com/u1AzR7w.png"">
                        <div class=""d-flex flex-column"">
                            <p class=""font-weight-bold"">Teslimatta</p>
                        </div>
                    </div>
                    <div class=""row d-flex icon-content"">
                        <img class=""icon"" src=""https://i.imgur.com/HdsziHP.png"">
                        <div class=""d-flex flex-column"">
                            <p class=""font-weight-bold"">Teslim<br />Edildi</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""card"">
                        <div class=""card-header"">
        ");
                WriteLiteral(@"                    <h5 class=""text-center"">Gönderi Bilgileri</h5>
                        </div>
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <p><strong>Gönderici Adı: </strong>");
#nullable restore
#line 116 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                                                  Write(Model.SenderName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p><strong>Çıkış Şubesi: </strong>");
#nullable restore
#line 117 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                                                 Write(Model.SenderDistrict.DistrictName);

#line default
#line hidden
#nullable disable
                WriteLiteral("/");
#nullable restore
#line 117 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                                                                                    Write(Model.SenderDistrict.City.CityName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p><strong>Gönderi Türü: </strong>");
#nullable restore
#line 118 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                                                 Write(Model.Size.SizeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p><strong>Gönderi Ücreti: </strong>");
#nullable restore
#line 119 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                                                   Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</p>\r\n                                </div>\r\n                                <div class=\"col\">\r\n                                    <p><strong>Alıcı Adı: </strong>");
#nullable restore
#line 122 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                                              Write(Model.ReceiverName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p><strong>Varış Şubesi: </strong>");
#nullable restore
#line 123 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                                                 Write(Model.ReceiverDistrict.DistrictName);

#line default
#line hidden
#nullable disable
                WriteLiteral("/");
#nullable restore
#line 123 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                                                                                      Write(Model.ReceiverDistrict.City.CityName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p><strong>Gönderim Adresi: </strong>");
#nullable restore
#line 124 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                                                    Write(Model.ShippingAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 124 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                                                                           Write(Model.ReceiverDistrict.DistrictName);

#line default
#line hidden
#nullable disable
                WriteLiteral("/");
#nullable restore
#line 124 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                                                                                                                Write(Model.ReceiverDistrict.City.CityName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h5 class=""text-center"">Gönderi Aşamaları</h5>
                        </div>
                        <div class=""card-body"">
                            <table class=""table table-bordered"">
                                <tr>
                                    <th>Tarih</th>
                                    <th>İşlem</th>
                                </tr>
                                <tbody>
");
#nullable restore
#line 142 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                     foreach (var stage in Model.Stages)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 145 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                           Write(stage.StatusDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 145 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                                                                    Write(stage.StatusDate.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 146 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                           Write(stage.Status.StatusName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 148 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Track\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrackOrderVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
