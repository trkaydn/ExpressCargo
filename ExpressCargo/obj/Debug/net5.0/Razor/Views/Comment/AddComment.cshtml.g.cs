#pragma checksum "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Comment\AddComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e2be9eb36f42eea4d193be7ea2a641ae1a8960c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_AddComment), @"mvc.1.0.view", @"/Views/Comment/AddComment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e2be9eb36f42eea4d193be7ea2a641ae1a8960c", @"/Views/Comment/AddComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9489323ef84ef353244979bf42b48210c99030a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_AddComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommentVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/jquery-2.1.0.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h4>Bir Yorum B??rak</h4>\r\n<div class=\"contact-form\">\r\n");
#nullable restore
#line 4 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Comment\AddComment.cshtml"
     if (TempData["CommentMessage"] == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <fieldset>\r\n                    ");
#nullable restore
#line 9 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Comment\AddComment.cshtml"
               Write(Html.TextBoxFor(x => x.FirstName, new { placeholder = "Ad??n??z..", @class = "mb-2", id = "firstName" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 10 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Comment\AddComment.cshtml"
               Write(Html.ValidationMessageFor(x => x.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </fieldset>\r\n            </div>\r\n            <div class=\"col-lg-12\">\r\n                <fieldset>\r\n                    ");
#nullable restore
#line 15 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Comment\AddComment.cshtml"
               Write(Html.TextBoxFor(x => x.LastName, new { placeholder = "Soyad??n??z..", @class = "mb-2", id = "lastName" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 16 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Comment\AddComment.cshtml"
               Write(Html.ValidationMessageFor(x => x.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </fieldset>\r\n            </div>\r\n            <div class=\"col-lg-12\">\r\n                <fieldset>\r\n                    ");
#nullable restore
#line 21 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Comment\AddComment.cshtml"
               Write(Html.TextAreaFor(x => x.CommentContent, new { placeholder = "Mesaj??n??z..", @class = "mb-2", id = "commentContent" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Comment\AddComment.cshtml"
               Write(Html.ValidationMessageFor(x => x.CommentContent, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </fieldset>
            </div>
            <div class=""col-lg-12"">
                <fieldset>
                    <button id=""submitForm"" class=""main-button mt-2"">G??nder</button>
                </fieldset>
            </div>
        </div>
");
#nullable restore
#line 31 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Comment\AddComment.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success mt-3\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Comment\AddComment.cshtml"
       Write(TempData["CommentMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <button id=\"clear\" class=\"main-button mt-2\">Yeni Yorum Ekle</button>\r\n        </div>\r\n");
#nullable restore
#line 39 "C:\Users\Tarik Aydin\Desktop\ExpressCargo\ExpressCargo\Views\Comment\AddComment.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e2be9eb36f42eea4d193be7ea2a641ae1a8960c7362", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>

    $(""#submitForm"").on(""click"", function () {
        var comment = {
            FirstName: $(""#firstName"").val(),
            LastName: $(""#lastName"").val(),
            CommentContent: $(""#commentContent"").val(),
        }

        $.ajax({
            type: 'Post',
            url: '/Comment/AddComment/',
            data: { ""comment"": comment },
            success: function (result) {
                $(""#partialDiv"").html(result);
            }
        })
    });

    $(""#clear"").on(""click"", function () {
        $.ajax({
            type: 'Get',
            url: '/Comment/AddComment/',
            success: function (result) {
                $(""#partialDiv"").html(result);
            }
        })
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommentVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
