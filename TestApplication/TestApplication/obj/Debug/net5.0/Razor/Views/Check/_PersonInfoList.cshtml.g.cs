#pragma checksum "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_PersonInfoList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17b9c1c962edcf53567320159b653cef4a58ddfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Check__PersonInfoList), @"mvc.1.0.view", @"/Views/Check/_PersonInfoList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Check/_PersonInfoList.cshtml", typeof(AspNetCore.Views_Check__PersonInfoList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17b9c1c962edcf53567320159b653cef4a58ddfc", @"/Views/Check/_PersonInfoList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c18df14659d9ffcf730f540f4c694666d270b7cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Check__PersonInfoList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestSelise.Models.Models.PersonVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 218, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>User Name</th>\r\n            <th>Address</th>\r\n            <th></th>\r\n        </tr>\r\n        \r\n        <tr>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 15 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_PersonInfoList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(322, 36, true);
            WriteLiteral("            <tr>\r\n\r\n            <td>");
            EndContext();
            BeginContext(359, 15, false);
#line 19 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_PersonInfoList.cshtml"
           Write(item.PersonName);

#line default
#line hidden
            EndContext();
            BeginContext(374, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(398, 12, false);
#line 20 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_PersonInfoList.cshtml"
           Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(410, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(452, 59, false);
#line 22 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_PersonInfoList.cshtml"
           Write(Html.ActionLink("Edit", "Create", new { id=item.PersonId }));

#line default
#line hidden
            EndContext();
            BeginContext(511, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(532, 65, false);
#line 23 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_PersonInfoList.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.PersonId }));

#line default
#line hidden
            EndContext();
            BeginContext(597, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(618, 63, false);
#line 24 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_PersonInfoList.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.PersonId }));

#line default
#line hidden
            EndContext();
            BeginContext(681, 54, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n            </tr>\r\n");
            EndContext();
#line 28 "D:\2022_Selise\TestApplication\TestApplication\Views\Check\_PersonInfoList.cshtml"

        }

#line default
#line hidden
            BeginContext(748, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestSelise.Models.Models.PersonVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591