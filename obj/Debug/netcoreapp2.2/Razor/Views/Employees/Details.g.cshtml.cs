#pragma checksum "C:\Users\Admin\Desktop\DACN\DEMO_2\Views\Employees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6dc343669beca944aed18c145b4c377f66a1f79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Details), @"mvc.1.0.view", @"/Views/Employees/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Details.cshtml", typeof(AspNetCore.Views_Employees_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6dc343669beca944aed18c145b4c377f66a1f79", @"/Views/Employees/Details.cshtml")]
    public class Views_Employees_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DEMO_2.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\DACN\DEMO_2\Views\Employees\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(76, 131, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(208, 40, false);
#line 14 "C:\Users\Admin\Desktop\DACN\DEMO_2\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(248, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(312, 36, false);
#line 17 "C:\Users\Admin\Desktop\DACN\DEMO_2\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(348, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(411, 44, false);
#line 20 "C:\Users\Admin\Desktop\DACN\DEMO_2\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BirthDay));

#line default
#line hidden
            EndContext();
            BeginContext(455, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(519, 40, false);
#line 23 "C:\Users\Admin\Desktop\DACN\DEMO_2\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.BirthDay));

#line default
#line hidden
            EndContext();
            BeginContext(559, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(622, 40, false);
#line 26 "C:\Users\Admin\Desktop\DACN\DEMO_2\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desc));

#line default
#line hidden
            EndContext();
            BeginContext(662, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(726, 36, false);
#line 29 "C:\Users\Admin\Desktop\DACN\DEMO_2\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desc));

#line default
#line hidden
            EndContext();
            BeginContext(762, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 829, "\"", 853, 1);
#line 34 "C:\Users\Admin\Desktop\DACN\DEMO_2\Views\Employees\Details.cshtml"
WriteAttributeValue("", 844, Model.ID, 844, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(854, 65, true);
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DEMO_2.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
