#pragma checksum "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13ae3b5b43e699245ea5396a483394ccb4605b5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ae3b5b43e699245ea5396a483394ccb4605b5d", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc16d844003408fa6783bc55a96e3e396a7ff0b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--//banner-->
<section class=""banner-bottom"">
    <!--/blog-->
    <div class=""container"">
        <div class=""row"">
            <!--left-->
            <div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">
                <div class=""blog-grid-top"">
                    <div class=""b-grid-top"">
                        <div class=""blog_info_left_grid"">
                            <a href=""single.html"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 596, "\"", 627, 1);
#nullable restore
#line 18 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 602, Model.BlogThumbnailImage, 602, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 646, "\"", 668, 1);
#nullable restore
#line 18 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 652, Model.BlogTitle, 652, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""blog-info-middle"">
                            <ul>
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 25 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Detail.cshtml"
                                                                       Write(Model.CreateDate.ToString("dd-MMMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </a>
                                </li>
                                <li class=""mx-2"">
                                    <a href=""#"">
                                        <i class=""far fa-thumbs-up""></i> 201 Likes
                                    </a>
                                </li>
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-comment""></i> 15 Comments
                                    </a>
                                </li>

                            </ul>
                        </div>
                    </div>
                    
                    <h3>
                        <a href=""single.html"">");
#nullable restore
#line 44 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Detail.cshtml"
                                         Write(Model.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                    </h3>\r\n                    <p>\r\n                        ");
#nullable restore
#line 47 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Detail.cshtml"
                   Write(Model.BlogContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <a href=\"single.html\" class=\"btn btn-primary read-m\">Read More</a>\r\n                </div>\r\n\r\n                ");
#nullable restore
#line 52 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Detail.cshtml"
           Write(await Component.InvokeAsync("CommentListByBlog",new{id=ViewBag.i}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"comment-top\">\r\n                    <h4>Leave a Comment</h4>\r\n                    <div class=\"comment-bottom\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13ae3b5b43e699245ea5396a483394ccb4605b5d8116", async() => {
                WriteLiteral("\r\n                            <input class=\"form-control\" type=\"text\" name=\"Name\" placeholder=\"Name\"");
                BeginWriteAttribute("required", " required=\"", 2465, "\"", 2476, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input class=\"form-control\" type=\"email\" name=\"Email\" placeholder=\"Email\"");
                BeginWriteAttribute("required", " required=\"", 2581, "\"", 2592, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                            <input class=\"form-control\" type=\"text\" name=\"Subject\" placeholder=\"Subject\"");
                BeginWriteAttribute("required", " required=\"", 2702, "\"", 2713, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                            <textarea class=\"form-control\" name=\"Message\" placeholder=\"Message...\"");
                BeginWriteAttribute("required", " required=\"", 2817, "\"", 2828, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n                            <button type=\"submit\" class=\"btn btn-primary submit\">Submit</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>

            <!--//left-->
            <!--right-->
            <aside class=""col-lg-4 agileits-w3ls-right-blog-con text-right"">
                <div class=""right-blog-info text-left"">
                    <div class=""tech-btm"">
                        <img src=""images/banner1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 3351, "\"", 3357, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"tech-btm\">\r\n                        <h4>Sign up to our newsletter</h4>\r\n                        <p>Pellentesque dui, non felis. Maecenas male </p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13ae3b5b43e699245ea5396a483394ccb4605b5d11639", async() => {
                WriteLiteral("\r\n                            <input type=\"email\" placeholder=\"Email\"");
                BeginWriteAttribute("required", " required=\"", 3693, "\"", 3704, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input type=\"submit\" value=\"Subscribe\">\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </div>\r\n                   ");
#nullable restore
#line 85 "C:\Users\Sercan\source\repos\MyBlogProject\BlogApplication\Views\Blog\Detail.cshtml"
              Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <div class=""tech-btm"">
                        <h4>Yazarın Diğer Yazıları</h4>

                        <div class=""blog-grids row mb-3"">
                            <div class=""col-md-5 blog-grid-left"">
                                <a href=""single.html"">
                                    <img src=""/images/1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 4268, "\"", 4274, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""col-md-7 blog-grid-right"">

                                <h5>
                                    <a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
                                </h5>
                                <div class=""sub-meta"">
                                    <span>
                                        <i class=""far fa-clock""></i> 20 Jan, 2018
                                    </span>
                                </div>
                            </div>

                        </div>
                        <div class=""blog-grids row mb-3"">
                            <div class=""col-md-5 blog-grid-left"">
                                <a href=""single.html"">
                                    <img src=""/images/6.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 5214, "\"", 5220, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""col-md-7 blog-grid-right"">
                                <h5>
                                    <a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
                                </h5>
                                <div class=""sub-meta"">
                                    <span>
                                        <i class=""far fa-clock""></i> 20 Feb, 2018
                                    </span>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class=""single-gd my-5 tech-btm"">
                        <h4>Our Progress</h4>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 10%"" aria-valuenow=""10"" aria-valuemin=""0""
              ");
            WriteLiteral(@"                   aria-valuemax=""100""></div>
                        </div>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                        <div class=""pro");
            WriteLiteral(@"gress"">
                            <div class=""progress-bar progress-bar-striped bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                    </div>
                    <div class=""single-gd tech-btm"">
                        <h4>Yazarın eklenen son yazısı</h4>
                        <div class=""blog-grids"">
                            <div class=""blog-grid-left"">
                                <a href=""single.html"">
                                    <img src=""/images/b1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 7920, "\"", 7926, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""blog-grid-right"">

                                <h5>
                                    <a href=""single.html"">Pellentesque dui, non felis. Maecenas male</a>
                                </h5>
                            </div>
                            <div class=""clearfix""> </div>
                        </div>
                    </div>
                </div>

            </aside>
            <!--//right-->
        </div>
    </div>
</section>
<!--//main-->
<!--footer-->

<!---->
<!-- js -->
<script src=""js/jquery-2.2.3.min.js""></script>
<!-- //js -->
<!--/ start-smoth-scrolling -->
<script src=""js/move-top.js""></script>
<script src=""js/easing.js""></script>
<script>
    jQuery(document).ready(function ($) {
        $("".scroll"").click(function (event) {
            event.preventDefault();
            $('html,body').animate({
                scrollTop: $(");
            WriteLiteral(@"this.hash).offset().top
            }, 900);
        });
    });
</script>
<!--// end-smoth-scrolling -->

<script>
    $(document).ready(function () {
        /*
                                var defaults = {
                                    containerID: 'toTop', // fading element id
                                    containerHoverID: 'toTopHover', // fading element hover id
                                    scrollSpeed: 1200,
                                    easingType: 'linear'
                                };
                                */

        $().UItoTop({
            easingType: 'easeOutQuart'
        });

    });
</script>
<a href=""#home"" class=""scroll"" id=""toTop"" style=""display: block;"">
    <span id=""toTopHover"" style=""opacity: 1;""> </span>
</a>

<!-- //Custom-JavaScript-File-Links -->
<script src=""js/bootstrap.js""></script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
