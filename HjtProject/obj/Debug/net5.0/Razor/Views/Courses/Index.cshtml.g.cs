#pragma checksum "C:\Users\aashq\source\repos\HjtProject\HjtProject\Views\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "388ac48ad19839a03b4e14932784478aab92a175"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Index), @"mvc.1.0.view", @"/Views/Courses/Index.cshtml")]
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
#line 1 "C:\Users\aashq\source\repos\HjtProject\HjtProject\Views\_ViewImports.cshtml"
using HjtProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aashq\source\repos\HjtProject\HjtProject\Views\_ViewImports.cshtml"
using HjtProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\aashq\source\repos\HjtProject\HjtProject\Views\Courses\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"388ac48ad19839a03b4e14932784478aab92a175", @"/Views/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87b48c50175f9e0ee6dd35ec44739706d60a3151", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\aashq\source\repos\HjtProject\HjtProject\Views\Courses\Index.cshtml"
  

    var emails = (List<IdentityUser>)ViewData["users"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\aashq\source\repos\HjtProject\HjtProject\Views\Courses\Index.cshtml"
  
    if (emails == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3> You have no users </h3>\r\n");
#nullable restore
#line 11 "C:\Users\aashq\source\repos\HjtProject\HjtProject\Views\Courses\Index.cshtml"
    }
    else
    {
        foreach (var item in emails)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                ");
#nullable restore
#line 17 "C:\Users\aashq\source\repos\HjtProject\HjtProject\Views\Courses\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                ");
#nullable restore
#line 18 "C:\Users\aashq\source\repos\HjtProject\HjtProject\Views\Courses\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n");
#nullable restore
#line 20 "C:\Users\aashq\source\repos\HjtProject\HjtProject\Views\Courses\Index.cshtml"

        }
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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