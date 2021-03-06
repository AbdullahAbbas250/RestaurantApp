#pragma checksum "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e604696dccebbb422b24788563cf32fbde330a2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Order_OrderHistory), @"mvc.1.0.view", @"/Areas/Customer/Views/Order/OrderHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e604696dccebbb422b24788563cf32fbde330a2e", @"/Areas/Customer/Views/Order/OrderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c61e2c26bafdcf5aef513a6a550fafdf62241da", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Order_OrderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderListVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn btn-light", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn btn-info active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::QadduraResturant.TagHelpers.PageLinkTagHelper __QadduraResturant_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
  
    ViewData["Title"] = "IndexAsync";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"WhiteBackGround\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h1 class=\"text-info\">Order History</h1>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 13 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
     if (Model.Orders.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-danger\">No Order History ... </p>\r\n");
#nullable restore
#line 16 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-striped border\">\r\n            <tr class=\"table-secondary\">\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayNameFor(a => a.Orders[0].OrderHeader.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayNameFor(a => a.Orders[0].OrderHeader.PickUpName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 28 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayNameFor(a => a.Orders[0].OrderHeader.appUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 31 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayNameFor(a => a.Orders[0].OrderHeader.PickUpTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayNameFor(a => a.Orders[0].OrderHeader.OrderAfterDiscount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Total Items\r\n                </th>\r\n                <th>\r\n\r\n                </th>\r\n            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
             foreach (var item in Model.Orders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayFor(a => item.OrderHeader.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayFor(a => item.OrderHeader.PickUpName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayFor(a => item.OrderHeader.appUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayFor(a => item.OrderHeader.PickUpTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayFor(a => item.OrderHeader.OrderAfterDiscount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayFor(a => item.OrderDetail.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <button type=\"button\" class=\"btn btn-success showDetails\" data-id=\"");
#nullable restore
#line 65 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
                                                                                      Write(item.OrderHeader.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\">\r\n                            <i class=\"fas fa-list-alt\"></i>Details\r\n                        </button>\r\n");
#nullable restore
#line 68 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
                         if (item.OrderHeader.status == StaticDefinition.statusSubmitted
                          || item.OrderHeader.status == StaticDefinition.StatusInProccess
                          || item.OrderHeader.status == StaticDefinition.statusCompleted
                          || item.OrderHeader.status == StaticDefinition.statusReady)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"button\" class=\"btn btn-info  showStatus\"\r\n                                    data-id=\"");
#nullable restore
#line 74 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
                                        Write(item.OrderHeader.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\">\r\n                                <i class=\"fas fa-clock\"></i>Status\r\n                            </button>\r\n");
#nullable restore
#line 77 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 81 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e604696dccebbb422b24788563cf32fbde330a2e13154", async() => {
                WriteLiteral("\r\n\r\n        ");
            }
            );
            __QadduraResturant_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::QadduraResturant.TagHelpers.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__QadduraResturant_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 84 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
__QadduraResturant_TagHelpers_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __QadduraResturant_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 85 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
__QadduraResturant_TagHelpers_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __QadduraResturant_TagHelpers_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __QadduraResturant_TagHelpers_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __QadduraResturant_TagHelpers_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __QadduraResturant_TagHelpers_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <br />\r\n");
#nullable restore
#line 93 "C:\Users\BAYAA\source\repos\ResturantProject\QadduraResturant\Areas\Customer\Views\Order\OrderHistory.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<div class=""modal fade"" id=""myModel"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog-centered modal-dialog"" style=""max-width:70%;"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-success text-light justify-content-center"">
                <h5 class=""modal-title"">
                    Order Details
                </h5>
            </div>
            <div class=""modal-body justify-content-center"" id=""myModalContent"">

            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" style=""width:20%;"" data-dismiss=""modal"">
                    Close
                </button>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" 
     id=""MyOrderStatus"" 
     tabindex=""-1"" role=""dialog"" 
     aria-hidden=""true"">
        <div class=""modal-dialog-centered modal-dialog"" 
             style=""max-width:70%;"" 
             role=""document"">
          ");
            WriteLiteral(@"      <div class=""modal-content"">
                    <div class=""modal-header bg-info text-light justify-content-center"">
                        <h5 class=""modal-title"">
                            Order Status
                        </h5>
                    </div>
                    <div class=""modal-body justify-content-center"" id=""myOrderStatusContent"">

                    </div>
                    <div class=""modal-footer"">
                        <button class=""btn btn-secondary"" style=""width:20%;"" data-dismiss=""modal"">
                            Close
                        </button>
                    </div>
                </div>
        </div>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //import { type } from ""jquery"";

        var URL = '/Customer/Order/OrderDetails';
        var URLOrderStatus = '/Customer/Order/GetOrderStatus';
        $(function () {
            $("".showDetails"").click(function () {
                var btnClicked = $(this);
                var id = btnClicked.attr('data-id');

                $.ajax({
                    type: ""GET"",
                    url: URL,
                    contentType: ""application/json;charset=utf-8"",
                    data: { ""id"": id },
                    cache: false,
                    dataType: ""html"",
                    success: function (data) {
                        $('#myModalContent').html(data);
                        $('#myModel').modal('show');
                    },
                    erroe: function () {
                        alert(""Dynamic Content Load Failed"");
                    }
                });
            });
        });
        $("".showStatus"").click(functi");
                WriteLiteral(@"on () {
            var btnClicked = $(this);
            var id = btnClicked.attr('data-id');

            $.ajax({
                type: ""GET"",
                url: URLOrderStatus,
                contentType: ""text/html;charset=utf-8"",
                data: { ""id"": id },
                cache: false,
                dataType: ""html"",
                success: function (data) {
                    $('#myOrderStatusContent').html(data);
                    $('#MyOrderStatus').modal('show');
                },
                erroe: function () {
                    alert(""Dynamic Content Load Failed"");
                }
            });
        });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderListVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
