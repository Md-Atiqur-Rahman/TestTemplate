#pragma checksum "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_AttachmentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8235e6a8dc2343f8cb6c022e746286f0b6e97d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Check__AttachmentList), @"mvc.1.0.view", @"/Views/Check/_AttachmentList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Check/_AttachmentList.cshtml", typeof(AspNetCore.Views_Check__AttachmentList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8235e6a8dc2343f8cb6c022e746286f0b6e97d6", @"/Views/Check/_AttachmentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c18df14659d9ffcf730f540f4c694666d270b7cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Check__AttachmentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestSelise.Models.Models.DocumentInfoVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_AttachmentList.cshtml"
  
    Layout = null;
    int i = 0;

#line default
#line hidden
            BeginContext(104, 251, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Sl No</th>\r\n            <th>File Name</th>\r\n            <th style=\"width:80px;\">ডাউনলোড</th>\r\n            <th>Action</th>\r\n        </tr>\r\n\r\n        <tr>\r\n        </tr>\r\n    </thead>\r\n");
            EndContext();
#line 19 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_AttachmentList.cshtml"
     foreach (var item in Model)
    {
        i++;

#line default
#line hidden
            BeginContext(410, 65, true);
            WriteLiteral("<tbody>\r\n    <tr>\r\n        <td class=\"text-center\">\r\n            ");
            EndContext();
            BeginContext(476, 1, false);
#line 25 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_AttachmentList.cshtml"
       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(477, 31, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n");
            EndContext();
#line 28 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_AttachmentList.cshtml"
             if (item.OrgFileName == null)
            {
                

#line default
#line hidden
            BeginContext(584, 43, false);
#line 30 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_AttachmentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.FileName));

#line default
#line hidden
            EndContext();
#line 30 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_AttachmentList.cshtml"
                                                            
            }
            else
            {
                

#line default
#line hidden
            BeginContext(694, 46, false);
#line 34 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_AttachmentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrgFileName));

#line default
#line hidden
            EndContext();
#line 34 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_AttachmentList.cshtml"
                                                               
            }

#line default
#line hidden
            BeginContext(757, 61, true);
            WriteLiteral("        </td>\r\n        <td class=\"text-center\">\r\n            ");
            EndContext();
            BeginContext(819, 109, false);
#line 38 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_AttachmentList.cshtml"
       Write(Html.ActionLink("Download", "DownloadFile", new { fileLocation= item.FileLocation,fileName = item.FileName }));

#line default
#line hidden
            EndContext();
            BeginContext(928, 135, true);
            WriteLiteral("\r\n            </td>\r\n        <td class=\"text-center\">\r\n            <button type=\"button\" class=\"btn btn-primary save-button-validation\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1063, "\"", 1107, 3);
            WriteAttributeValue("", 1073, "removeAttachment(\'", 1073, 18, true);
#line 41 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_AttachmentList.cshtml"
WriteAttributeValue("", 1091, item.FileName, 1091, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1105, "\')", 1105, 2, true);
            EndWriteAttribute();
            BeginContext(1108, 54, true);
            WriteLiteral(">Delete</button>\r\n        </td>\r\n    </tr>\r\n</tbody>\r\n");
            EndContext();
#line 45 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_AttachmentList.cshtml"
}

#line default
#line hidden
            BeginContext(1165, 12, true);
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestSelise.Models.Models.DocumentInfoVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591