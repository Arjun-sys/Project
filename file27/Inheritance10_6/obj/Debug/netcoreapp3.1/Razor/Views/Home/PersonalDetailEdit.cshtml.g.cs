#pragma checksum "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "493b29811d142bb6f9cf44ffbd2722f90f81aa43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PersonalDetailEdit), @"mvc.1.0.view", @"/Views/Home/PersonalDetailEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"493b29811d142bb6f9cf44ffbd2722f90f81aa43", @"/Views/Home/PersonalDetailEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd6f98377b487da0db692abf10c5ecd8544ebae7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PersonalDetailEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
  
    ViewData["Title"] = "PersonalDetail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>PersonalDetail</h1>\r\n<h2>Here is my personal details</h2>\r\n\r\n");
#nullable restore
#line 9 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
Write(Html.ActionLink("Person List", "Persons", "Home", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
 using (Html.BeginForm("PersonalDetailEdit", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
Write(Html.HiddenFor(x => Model.PersonalDetailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("<table border=\"1\">\r\n");
#nullable restore
#line 14 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
     if (Model.ErrorMsg != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
           Write(Html.DisplayNameFor(x => x.ErrorMsg));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
           Write(Html.DisplayFor(x => Model.ErrorMsg));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 20 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>Particular</td>\r\n        <td>Details</td>\r\n        <td></td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>");
#nullable restore
#line 28 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
       Write(Html.DisplayNameFor(x => x.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
       Write(Html.TextBoxFor(x => Model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td> ");
#nullable restore
#line 30 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
        Write(Html.ValidationMessageFor(x => Model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 33 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
       Write(Html.DisplayNameFor(x => x.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
       Write(Html.TextBoxFor(x => Model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td> ");
#nullable restore
#line 35 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
        Write(Html.ValidationMessageFor(x => Model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 38 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
       Write(Html.DisplayNameFor(x => x.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 39 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
       Write(Html.TextBoxFor(x => Model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td> ");
#nullable restore
#line 40 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
        Write(Html.ValidationMessageFor(x => Model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 43 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
       Write(Html.DisplayNameFor(x => x.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 44 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
       Write(Html.TextBoxFor(x => Model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td> ");
#nullable restore
#line 45 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
        Write(Html.ValidationMessageFor(x => Model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 48 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
       Write(Html.LabelFor(x => x.ImageLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><input type=\"file\" name=\"profile-image\" /></td>\r\n    </tr>\r\n    <tr>\r\n        <td colspan=\"2\"><button type=\"submit\"><i class=\"btn btn-save\"></i> Edit</button></td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 55 "D:\Dot net practical\file27\Inheritance10_6\Views\Home\PersonalDetailEdit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
