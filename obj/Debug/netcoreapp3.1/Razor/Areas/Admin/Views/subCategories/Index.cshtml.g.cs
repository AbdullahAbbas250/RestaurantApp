#pragma checksum "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Admin\Views\subCategories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c3f0ec8b12ea62e295fb12d4d59953630c02194"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_subCategories_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/subCategories/Index.cshtml")]
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
#line 1 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Admin\Views\_ViewImports.cshtml"
using QadduraResturant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Admin\Views\_ViewImports.cshtml"
using QadduraResturant.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Admin\Views\_ViewImports.cshtml"
using QadduraResturant.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c3f0ec8b12ea62e295fb12d4d59953630c02194", @"/Areas/Admin/Views/subCategories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b508115481ffe6ab94489f146eb80955cc311b4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_subCategories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<subCategory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_OperationBasic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Admin\Views\subCategories\Index.cshtml"
  
    ViewData["Title"] = "IndexAsync";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"WhiteBackGround\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h1 class=\"text-info\">Sub Categories</h1>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c3f0ec8b12ea62e295fb12d4d59953630c021944581", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Admin\Views\subCategories\Index.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-danger\">No Categories ... </p>\r\n");
#nullable restore
#line 18 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Admin\Views\subCategories\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-striped border\">\r\n            <tr class=\"table-secondary\">\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Admin\Views\subCategories\Index.cshtml"
               Write(Html.DisplayNameFor(a => a.name));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Admin\Views\subCategories\Index.cshtml"
               Write(Html.DisplayNameFor(a => a.category.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                </th>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Admin\Views\subCategories\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Admin\Views\subCategories\Index.cshtml"
           Write(Html.DisplayFor(a => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Admin\Views\subCategories\Index.cshtml"
           Write(Html.DisplayFor(a => item.category.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"width:150px\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c3f0ec8b12ea62e295fb12d4d59953630c021948190", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 42 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Admin\Views\subCategories\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Admin\Views\subCategories\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 49 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Admin\Views\subCategories\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<subCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
