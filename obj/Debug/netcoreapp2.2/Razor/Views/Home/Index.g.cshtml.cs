#pragma checksum "C:\git\TestAppConfig\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18f6dc05a62be315e380bf2a0b23b09cc817affd"
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
#line 1 "C:\git\TestAppConfig\Views\_ViewImports.cshtml"
using TestAppConfig;

#line default
#line hidden
#line 2 "C:\git\TestAppConfig\Views\_ViewImports.cshtml"
using TestAppConfig.Models;

#line default
#line hidden
#line 1 "C:\git\TestAppConfig\Views\Home\Index.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18f6dc05a62be315e380bf2a0b23b09cc817affd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e35e05e45b03b1e8e02889d01abe27a0f020ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 49, true);
            WriteLiteral("\r\n<style>\r\n    body {\r\n        background-color: ");
            EndContext();
            BeginContext(131, 49, false);
#line 6 "C:\git\TestAppConfig\Views\Home\Index.cshtml"
                     Write(Configuration["TestApp:Settings:BackgroundColor"]);

#line default
#line hidden
            EndContext();
            BeginContext(180, 34, true);
            WriteLiteral("\r\n    }\r\n    h1 {\r\n        color: ");
            EndContext();
            BeginContext(215, 43, false);
#line 9 "C:\git\TestAppConfig\Views\Home\Index.cshtml"
          Write(Configuration["TestApp:Settings:FontColor"]);

#line default
#line hidden
            EndContext();
            BeginContext(258, 22, true);
            WriteLiteral(";\r\n        font-size: ");
            EndContext();
            BeginContext(281, 42, false);
#line 10 "C:\git\TestAppConfig\Views\Home\Index.cshtml"
              Write(Configuration["TestApp:Settings:FontSize"]);

#line default
#line hidden
            EndContext();
            BeginContext(323, 26, true);
            WriteLiteral(";\r\n    }\r\n</style>\r\n\r\n<h1>");
            EndContext();
            BeginContext(350, 41, false);
#line 14 "C:\git\TestAppConfig\Views\Home\Index.cshtml"
Write(Configuration["TestApp:Settings:Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(391, 5, true);
            WriteLiteral("</h1>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
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