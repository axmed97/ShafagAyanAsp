#pragma checksum "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72d9e302ffd9b11ea4d7be081215b8c58a4f6f81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Image_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Image/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d9e302ffd9b11ea4d7be081215b8c58a4f6f81", @"/Areas/Admin/Views/Image/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbfe86664f518e88d07c81781780765c24627cab", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Image_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Images>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Image", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Ayan Shafag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-gall", new global::Microsoft.AspNetCore.Html.HtmlString("myImages"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("venobox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["activeTab"] = "Image";
    var allImageCount = (int)ViewData["allImageCount"];
    var activePage = (int)ViewData["activePage"];
    var allPageCount = (int)(Math.Ceiling(((decimal)allImageCount / 4)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Title", async() => {
                WriteLiteral("\r\n    <h4 class=\"page-title text-uppercase font-medium font-20\">Image</h4>\r\n");
            }
            );
            WriteLiteral(@"
<a href=""/Admin/Image/Create"" class=""btn btn-outline-dark btn-block btn-lg text-capitalize"">Create</a>

<table class=""table table-bordered table-striped table-hover text-center"">
    <thead>
        <tr>
            <th></th>
            <th>Images</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 802, "\"", 835, 2);
            WriteAttributeValue("", 809, "/Admin/Image/Edit/", 809, 18, true);
#nullable restore
#line 28 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
WriteAttributeValue("", 827, item.Id, 827, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block btn-outline-warning\">\r\n                        <i class=\"fas fa-pencil-alt fa-2x\"></i>\r\n                    </a>\r\n");
#nullable restore
#line 31 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
                     if (Model.ToList().Count > 1 || allImageCount > 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72d9e302ffd9b11ea4d7be081215b8c58a4f6f818545", async() => {
                WriteLiteral("\r\n                            <button class=\"btn btn-outline-danger btn-lg btn-block\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1277, "\"", 1353, 10);
                WriteAttributeValue("", 1287, "return", 1287, 6, true);
                WriteAttributeValue(" ", 1293, "confirm(\'Are", 1294, 13, true);
                WriteAttributeValue(" ", 1306, "you", 1307, 4, true);
                WriteAttributeValue(" ", 1310, "sure", 1311, 5, true);
                WriteAttributeValue(" ", 1315, "to", 1316, 3, true);
                WriteAttributeValue(" ", 1318, "delete", 1319, 7, true);
                WriteAttributeValue(" ", 1325, "this", 1326, 5, true);
                WriteAttributeValue(" ", 1330, "image:", 1331, 7, true);
#nullable restore
#line 34 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
WriteAttributeValue(" ", 1337, item.Image, 1338, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1351, "\')", 1351, 2, true);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-trash-alt fa-2x\"></i></button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72d9e302ffd9b11ea4d7be081215b8c58a4f6f8113038", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "72d9e302ffd9b11ea4d7be081215b8c58a4f6f8113318", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1628, "~/image/", 1628, 8, true);
#nullable restore
#line 40 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
AddHtmlAttributeValue("", 1636, item.Image, 1636, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1571, "~/image/", 1571, 8, true);
#nullable restore
#line 39 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
AddHtmlAttributeValue("", 1579, item.Image, 1579, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<nav aria-label=\"Page navigation example\" style=\"margin: auto;\">\r\n    <ul class=\"pagination\">\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 1892, "\"", 1944, 2);
            WriteAttributeValue("", 1900, "page-item", 1900, 9, true);
#nullable restore
#line 50 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
WriteAttributeValue(" ", 1909, activePage == 1 ? "d-none" : "", 1910, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1980, "\"", 2026, 2);
            WriteAttributeValue("", 1987, "/Admin/Image/Index?page=", 1987, 24, true);
#nullable restore
#line 51 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
WriteAttributeValue("", 2011, activePage-1, 2011, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                <span aria-hidden=\"true\">&laquo;</span>\r\n                <span class=\"sr-only\">Previous</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 56 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
         for (int i = 1; i <= allPageCount; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 2273, "\"", 2325, 2);
            WriteAttributeValue("", 2281, "page-item", 2281, 9, true);
#nullable restore
#line 58 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
WriteAttributeValue(" ", 2290, activePage == i ? "active" : "", 2291, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2347, "\"", 2380, 2);
            WriteAttributeValue("", 2354, "/Admin/Image/Index?page=", 2354, 24, true);
#nullable restore
#line 58 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
WriteAttributeValue("", 2378, i, 2378, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 58 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
                                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 59 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li");
            BeginWriteAttribute("class", " class=\"", 2417, "\"", 2480, 2);
            WriteAttributeValue("", 2425, "page-item", 2425, 9, true);
#nullable restore
#line 60 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
WriteAttributeValue(" ", 2434, activePage == allPageCount ? "d-none" : "", 2435, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2516, "\"", 2562, 2);
            WriteAttributeValue("", 2523, "/Admin/Image/Index?page=", 2523, 24, true);
#nullable restore
#line 61 "C:\Users\Axmed\source\repos\ShafagAyanAsp\ShafagAyanAsp\Areas\Admin\Views\Image\Index.cshtml"
WriteAttributeValue("", 2547, activePage+1, 2547, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                <span aria-hidden=\"true\">&raquo;</span>\r\n                <span class=\"sr-only\">Next</span>\r\n            </a>\r\n        </li>\r\n    </ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Images>> Html { get; private set; }
    }
}
#pragma warning restore 1591