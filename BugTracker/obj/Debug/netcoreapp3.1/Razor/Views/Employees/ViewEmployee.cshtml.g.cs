#pragma checksum "C:\Users\FAMILY\Documents\WEB-DEVELOPMENT\TrueCoders\BugTracker\BugTracker\Views\Employees\ViewEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f3a022fc121c036ce668ae725a4a8cf4d8e9e90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_ViewEmployee), @"mvc.1.0.view", @"/Views/Employees/ViewEmployee.cshtml")]
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
#line 1 "C:\Users\FAMILY\Documents\WEB-DEVELOPMENT\TrueCoders\BugTracker\BugTracker\Views\_ViewImports.cshtml"
using BugTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FAMILY\Documents\WEB-DEVELOPMENT\TrueCoders\BugTracker\BugTracker\Views\_ViewImports.cshtml"
using BugTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f3a022fc121c036ce668ae725a4a8cf4d8e9e90", @"/Views/Employees/ViewEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415cd50ac37814e1a4fb76bf7d07627084cdfa27", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_ViewEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employees>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<ul>\r\n    <li>");
#nullable restore
#line 10 "C:\Users\FAMILY\Documents\WEB-DEVELOPMENT\TrueCoders\BugTracker\BugTracker\Views\Employees\ViewEmployee.cshtml"
   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>");
#nullable restore
#line 11 "C:\Users\FAMILY\Documents\WEB-DEVELOPMENT\TrueCoders\BugTracker\BugTracker\Views\Employees\ViewEmployee.cshtml"
   Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>");
#nullable restore
#line 12 "C:\Users\FAMILY\Documents\WEB-DEVELOPMENT\TrueCoders\BugTracker\BugTracker\Views\Employees\ViewEmployee.cshtml"
   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>");
#nullable restore
#line 13 "C:\Users\FAMILY\Documents\WEB-DEVELOPMENT\TrueCoders\BugTracker\BugTracker\Views\Employees\ViewEmployee.cshtml"
   Write(Model.SecurityLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>");
#nullable restore
#line 14 "C:\Users\FAMILY\Documents\WEB-DEVELOPMENT\TrueCoders\BugTracker\BugTracker\Views\Employees\ViewEmployee.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employees> Html { get; private set; }
    }
}
#pragma warning restore 1591
