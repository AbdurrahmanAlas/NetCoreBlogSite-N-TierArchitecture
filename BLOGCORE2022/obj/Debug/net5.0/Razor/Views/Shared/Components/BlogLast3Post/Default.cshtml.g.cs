#pragma checksum "C:\Users\lenovo\Desktop\BLOG2022CORE\BLOGCORE2022\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd6ea3000242513becd471385316a41cb9f22f39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#line 1 "C:\Users\lenovo\Desktop\BLOG2022CORE\BLOGCORE2022\Views\_ViewImports.cshtml"
using BLOGCORE2022;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\BLOG2022CORE\BLOGCORE2022\Views\_ViewImports.cshtml"
using BLOGCORE2022.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\lenovo\Desktop\BLOG2022CORE\BLOGCORE2022\Views\Shared\Components\BlogLast3Post\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd6ea3000242513becd471385316a41cb9f22f39", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"848a639461d73aba9c36f0751281a4dc90ed4f48", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"tech-btm\">\r\n        <h3>Son Postlar</h3>\r\n");
#nullable restore
#line 6 "C:\Users\lenovo\Desktop\BLOG2022CORE\BLOGCORE2022\Views\Shared\Components\BlogLast3Post\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 269, "\"", 306, 2);
            WriteAttributeValue("", 276, "/Blog/BlogREadAll/", 276, 18, true);
#nullable restore
#line 10 "C:\Users\lenovo\Desktop\BLOG2022CORE\BLOGCORE2022\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 294, item.BlogID, 294, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 334, "\"", 355, 1);
#nullable restore
#line 11 "C:\Users\lenovo\Desktop\BLOG2022CORE\BLOGCORE2022\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 340, item.BlogImage, 340, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 387, "\"", 393, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 539, "\"", 576, 2);
            WriteAttributeValue("", 546, "/Blog/BlogREadAll/", 546, 18, true);
#nullable restore
#line 18 "C:\Users\lenovo\Desktop\BLOG2022CORE\BLOGCORE2022\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 564, item.BlogID, 564, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\lenovo\Desktop\BLOG2022CORE\BLOGCORE2022\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                        Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("... </a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 22 "C:\Users\lenovo\Desktop\BLOG2022CORE\BLOGCORE2022\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                 Write(((DateTime)
                        item.CreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\lenovo\Desktop\BLOG2022CORE\BLOGCORE2022\Views\Shared\Components\BlogLast3Post\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
