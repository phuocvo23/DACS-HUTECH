#pragma checksum "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\Tag\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bb993bcd0c96cb9fa0033e9965f50f7c204fd8453ccc43265b253dacf8bfe527"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Tag_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Tag/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Tag/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Tag_Default))]
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
#line 1 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\_ViewImports.cshtml"
using Reviewer;

#line default
#line hidden
#line 2 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\_ViewImports.cshtml"
using Reviewer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bb993bcd0c96cb9fa0033e9965f50f7c204fd8453ccc43265b253dacf8bfe527", @"/Views/Shared/Components/Tag/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"34e0797b7e25bc8a8a98eb8cde719d7c10274115e96151479c8e7f3a119c2b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Tag_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(130, 17, true);
            WriteLiteral("\r\n<ul id=\"tag\">\r\n");
            EndContext();
#line 8 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\Tag\Default.cshtml"
     foreach (var tag in Model)
    {

#line default
#line hidden
            BeginContext(187, 10, true);
            WriteLiteral("    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 197, "\"", 260, 1);
#line 10 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\Tag\Default.cshtml"
WriteAttributeValue("", 204, Url.Action("BaiVietTheoTag","Home",new { id=tag.MaTag}), 204, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(261, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(263, 10, false);
#line 10 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\Tag\Default.cshtml"
                                                                      Write(tag.TenTag);

#line default
#line hidden
            EndContext();
            BeginContext(273, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 11 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\Tag\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(291, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
