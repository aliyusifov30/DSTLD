#pragma checksum "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5750c443f0b40962df01fbd34f1fd7e816a9bbf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BasketPartial), @"mvc.1.0.view", @"/Views/Shared/_BasketPartial.cshtml")]
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
#line 1 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\_ViewImports.cshtml"
using DSLTD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\_ViewImports.cshtml"
using DSLTD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\_ViewImports.cshtml"
using DSLTD.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5750c443f0b40962df01fbd34f1fd7e816a9bbf5", @"/Views/Shared/_BasketPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f50de37e4efc05d5f1441f99caba87a8e97ec9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BasketPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketItemViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
  
    Layout = null;
    ViewBag.TotalAmount = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""title"">
    <div class=""container"">
        <div class=""row d-flex justify-content-center"">
            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6 col-6"">
                <span>Cart</span>
            </div>
            <div class=""header-side-bar-card-x-btn col-xl-6 col-lg-6 col-md-6 col-sm-6 col-6"">
                <a");
            BeginWriteAttribute("href", " href=\"", 440, "\"", 447, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <i class=""fas fa-times""></i>
                </a>
            </div>
        </div>
    </div>
</div>
<div class=""sub-title"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <span>You are eligible for free shipping!</span>
            </div>
        </div>
    </div>
</div>

");
#nullable restore
#line 32 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"empty\">\r\n        <p>Your cart is empty</p>\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"product-sub-detail scroll-man\" data-subtitle=\"");
#nullable restore
#line 40 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                                         Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 43 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                 foreach (var item in Model)
                {
                    ViewBag.TotalAmount += item.SalePrice * item.Count;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"product-item d-flex\">\r\n                        <div class=\"image-side col-lg-4 col-md-4 col-sm-4 col-4\">\r\n                            <div class=\"image\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5750c443f0b40962df01fbd34f1fd7e816a9bbf57147", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1441, "~/uploads/products/", 1441, 19, true);
#nullable restore
#line 49 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
AddHtmlAttributeValue("", 1460, item.PosterImage, 1460, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"detail-side col-lg-8 col-md-8 col-sm-8 col-8\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1670, "\"", 1677, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"detail-side-title\">");
#nullable restore
#line 53 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in ");
#nullable restore
#line 53 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                                                           Write(item.ColorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <div class=\"size\">\r\n                                <span>");
#nullable restore
#line 55 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                 Write(item.SizeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"price\">\r\n                                <span class=\"text-line red-text\">");
#nullable restore
#line 58 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                                            Write(item.SalePrice.ToString("#.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"text-dark\">");
#nullable restore
#line 59 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                                    Write((item.SalePrice - (item.SalePrice / 100) * item.Discount).ToString("#.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                            <div class=""row"">
                                <div class=""button-item col-lg-5 col-md-5 col-sm-5 col-5"">
                                    <div class=""button"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2459, "\"", 2466, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"basket-minus\" data-id=\"");
#nullable restore
#line 64 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                                                            Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-sizeId=\"");
#nullable restore
#line 64 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                                                                                          Write(item.SizeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-colorId=\"");
#nullable restore
#line 64 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                                                                                                                      Write(item.ColorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                            <i class=\"fas fa-minus\"></i>\r\n                                        </a>\r\n                                        <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2751, "\"", 2770, 1);
#nullable restore
#line 67 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
WriteAttributeValue("", 2759, item.Count, 2759, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2816, "\"", 2823, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"basket-plus\" data-id=\"");
#nullable restore
#line 68 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                                                           Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-sizeId=\"");
#nullable restore
#line 68 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                                                                                         Write(item.SizeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-colorId=\"");
#nullable restore
#line 68 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                                                                                                                     Write(item.ColorId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                            <i class=""fas fa-plus""></i>
                                        </a>
                                    </div>
                                </div>
                                <div class=""remove-item col-lg-7 col-md-7 col-sm-7 col-7"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 3262, "\"", 3269, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"remove-basket-item\" data-id=\"");
#nullable restore
#line 74 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                                                              Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-sizeId=\"");
#nullable restore
#line 74 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                                                                                            Write(item.SizeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-colorId=\"");
#nullable restore
#line 74 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                                                                                                                        Write(item.ColorId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-check=""true"">
                                        Remove
                                        <div class=""underline-hover"">

                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 84 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""checkout-side"">
        <div class=""container"">
            <div class=""row"">
                <div class=""text-item col-lg-12"">
                    <span>Shipping & taxes calculated at checkout</span>
                </div>
                <div class=""checkout-button col-lg-12 btn-black-white"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5750c443f0b40962df01fbd34f1fd7e816a9bbf516846", async() => {
                WriteLiteral("\r\n                        <span class=\"text\">CHECKOUT</span> <span class=\"circle\"></span> <span class=\"price\">$");
#nullable restore
#line 96 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
                                                                                                        Write(ViewBag.TotalAmount.ToString("#.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 102 "C:\Users\SWIFT\Desktop\new\BackEnd\DSTLDBackEnd\DSLTD\DSLTD\Views\Shared\_BasketPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
