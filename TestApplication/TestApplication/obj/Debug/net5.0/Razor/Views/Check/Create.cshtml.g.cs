#pragma checksum "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dea08a3030e759c98b403a4d37beb494e77bbd04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Check_Create), @"mvc.1.0.view", @"/Views/Check/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Check/Create.cshtml", typeof(AspNetCore.Views_Check_Create))]
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
#line 1 "D:\2022_Selise\TestApplication\TestApplication\Views\_ViewImports.cshtml"
using TestApplication;

#line default
#line hidden
#line 2 "D:\2022_Selise\TestApplication\TestApplication\Views\_ViewImports.cshtml"
using TestApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea08a3030e759c98b403a4d37beb494e77bbd04", @"/Views/Check/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c18df14659d9ffcf730f540f4c694666d270b7cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Check_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestApplication.ViewModels.PersonRelatedInfoVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("personalInfoForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexChild", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.2.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(146, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(148, 4626, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dea08a3030e759c98b403a4d37beb494e77bbd045051", async() => {
                BeginContext(176, 107, true);
                WriteLiteral("\r\n    <div class=\"col-md-12 no-padding\">\r\n\r\n        <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n            ");
                EndContext();
                BeginContext(284, 46, false);
#line 12 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
       Write(Html.HiddenFor(model => model.person.PersonId));

#line default
#line hidden
                EndContext();
                BeginContext(330, 117, true);
                WriteLiteral("\r\n            <div class=\" form-horizontal\">\r\n                <div class=\"form-group required\">\r\n                    ");
                EndContext();
                BeginContext(448, 118, false);
#line 15 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
               Write(Html.LabelFor(model => model.person.DivisionId, "???????????????", new { @class = "control-label col-md-3 col-sm-3 col-xs-12" }));

#line default
#line hidden
                EndContext();
                BeginContext(566, 90, true);
                WriteLiteral("\r\n                    <div class=\"col-md-9  col-sm-9 col-xs-12\">\r\n                        ");
                EndContext();
                BeginContext(657, 197, false);
#line 17 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
                   Write(Html.DropDownListFor(model => model.person.DivisionId, Model.commonVm.DivisionsSelectListItems, "??????????????? ????????????", new { @class = "form-control field-validator required-field", @required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(854, 127, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group required\">\r\n                    ");
                EndContext();
                BeginContext(982, 124, false);
#line 22 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
               Write(Html.LabelFor(model => model.person.DateOfBirth, "???????????? ???????????????", new { @class = "control-label col-md-3 col-sm-3 col-xs-12" }));

#line default
#line hidden
                EndContext();
                BeginContext(1106, 90, true);
                WriteLiteral("\r\n                    <div class=\"col-md-9  col-sm-9 col-xs-12\">\r\n                        ");
                EndContext();
                BeginContext(1197, 199, false);
#line 24 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
                   Write(Html.TextBoxFor(model => model.person.DateOfBirth, "{0:dd-MMM-yyyy}", new { @class = "form-control field-validator required-field datepicker", @required = "required", @onkeypress = "return false;" }));

#line default
#line hidden
                EndContext();
                BeginContext(1396, 127, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group required\">\r\n                    ");
                EndContext();
                BeginContext(1524, 116, false);
#line 29 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
               Write(Html.LabelFor(model => model.person.PersonName, "?????????", new { @class = "control-label col-md-3 col-sm-3 col-xs-12" }));

#line default
#line hidden
                EndContext();
                BeginContext(1640, 90, true);
                WriteLiteral("\r\n                    <div class=\"col-md-9  col-sm-9 col-xs-12\">\r\n                        ");
                EndContext();
                BeginContext(1731, 151, false);
#line 31 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
                   Write(Html.TextBoxFor(model => model.person.PersonName, new { @class = "form-control checkTextArea field-validator required-field", @required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(1882, 274, true);
                WriteLiteral(@"
                    </div>
                </div>
                
            </div>
        </div>
        <div class=""col-md-6 col-sm-6 col-xs-12"">
            <div class="" form-horizontal"">
                <div class=""form-group required"">
                    ");
                EndContext();
                BeginContext(2157, 116, false);
#line 40 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
               Write(Html.LabelFor(model => model.person.Address, "??????????????????", new { @class = "control-label col-md-3 col-sm-3 col-xs-12" }));

#line default
#line hidden
                EndContext();
                BeginContext(2273, 90, true);
                WriteLiteral("\r\n                    <div class=\"col-md-9  col-sm-9 col-xs-12\">\r\n                        ");
                EndContext();
                BeginContext(2364, 149, false);
#line 42 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
                   Write(Html.TextAreaFor(model => model.person.Address, new { @class = "form-control checkTextArea field-validator required-field", @required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(2513, 118, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(2632, 111, false);
#line 47 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
               Write(Html.LabelFor(model => model.person.Photo, "?????????", new { @class = "control-label col-md-3 col-sm-3 col-xs-12" }));

#line default
#line hidden
                EndContext();
                BeginContext(2743, 458, true);
                WriteLiteral(@"
                    <div class=""col-md-9  col-sm-9 col-xs-12"">
                        <input type='file' name=""UserPictureSource"" id=""UserPictureSource"" class=""breakWord image-upload UserPictureSource field-validator "" onchange=""readUserPictureURL(this, 'UserImage', 'UserPictureSource');"" />
                        <div id=""UserImageDiv"" class=""img-container-div img-container-div-border"">
                            <img id=""UserImage"" alt=""&nbsp;""");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3201, "\"", 3226, 1);
#line 51 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
WriteAttributeValue("", 3207, Model.person.Photo, 3207, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3227, 1035, true);
                WriteLiteral(@" style=""height:120px;width:80px"" />
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <br />
    <br />
    <div class=""col-md-12 no-padding"">
        <div class=""col-md-6 col-sm-6 col-xs-12"">
            <div class="" form-horizontal"">
                <div class=""form-group required"">
                    <label class=""control-label col-md-3 col-sm-3 col-xs-12"">???????????????????????? ???????????????</label>
                    <div class=""col-md-6 col-sm-6 col-xs-12"">
                        <input type=""file"" name=""file"" id=""Files"" class=""breakWord"" />
                    </div>
                    <div class=""col-md-3 col-sm-3 col-xs-12"">
                        <input type=""button"" id=""UploadBtn"" class=""btn btn-info form-control"" value=""???????????????"" />
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-6 col-sm-6 col-xs-12"">
            <div id=""dvCommUploadDetails"">
     ");
                WriteLiteral("           ");
                EndContext();
                BeginContext(4263, 59, false);
#line 77 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
           Write(Html.Partial("_AttachmentList", Model.person.DocumentInfos));

#line default
#line hidden
                EndContext();
                BeginContext(4322, 445, true);
                WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""col-md-12 col-sm-12 col-xs-12"">
        <div class=""form-group required"">
            <div class=""col-md-7  col-sm-7 col-xs-12"">
            </div>
            <div class=""col-md-5  col-sm-5 col-xs-12"">
                <input type=""button"" id=""btnPersonalInfoSave"" class=""btn btn-info tab-btn-save"" value=""????????????????????? ????????????"" />
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4774, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(4787, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dea08a3030e759c98b403a4d37beb494e77bbd0415435", async() => {
                BeginContext(4814, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4830, 40, true);
            WriteLiteral("\r\n</div>\r\n<div class=\"clearfix\"></div>\r\n");
            EndContext();
            BeginContext(4870, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dea08a3030e759c98b403a4d37beb494e77bbd0416860", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4918, 12, true);
            WriteLiteral("\r\n<script>\r\n");
            EndContext();
            BeginContext(5114, 363, true);
            WriteLiteral(@"

     $(""#btnPersonalInfoSave"").click(function () {
        if (!MandatoryFieldsCheck('#personalInfoForm')) { return; }
        var formData = new FormData($('#personalInfoForm').get(0));
         formData.append(""file"", $(""#UserPictureSource"")[0].files[0]);
        //$(""#btnPersonalInfoSave"").attr('disabled', true);
        $.ajax({
            url: '");
            EndContext();
            BeginContext(5478, 29, false);
#line 112 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
             Write(Url.Action("Create", "Check"));

#line default
#line hidden
            EndContext();
            BeginContext(5507, 925, true);
            WriteLiteral(@"',
            type: ""POST"",
            data: formData,
            processData: false,
            contentType: false,
            success: (function (result) {
                if (result == ""????????? ????????????"") {
                    alertWarning(""????????????????????? ??????????????????"", """");
                    //$(""#btnPersonalInfoSave"").attr('disabled', false);

                }
                else {
                    alertSuccess(""????????????????????? ????????????????????? ???????????????"", """");
                }
            }),
            error: (function (result) {
                alertWarning(""????????? ????????????"", """");
                //$(""#btnPersonalInfoSave"").attr('disabled', false);
            }),
        });
     });

    // upload block
    var Allfiles = new FormData();

    $('#UploadBtn').click(function () {
        var formData = new FormData();
        formData.append(""file"", $(""#Files"")[0].files[0]);
        $.ajax({
            url: '");
            EndContext();
            BeginContext(6433, 25, false);
#line 141 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
             Write(Url.Action("UploadFiles"));

#line default
#line hidden
            EndContext();
            BeginContext(6458, 639, true);
            WriteLiteral(@"',
            type: ""POST"",
            contentType: false, // Not to set any content header
            processData: false, // Not to process data
            data: formData,
            async: false,
            success: function (result) {

                $(""#dvCommUploadDetails"").empty();
                $(""#dvCommUploadDetails"").html(result);

            },
            error: function (err) {
                alert(err.statusText);
            }
        });

    });

    function removeAttachment(name) {
        alert(name);
        $(""#dvCommUploadDetails"").empty();
        $.ajax({
            url: '");
            EndContext();
            BeginContext(7098, 39, false);
#line 164 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\Create.cshtml"
             Write(Url.Action("RemoveAttachment", "Check"));

#line default
#line hidden
            EndContext();
            BeginContext(7137, 352, true);
            WriteLiteral(@"',
            type: ""GET"",
            data: {
                name: name,
            },
            success: (function (result) {
                $(""#dvCommUploadDetails"").html(result);
            }),
            error: (function (result) {
                alertWarning(""Load failed"", """");
            }),
        });
    }
</script>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestApplication.ViewModels.PersonRelatedInfoVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
