#pragma checksum "D:\Dot net practical\file27\Inheritance10_6\Views\Async\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "654589b41cc7f5e74d77f4f4ae3b47084bff2563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Async_Index), @"mvc.1.0.view", @"/Views/Async/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"654589b41cc7f5e74d77f4f4ae3b47084bff2563", @"/Views/Async/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd6f98377b487da0db692abf10c5ecd8544ebae7", @"/Views/_ViewImports.cshtml")]
    public class Views_Async_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Dot net practical\file27\Inheritance10_6\Views\Async\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int counter = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n");
#nullable restore
#line 8 "D:\Dot net practical\file27\Inheritance10_6\Views\Async\Index.cshtml"
 foreach(var item in Model )
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 10 "D:\Dot net practical\file27\Inheritance10_6\Views\Async\Index.cshtml"
  Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 10 "D:\Dot net practical\file27\Inheritance10_6\Views\Async\Index.cshtml"
                Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n");
#nullable restore
#line 11 "D:\Dot net practical\file27\Inheritance10_6\Views\Async\Index.cshtml"
    counter++;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
