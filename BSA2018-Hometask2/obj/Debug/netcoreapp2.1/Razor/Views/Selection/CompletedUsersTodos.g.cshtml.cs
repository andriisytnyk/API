#pragma checksum "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\CompletedUsersTodos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "428cb7d4895267ef6e5607ea06f26de55cf7dbfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Selection_CompletedUsersTodos), @"mvc.1.0.view", @"/Views/Selection/CompletedUsersTodos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Selection/CompletedUsersTodos.cshtml", typeof(AspNetCore.Views_Selection_CompletedUsersTodos))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"428cb7d4895267ef6e5607ea06f26de55cf7dbfc", @"/Views/Selection/CompletedUsersTodos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50235c36b9b2db4b1c5c5eecff89c3b7e2a14654", @"/Views/_ViewImports.cshtml")]
    public class Views_Selection_CompletedUsersTodos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<(int,string)>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 159, true);
            WriteLiteral("\r\n<table border=\"0\" class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\CompletedUsersTodos.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
            BeginContext(249, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(288, 10, false);
#line 16 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\CompletedUsersTodos.cshtml"
               Write(item.Item1);

#line default
#line hidden
            EndContext();
            BeginContext(298, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(327, 71, false);
#line 17 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\CompletedUsersTodos.cshtml"
               Write(Html.ActionLink(@item.Item2,"TodoView","Todo",new { id = @item.Item1 }));

#line default
#line hidden
            EndContext();
            BeginContext(398, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 19 "C:\Users\Andrii\source\repos\BSA2018-Hometask2\BSA2018-Hometask2\Views\Selection\CompletedUsersTodos.cshtml"
        }

#line default
#line hidden
            BeginContext(435, 24, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<(int,string)>> Html { get; private set; }
    }
}
#pragma warning restore 1591
