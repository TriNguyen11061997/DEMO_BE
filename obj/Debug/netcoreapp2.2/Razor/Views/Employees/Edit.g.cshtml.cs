#pragma checksum "C:\Users\Admin\Desktop\DACN\DEMO_2\Views\Employees\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de914982161224a1ce49fa4f604cdf291f01abb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Edit), @"mvc.1.0.view", @"/Views/Employees/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Edit.cshtml", typeof(AspNetCore.Views_Employees_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de914982161224a1ce49fa4f604cdf291f01abb8", @"/Views/Employees/Edit.cshtml")]
    public class Views_Employees_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DEMO_2.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\DACN\DEMO_2\Views\Employees\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(73, 1309, true);
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Employee</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""ID"" />
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""BirthDay"" class=""control-label""></label>
                <input asp-for=""BirthDay"" class=""form-control"" />
                <span asp-validation-for=""BirthDay"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Desc"" class=""control-label""></label>
                <input asp-for=""Desc"" class=""form-control"" />
                <span asp-validation-for=""Desc"" ");
            WriteLiteral(@"class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1400, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 43 "C:\Users\Admin\Desktop\DACN\DEMO_2\Views\Employees\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
