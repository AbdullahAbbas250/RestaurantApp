#pragma checksum "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b111e7835bdedb550f80d69e6e86174f60e23681"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\_ViewImports.cshtml"
using QadduraResturant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\_ViewImports.cshtml"
using QadduraResturant.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\_ViewImports.cshtml"
using QadduraResturant.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\_ViewImports.cshtml"
using QadduraResturant.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b111e7835bdedb550f80d69e6e86174f60e23681", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c61e2c26bafdcf5aef513a6a550fafdf62241da", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<br />
<br />
<div class=""WhiteBackGround container"">
    <ul id=""Menu-Filter"" class=""menu-filter-list list-inline text-center justify-content-center"">
        <li class=""active btn btn-secondary ml-1 mr-1""  data-filter="".Allcategories"" >Show All</li>
");
#nullable restore
#line 12 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
         foreach (var category in Model.Category)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"btn btn-secondary ml-1 mr-1\"  data-filter=\".");
#nullable restore
#line 14 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
                                                              Write(category.name.Replace(" ",string.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" >");
#nullable restore
#line 14 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
                                                                                                         Write(category.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 15 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 17 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
     foreach (var item  in Model.Category)
    {
        var menuItem = Model.MenuItem.Where(m => m.Category.name.Equals(item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n");
#nullable restore
#line 21 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
             if (menuItem.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 830, "\"", 896, 4);
            WriteAttributeValue("", 838, "col-12", 838, 6, true);
#nullable restore
#line 23 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 844, item.name.Replace(" ",string.Empty), 845, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 881, "Allcategories", 882, 14, true);
            WriteAttributeValue(" ", 895, "", 896, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"row\">\r\n                        <h3 class=\"text-success\">\r\n                            ");
#nullable restore
#line 26 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
                       Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h3>\r\n                    </div>\r\n");
#nullable restore
#line 29 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
                     foreach (var itemCollection in menuItem)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""border border-info rounded col-12"" style=""margin-top:10px;margin-bottom:10px;padding:10px;"">
                            <div class=""row"">
                                <div class=""col-md-3 col-sm-12 "">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 1459, "\"", 1486, 1);
#nullable restore
#line 34 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 1465, itemCollection.image, 1465, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""99%"" style=""border-radius:5px;border:1px solid #bbb9b9"" />
                                </div>
                                <div class=""col-md-9 col-sm-12"">
                                    <div class=""row pr-3"">
                                        <div class=""col-8"">
                                            <label class=""text-primary"" style=""font-size:21px;"">
                                                ");
#nullable restore
#line 40 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
                                           Write(itemCollection.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </label>
                                        </div>
                                        <div class=""col-4 text-right"" style=""color:maroon;"">
                                            <h4>
                                                $ ");
#nullable restore
#line 45 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
                                             Write(itemCollection.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </h4>
                                        </div>


                                    </div>
                                    <div class=""row col-12 text-justify d-none d-md-block"">
                                        <p>
                                            ");
#nullable restore
#line 53 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
                                       Write(Html.Raw(@itemCollection.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                    <div class=\"col-md-3 col-sm-12 offset-md-9 text-right\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b111e7835bdedb550f80d69e6e86174f60e2368111050", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
                                                                      WriteLiteral(itemCollection.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 62 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 64 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 66 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Home\Index.cshtml"
                                   
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
<script>
    $(document).ready(
        function ($) {
            $(""#Menu-Filter li"").click(
                function () {
                    $(""#Menu-Filter li"").removeClass(""active"");
                    $(this).addClass(""active"");
                    var selectedFiter = $(this).data(""filter"");
                    $("".Allcategories"").fadeOut();
                    setTimeout(function() {
                        $(selectedFiter).slideDown();
                    }, 100);

                }
            )
        }
    );

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
