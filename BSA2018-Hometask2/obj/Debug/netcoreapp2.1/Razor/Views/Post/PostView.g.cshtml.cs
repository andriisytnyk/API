#pragma checksum "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Post\PostView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f019f5887b4f8f0f8c007c498f2ba28bcfc6b3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_PostView), @"mvc.1.0.view", @"/Views/Post/PostView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/PostView.cshtml", typeof(AspNetCore.Views_Post_PostView))]
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
#line 1 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\_ViewImports.cshtml"
using BSA2018_Hometask2;

#line default
#line hidden
#line 2 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\_ViewImports.cshtml"
using BSA2018_Hometask2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f019f5887b4f8f0f8c007c498f2ba28bcfc6b3c", @"/Views/Post/PostView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50235c36b9b2db4b1c5c5eecff89c3b7e2a14654", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_PostView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Post\PostView.cshtml"
  
    ViewData["Href"] = "#collapse" + Model.Id;
    ViewData["ID"] = "collapse" + Model.Id;

#line default
#line hidden
            BeginContext(115, 648, true);
            WriteLiteral(@"

<div class=""container"">
    <div class=""well"">
        <div class=""media"">

            <div class=""media-body"">
                <table border=""0"" class=""table"">
                    <thead>
                        <tr>
                            <th>Title</th>
                            <th>Body</th>
                            <th>Created</th>
                            <th>Likes</th>
                            <th>Comments</th>
                            <th>By</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>");
            EndContext();
            BeginContext(764, 11, false);
#line 27 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Post\PostView.cshtml"
                           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(775, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(815, 10, false);
#line 28 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Post\PostView.cshtml"
                           Write(Model.Body);

#line default
#line hidden
            EndContext();
            BeginContext(825, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(865, 15, false);
#line 29 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Post\PostView.cshtml"
                           Write(Model.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(880, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(920, 11, false);
#line 30 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Post\PostView.cshtml"
                           Write(Model.Likes);

#line default
#line hidden
            EndContext();
            BeginContext(931, 64, true);
            WriteLiteral("</td>\r\n                            <td><a data-toggle=\"collapse\"");
            EndContext();
            BeginWriteAttribute("href", " href=", 995, "", 1018, 1);
#line 31 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Post\PostView.cshtml"
WriteAttributeValue("", 1001, ViewData["Href"], 1001, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1018, 49, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-comment\"></i></a> ");
            EndContext();
            BeginContext(1068, 20, false);
#line 31 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Post\PostView.cshtml"
                                                                                                                            Write(Model.Comments.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1088, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1128, 96, false);
#line 32 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Post\PostView.cshtml"
                           Write(Html.ActionLink((string)ViewBag.Owner.Name, "Index", "User", new { id = (int)ViewBag.Owner.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 114, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n                <div");
            EndContext();
            BeginWriteAttribute("id", " id=", 1338, "", 1357, 1);
#line 36 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Post\PostView.cshtml"
WriteAttributeValue("", 1342, ViewData["ID"], 1342, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1357, 181, true);
            WriteLiteral(" class=\"panel-collapse collapse\">\r\n                    <hr class=\"divider\" />\r\n                    <p class=\"text-center\">Comments</p>\r\n                    <ul class=\"list-group\">\r\n");
            EndContext();
#line 40 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Post\PostView.cshtml"
                         foreach (var item in Model.Comments)
                        {
                            await Html.RenderPartialAsync("Partial/CommentView", item);
                        }

#line default
#line hidden
            BeginContext(1744, 107, true);
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
