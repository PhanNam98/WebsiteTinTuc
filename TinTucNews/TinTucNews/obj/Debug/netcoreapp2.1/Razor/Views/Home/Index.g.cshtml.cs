#pragma checksum "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2161187bc603e30b217abb34652adf94a2e57e72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\_ViewImports.cshtml"
using TinTucNews;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2161187bc603e30b217abb34652adf94a2e57e72", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf167e0200e396807f55570c68bfdcdae33169fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TinTucNews.Models.New>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("post-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(88, 166, true);
            WriteLiteral("\r\n<!-- row -->\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"section-title\">\r\n            <h2>Most Visited</h2>\r\n        </div>\r\n    </div>\r\n\r\n");
            EndContext();
#line 14 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
     foreach (var item in Model.Take(2))
    {

#line default
#line hidden
            BeginContext(303, 114, true);
            WriteLiteral("        <!-- post -->\r\n        <div class=\"col-md-6\">\r\n            <div class=\"post post-thumb\">\r\n                ");
            EndContext();
            BeginContext(417, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9891092a2452464abed9844681e35791", async() => {
                BeginContext(482, 4, true);
                WriteLiteral("<img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 486, "\"", 506, 1);
#line 19 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
WriteAttributeValue("", 492, item.UrlImage, 492, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(507, 8, true);
                WriteLiteral(" alt=\"\">");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
                                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(519, 216, true);
            WriteLiteral("\r\n                <div class=\"post-body\">\r\n                    <div class=\"post-meta\">\r\n                        <a class=\"post-category cat-2\" href=\"#\">JavaScript</a>\r\n                        <span class=\"post-date\">");
            EndContext();
            BeginContext(736, 16, false);
#line 23 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
                                           Write(item.CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(752, 106, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <h3 class=\"post-title\">\r\n                        ");
            EndContext();
            BeginContext(858, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd91ba019c7a453193da73770925931b", async() => {
                BeginContext(907, 40, false);
#line 26 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(951, 113, true);
            WriteLiteral("\r\n                    </h3>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- /post -->\r\n");
            EndContext();
#line 32 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1071, 187, true);
            WriteLiteral("</div>\r\n<!-- /row -->\r\n<!-- row -->\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"section-title\">\r\n            <h2>Recent Posts</h2>\r\n        </div>\r\n    </div>\r\n\r\n");
            EndContext();
#line 43 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
      int i = 1;

#line default
#line hidden
            BeginContext(1277, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1313, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 45 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
     foreach (var item in Model.Select((value, index) => new { value, index }))
    {


#line default
#line hidden
            BeginContext(1405, 103, true);
            WriteLiteral("        <!-- post -->\r\n        <div class=\"col-md-4\">\r\n            <div class=\"post\">\r\n                ");
            EndContext();
            BeginContext(1508, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "693c38615bf44be9861666c2d099dc63", async() => {
                BeginContext(1579, 4, true);
                WriteLiteral("<img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1583, "\"", 1609, 1);
#line 51 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
WriteAttributeValue("", 1589, item.value.UrlImage, 1589, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1610, 8, true);
                WriteLiteral(" alt=\"\">");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
                                                           WriteLiteral(item.value.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1622, 216, true);
            WriteLiteral("\r\n                <div class=\"post-body\">\r\n                    <div class=\"post-meta\">\r\n                        <a class=\"post-category cat-1\" href=\"#\">Web Design</a>\r\n                        <span class=\"post-date\">");
            EndContext();
            BeginContext(1839, 22, false);
#line 55 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
                                           Write(item.value.CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(1861, 80, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <h3 class=\"post-title\">");
            EndContext();
            BeginContext(1941, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f22667915d4b4d45b4eccb87a5d114e8", async() => {
                BeginContext(1996, 16, false);
#line 57 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
                                                                                            Write(item.value.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
                                                                     WriteLiteral(item.value.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2016, 67, true);
            WriteLiteral("</h3>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(2085, 24, true);
            WriteLiteral("        <!-- /post -->\r\n");
            EndContext();
#line 63 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
         if (i % 3 == 0)
        {

#line default
#line hidden
            BeginContext(2146, 64, true);
            WriteLiteral("            <div class=\"clearfix visible-md visible-lg\"></div>\r\n");
            EndContext();
#line 66 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#line 66 "C:\Users\Admin\Documents\Visual Studio 2017\Projects\TinTucNews\TinTucNews\Views\Home\Index.cshtml"
         
        i++;
    }

#line default
#line hidden
            BeginContext(2242, 23, true);
            WriteLiteral("</div>\r\n<!-- /row -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TinTucNews.Models.New>> Html { get; private set; }
    }
}
#pragma warning restore 1591
