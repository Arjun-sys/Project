#pragma checksum "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b11b5ec970decd0168e09115247e822818c4e630"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PersonalDetail), @"mvc.1.0.view", @"/Views/Home/PersonalDetail.cshtml")]
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
#line 1 "D:\Dot net practical\file27\Inheritance10_6\Views\_ViewImports.cshtml"
using Inheritance13;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dot net practical\file27\Inheritance10_6\Views\_ViewImports.cshtml"
using Inheritance13.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b11b5ec970decd0168e09115247e822818c4e630", @"/Views/Home/PersonalDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd6f98377b487da0db692abf10c5ecd8544ebae7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PersonalDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
  
    ViewData["Title"] = "PersonalDetail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>PersonalDetail</h1>\r\n<h2>Here is my personal details</h2>\r\n\r\n");
#nullable restore
#line 9 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
Write(Html.ActionLink("Person List", "Persons", "Home", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table border=\"1\">\r\n    <tr>\r\n        <td>Particular</td>\r\n        <td>Details</td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 370, "\"", 414, 1);
#nullable restore
#line 17 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
WriteAttributeValue("", 376, Url.Content("~/"+Model.ImageLocation), 376, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n        <td>\r\n");
#nullable restore
#line 20 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
             if (!string.IsNullOrEmpty(Model.ImageLocation))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 560, "\"", 643, 1);
#nullable restore
#line 22 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
WriteAttributeValue("", 567, Url.Action("DownloadFile","Home",new { personId = Model.PersonalDetailId }), 567, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click to downlaod / view </a>\r\n");
#nullable restore
#line 23 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n");
#nullable restore
#line 27 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
             if (!string.IsNullOrEmpty(Model.ImageLocation))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 833, "\"", 878, 1);
#nullable restore
#line 29 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
WriteAttributeValue("", 840, Url.Content("~/"+Model.ImageLocation), 840, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click to downlaod / view </a>\r\n");
#nullable restore
#line 30 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 36 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
       Write(Html.DisplayNameFor(x => x.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 37 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
       Write(Html.DisplayFor(x => Model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 40 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
       Write(Html.DisplayNameFor(x => x.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 41 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
       Write(Html.DisplayFor(x => Model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 44 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
       Write(Html.DisplayNameFor(x => x.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 45 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
       Write(Html.DisplayFor(x => Model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 48 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
       Write(Html.DisplayNameFor(x => x.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 49 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetail.cshtml"
       Write(Html.DisplayFor(x => Model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonalDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
