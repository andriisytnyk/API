#pragma checksum "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Todo\TodoView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "123dfc33f69ed1bbd6625831a20bfe9485eac9da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_TodoView), @"mvc.1.0.view", @"/Views/Todo/TodoView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/TodoView.cshtml", typeof(AspNetCore.Views_Todo_TodoView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"123dfc33f69ed1bbd6625831a20bfe9485eac9da", @"/Views/Todo/TodoView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50235c36b9b2db4b1c5c5eecff89c3b7e2a14654", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_TodoView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Todo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 562, true);
            WriteLiteral(@"

<div class=""container"">
    <div class=""well"">
        <div class=""media"">

            <div class=""media-body"">
                <table border=""0"" class=""table"">
                    <thead>
                        <tr>
                            <th>Bane</th>
                            <th>Created</th>
                            <th>IsComplete</th>
                            <th>By</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>");
            EndContext();
            BeginContext(576, 10, false);
#line 20 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Todo\TodoView.cshtml"
                           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(586, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(626, 15, false);
#line 21 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Todo\TodoView.cshtml"
                           Write(Model.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(641, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 22 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Todo\TodoView.cshtml"
                             if (Model.IsComplete)
                            {

#line default
#line hidden
            BeginContext(731, 249, true);
            WriteLiteral("                                <td>\r\n                                    <a href=\"#\" class=\"btn btn-success btn-sm active\">\r\n                                        <span class=\"glyphicon glyphicon-ok\"></span>\r\n                                </td>");
            EndContext();
#line 27 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Todo\TodoView.cshtml"
                                     }
                            else
                            {

#line default
#line hidden
            BeginContext(1048, 252, true);
            WriteLiteral("                                <td>\r\n                                    <a href=\"#\" class=\"btn btn-danger btn-sm active\">\r\n                                        <span class=\"glyphicon glyphicon-remove\"></span>\r\n                                </td>");
            EndContext();
#line 33 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Todo\TodoView.cshtml"
                                     }

#line default
#line hidden
            BeginContext(1303, 34, true);
            WriteLiteral("\r\n                            <td>");
            EndContext();
            BeginContext(1338, 96, false);
#line 35 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Todo\TodoView.cshtml"
                           Write(Html.ActionLink((string)ViewBag.Owner.Name, "Index", "User", new { id = (int)ViewBag.Owner.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 150, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Todo> Html { get; private set; }
    }
}
#pragma warning restore 1591
