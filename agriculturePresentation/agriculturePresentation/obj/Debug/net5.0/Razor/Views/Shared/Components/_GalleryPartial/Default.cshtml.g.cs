#pragma checksum "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36382f20edfb27d1910429a9e126bd13c675247a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__GalleryPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_GalleryPartial/Default.cshtml")]
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
#line 1 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\_ViewImports.cshtml"
using agriculturePresentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\_ViewImports.cshtml"
using agriculturePresentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36382f20edfb27d1910429a9e126bd13c675247a", @"/Views/Shared/Components/_GalleryPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34a8b9f500f20bb3a6e489280d80bfc717cf9691", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__GalleryPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Image>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n <div class=\"gallery\" id=\"gallery\">\r\n\t<div class=\"container\">\r\n\t<h3 class=\"tittle\">Ermişin Tarlası</h3>\r\n\t<p class=\"heading-btm-w3ls\">Güzell</p>\r\n\t\t<div class=\"agile_gallery_grids w3-agile\">\r\n\t\t\t\t<ul class=\"clearfix demo\">\r\n");
#nullable restore
#line 10 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
                     foreach (var item in Model)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<li>\r\n\t\t\t\t\t\t<div class=\"gallery-grid1\">\r\n\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 374, "\"", 394, 1);
#nullable restore
#line 14 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
WriteAttributeValue("", 380, item.ImageUrl, 380, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\" \" class=\"img-responsive\" />\r\n\t\t\t\t\t\t\t<div class=\"p-mask\">\r\n\t\t\t\t\t\t\t\t\t<h4><span>");
#nullable restore
#line 16 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
                                         Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 17 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</li>\r\n");
#nullable restore
#line 21 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</ul>\r\n\t\t\t</div>\r\n\t</div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Image>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591