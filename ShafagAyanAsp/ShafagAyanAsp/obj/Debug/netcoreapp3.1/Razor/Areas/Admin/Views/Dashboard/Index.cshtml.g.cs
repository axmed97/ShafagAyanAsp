#pragma checksum "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d00ac25c252aabdf30dc5288147196336ff6844"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\_ViewImports.cshtml"
using ShafagAyanAsp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\_ViewImports.cshtml"
using ShafagAyanAsp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\_ViewImports.cshtml"
using ShafagAyanAsp.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d00ac25c252aabdf30dc5288147196336ff6844", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbfe86664f518e88d07c81781780765c24627cab", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["activeTab"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Title", async() => {
                WriteLiteral("\r\n    <h4 class=\"page-title text-uppercase font-medium font-20\">Dashboard</h4>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""col-lg-4 col-sm-6 col-xs-12"">
    <div class=""white-box analytics-info"">
        <h3 class=""box-title"">Slider</h3>
        <ul class=""list-inline two-part d-flex align-items-center mb-0"">
            <li>
                <i style=""color: #7ace4c;"" class=""far fa-file-image fa-2x""></i> 
            </li>
            <li class=""ml-auto""><span class=""counter text-success"">");
#nullable restore
#line 18 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Dashboard\Index.cshtml"
                                                              Write(Model.sliders.ToList().Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
        </ul>
    </div>
</div>

<div class=""col-lg-4 col-sm-6 col-xs-12"">
    <div class=""white-box analytics-info"">
        <h3 class=""box-title"">Image</h3>
        <ul class=""list-inline two-part d-flex align-items-center mb-0"">
            <li>
                <i style=""color: #707cd2;"" class=""far fa-images fa-2x""></i>
            </li>
            <li class=""ml-auto""><span class=""counter text-purple"">");
#nullable restore
#line 30 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Dashboard\Index.cshtml"
                                                             Write(Model.images.ToList().Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
        </ul>
    </div>
</div>

<div class=""col-lg-4 col-sm-6 col-xs-12"">
    <div class=""white-box analytics-info"">
        <h3 class=""box-title"">Video</h3>
        <ul class=""list-inline two-part d-flex align-items-center mb-0"">
            <li>
                <i style=""color: #2cabe3;"" class=""fab fa-youtube fa-2x""></i>
            </li>
            <li class=""ml-auto"">
                <span class=""counter text-info"">");
#nullable restore
#line 43 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Dashboard\Index.cshtml"
                                           Write(Model.videos.ToList().Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591