#pragma checksum "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c04ace02f1cdc82867258ac3de4638639a32edca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c04ace02f1cdc82867258ac3de4638639a32edca", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9489323ef84ef353244979bf42b48210c99030a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Express Kargo - İletişim";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section section-bg"" id=""call-to-action"" style=""background-image: url(/assets/images/banner-image-1-1920x500.jpg)"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-10 offset-lg-1"">
                <div class=""cta-content"">
                    <br>
                    <br>
                    <h2>Bizimle <em>İletişim</em> Kurabilirsiniz</h2>
                    <p>
                        Öneri, tavsiye ve görüşlerinize her zaman açığız.
                    </p>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""section"" id=""features"">
    <div class=""container"">
        <div class=""row text-center"">
            <div class=""col-lg-6 offset-lg-3"">
                <div class=""section-heading"">
                    <h2>İletişim <em> Bilgilerimiz</em></h2>
                    <img src=""/assets/images/line-dec.png"" alt=""waves"">

                </div>
            </div>

            <div class");
            WriteLiteral(@"=""col-md-4"">
                <div class=""icon"">
                    <i class=""fa fa-phone""></i>
                </div>
                <h5>+90 536 627 2355</h5>
                <br>
            </div>

            <div class=""col-md-4"">
                <div class=""icon"">
                    <i class=""fa fa-envelope""></i>
                </div>
                <h5>tarikayydin1846@gmail.com</h5>
                <br>
            </div>

            <div class=""col-md-4"">
                <div class=""icon"">
                    <i class=""fa fa-map-marker""></i>
                </div>
                <h5>Sincan, Ankara</h5>
                <br>
            </div>
        </div>
    </div>
</section>

<section class=""section"" id=""contact-us"" style=""margin-top: 0"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-6 col-xs-12"">
                <div id=""map"">
                    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!");
            WriteLiteral(@"1m3!1d3057.969666284613!2d32.58133731032075!3d39.964430898181!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14d33a7d861fb411%3A0xb29b70ae8d09947b!2sAtat%C3%BCrk%2C%20Atat%C3%BCrk%20Cd.%2028-42%2C%2006936%20Sincan%20Osb%2FSincan%2FAnkara!5e0!3m2!1sen!2str!4v1634921715138!5m2!1sen!2str"" width=""100%"" height=""614px"" frameborder=""0"" style=""border:0"" allowfullscreen></iframe>
                </div>
            </div>
            <div class=""col-lg-6 col-md-6 col-xs-12"" id=""partialDiv"">
                ");
#nullable restore
#line 69 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Contact\Index.cshtml"
           Write(await Html.PartialAsync("~/Views/Contact/AddContact.cshtml", new ContactVM()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
