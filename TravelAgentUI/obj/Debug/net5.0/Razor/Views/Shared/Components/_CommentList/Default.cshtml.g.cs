#pragma checksum "C:\Users\ssame\Desktop\Github\TravelAgentApp\TravelAgentUI\Views\Shared\Components\_CommentList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab39de2d35b56de22a628f86278537d3f3dc0574"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__CommentList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_CommentList/Default.cshtml")]
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
#line 1 "C:\Users\ssame\Desktop\Github\TravelAgentApp\TravelAgentUI\Views\_ViewImports.cshtml"
using TravelAgentUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ssame\Desktop\Github\TravelAgentApp\TravelAgentUI\Views\_ViewImports.cshtml"
using TravelAgentUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ssame\Desktop\Github\TravelAgentApp\TravelAgentUI\Views\Shared\Components\_CommentList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab39de2d35b56de22a628f86278537d3f3dc0574", @"/Views/Shared/Components/_CommentList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41c9057c74be0c021d4dc1177dbd4c5f2931392b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__CommentList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/TraversalTema/assets/images/c1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"comments mt-5\">\r\n    <h4 class=\"side-title \">Yorumlar (2)</h4>\r\n");
#nullable restore
#line 5 "C:\Users\ssame\Desktop\Github\TravelAgentApp\TravelAgentUI\Views\Shared\Components\_CommentList\Default.cshtml"
     foreach (var item in Model)
    {
        
   

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"media mt-4\">\r\n        <div class=\"img-circle\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ab39de2d35b56de22a628f86278537d3f3dc05745023", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"media-body\">\r\n\r\n            <ul class=\"time-rply mb-2\">\r\n                <li>\r\n                    <a href=\"#URL\" class=\"name mt-0 mb-2 d-block\">");
#nullable restore
#line 17 "C:\Users\ssame\Desktop\Github\TravelAgentApp\TravelAgentUI\Views\Shared\Components\_CommentList\Default.cshtml"
                                                             Write(item.CommentUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                   ");
#nullable restore
#line 18 "C:\Users\ssame\Desktop\Github\TravelAgentApp\TravelAgentUI\Views\Shared\Components\_CommentList\Default.cshtml"
              Write(item.CommentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </li>\r\n                <li class=\"reply-last\">\r\n                    <a href=\"#reply\" class=\"reply\">\r\n                        Yanıtla\r\n                    </a>\r\n                </li>\r\n            </ul>\r\n            <p>\r\n                ");
#nullable restore
#line 28 "C:\Users\ssame\Desktop\Github\TravelAgentApp\TravelAgentUI\Views\Shared\Components\_CommentList\Default.cshtml"
           Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\ssame\Desktop\Github\TravelAgentApp\TravelAgentUI\Views\Shared\Components\_CommentList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
