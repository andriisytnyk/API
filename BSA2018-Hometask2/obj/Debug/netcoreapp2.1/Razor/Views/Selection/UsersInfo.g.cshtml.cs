#pragma checksum "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06606f9d540325a19199f616ab5e6562b040414c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Selection_UsersInfo), @"mvc.1.0.view", @"/Views/Selection/UsersInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Selection/UsersInfo.cshtml", typeof(AspNetCore.Views_Selection_UsersInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06606f9d540325a19199f616ab5e6562b040414c", @"/Views/Selection/UsersInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50235c36b9b2db4b1c5c5eecff89c3b7e2a14654", @"/Views/_ViewImports.cshtml")]
    public class Views_Selection_UsersInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(User user, Post lastPost, int comments, int todos, Post popularCommented, Post likedPost)>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(99, 387, true);
            WriteLiteral(@"
<table border=""0"" class=""table"">
    <thead>
        <tr>
            <th>User</th>
            <th>Last post</th>
            <th>Comments to last post</th>
            <th>Todos</th>
            <th>Popular commented</th>
            <th>The most liked post</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td><a data-toggle=""collapse"" href=""#user"">");
            EndContext();
            BeginContext(487, 15, false);
#line 16 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
                                                  Write(Model.user.Name);

#line default
#line hidden
            EndContext();
            BeginContext(502, 71, true);
            WriteLiteral("</a> </td>\r\n            <td><a data-toggle=\"collapse\" href=\"#lastpost\">");
            EndContext();
            BeginContext(574, 20, false);
#line 17 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
                                                      Write(Model.lastPost.Title);

#line default
#line hidden
            EndContext();
            BeginContext(594, 28, true);
            WriteLiteral("</a> </td>\r\n            <td>");
            EndContext();
            BeginContext(623, 14, false);
#line 18 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
           Write(Model.comments);

#line default
#line hidden
            EndContext();
            BeginContext(637, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(661, 11, false);
#line 19 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
           Write(Model.todos);

#line default
#line hidden
            EndContext();
            BeginContext(672, 67, true);
            WriteLiteral("</td>\r\n            <td><a data-toggle=\"collapse\" href=\"#commented\">");
            EndContext();
            BeginContext(740, 28, false);
#line 20 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
                                                       Write(Model.popularCommented.Title);

#line default
#line hidden
            EndContext();
            BeginContext(768, 68, true);
            WriteLiteral("</a> </td>\r\n            <td><a data-toggle=\"collapse\" href=\"#liked\">");
            EndContext();
            BeginContext(837, 21, false);
#line 21 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
                                                   Write(Model.likedPost.Title);

#line default
#line hidden
            EndContext();
            BeginContext(858, 478, true);
            WriteLiteral(@"</a> </td>
        </tr>
    </tbody>
</table>


    <table border=""0"" id=""user"" class=""panel-collapse collapse table"">
        <thead>
            <tr>
                <th>Avatar</th>
                <th>Name</th>
                <th>Email</th>
                <th>Created</th>
                <th>Popular commented</th>
                <th>The most liked post</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=", 1336, "", 1359, 1);
#line 40 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
WriteAttributeValue("", 1341, Model.user.Avatar, 1341, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1359, 29, true);
            WriteLiteral("> </td>\r\n                <td>");
            EndContext();
            BeginContext(1389, 77, false);
#line 41 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
               Write(Html.ActionLink(Model.user.Name, "Index", "User", new { id = Model.user.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(1495, 16, false);
#line 42 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
               Write(Model.user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1511, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1539, 20, false);
#line 43 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
               Write(Model.user.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(1559, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 44 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
                 if (@Model.user.Posts.Count > 0)
                {

#line default
#line hidden
            BeginContext(1636, 41, true);
            WriteLiteral("                    <td class=\"col-sm-9\">");
            EndContext();
            BeginContext(1678, 97, false);
#line 46 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
                                    Write(Html.ActionLink(@Model.user.Posts.Count.ToString(), "Index", "Post", new { id = @Model.user.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1775, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 47 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1842, 41, true);
            WriteLiteral("                    <td class=\"col-sm-9\">");
            EndContext();
            BeginContext(1884, 33, false);
#line 50 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
                                    Write(Model.user.Posts.Count.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1917, 5, true);
            WriteLiteral("</td>");
            EndContext();
#line 50 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
                                                                                }

#line default
#line hidden
            BeginContext(1925, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 51 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
                 if (@Model.user.Todos.Count > 0)
                {

#line default
#line hidden
            BeginContext(1995, 41, true);
            WriteLiteral("                    <td class=\"col-sm-9\">");
            EndContext();
            BeginContext(2037, 97, false);
#line 53 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
                                    Write(Html.ActionLink(@Model.user.Todos.Count.ToString(), "Index", "Post", new { id = @Model.user.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2134, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 54 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2201, 41, true);
            WriteLiteral("                    <td class=\"col-sm-9\">");
            EndContext();
            BeginContext(2243, 33, false);
#line 57 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
                                    Write(Model.user.Todos.Count.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2276, 5, true);
            WriteLiteral("</td>");
            EndContext();
#line 57 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\UsersInfo.cshtml"
                                                                                }

#line default
#line hidden
            BeginContext(2284, 53, true);
            WriteLiteral("            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(User user, Post lastPost, int comments, int todos, Post popularCommented, Post likedPost)> Html { get; private set; }
    }
}
#pragma warning restore 1591
