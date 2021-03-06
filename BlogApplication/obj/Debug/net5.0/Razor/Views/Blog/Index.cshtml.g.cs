#pragma checksum "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a77d5fe599534722b3f58b53e3b105ddf996d5c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\_ViewImports.cshtml"
using BlogApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\_ViewImports.cshtml"
using BlogApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77d5fe599534722b3f58b53e3b105ddf996d5c9", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc16d844003408fa6783bc55a96e3e396a7ff0b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Blog Posts</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 16 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 card\">\r\n                            <a href=\"single.html\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 653, "\"", 683, 1);
#nullable restore
#line 20 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml"
WriteAttributeValue("", 659, item.BlogThumbnailImage, 659, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 715, "\"", 721, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""card-body"">
                                <ul class=""blog-icons my-4"">
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i>");
#nullable restore
#line 26 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml"
                                                                          Write(item.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i> 21
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""fas fa-columns""></i> ");
#nullable restore
#line 36 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml"
                                                                      Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n\r\n                                </ul>\r\n                                <h5 class=\"card-title\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1865, "\"", 1897, 2);
            WriteAttributeValue("", 1872, "/Blog/Detail/", 1872, 13, true);
#nullable restore
#line 42 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1885, item.BlogId, 1885, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml"
                                                                   Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n");
#nullable restore
#line 44 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml"
                                 if (item.BlogContent.Length >= 130)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"card-text mb-3\">");
#nullable restore
#line 46 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml"
                                                         Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,130).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("... </p>\r\n                                    <a href=\".ToString(\" dd-MMMM-yyyy\"\" class=\"btn btn-primary read-m\">Read More</a>\r\n");
#nullable restore
#line 48 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"card-text mb-3\">");
#nullable restore
#line 51 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml"
                                                         Write(item.BlogContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2566, "\"", 2598, 2);
            WriteAttributeValue("", 2573, "/Blog/Detail/", 2573, 13, true);
#nullable restore
#line 52 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2586, item.BlogId, 2586, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Read More</a>\r\n");
#nullable restore
#line 53 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 57 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <!--//left-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
