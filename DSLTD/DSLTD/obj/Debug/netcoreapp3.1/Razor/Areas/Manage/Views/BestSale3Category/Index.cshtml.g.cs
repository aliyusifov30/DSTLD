#pragma checksum "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Areas\Manage\Views\BestSale3Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75374ecf26a25c18352675a7f2e50589586643c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_BestSale3Category_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/BestSale3Category/Index.cshtml")]
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
#line 2 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Areas\Manage\Views\_ViewImports.cshtml"
using DSLTD.Areas.Manage.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Areas\Manage\Views\_ViewImports.cshtml"
using DSLTD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75374ecf26a25c18352675a7f2e50589586643c1", @"/Areas/Manage/Views/BestSale3Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eba4e1bcdc47d4d2d04f1c0bb8ad23f46d48f39f", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Manage_Views_BestSale3Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BestSaleCategory>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px;height:200px;object-fit:cover;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Areas\Manage\Views\BestSale3Category\Index.cshtml"
   
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-12 d-flex"">
                    <h1 class=""align-items-center"" style=""width:100%;"">Home Categories</h1>
");
            WriteLiteral(@"                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <table class=""table table-striped projects"">
                                <thead class=""thead-dark"">
                                    <tr>
                                        <th scope=""col"">No</th>
                                        <th scope=""col"">Title</th>
                                        <th scope=""col"">Category</th>
                                        <th scope=""col"">Image</th>
                                        <th scope=""col"">CreatedAt</th>
                                        <th scope=""col"">ModifiedAt</th>
                                        <th scope=""col"">
               ");
            WriteLiteral("                             Actions\r\n                                        </th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Areas\Manage\Views\BestSale3Category\Index.cshtml"
                                     foreach (BestSaleCategory item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\" style=\" vertical-align: middle;\">");
#nullable restore
#line 48 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Areas\Manage\Views\BestSale3Category\Index.cshtml"
                                                                                     Write(count++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th scope=\"row\" style=\" vertical-align: middle;\">");
#nullable restore
#line 49 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Areas\Manage\Views\BestSale3Category\Index.cshtml"
                                                                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th scope=\"row\" style=\" vertical-align: middle;\">\r\n");
#nullable restore
#line 51 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Areas\Manage\Views\BestSale3Category\Index.cshtml"
                                             foreach (Category category in ViewBag.Category)
                                            {
                                                if (category.Id == item.CategoryId)
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Areas\Manage\Views\BestSale3Category\Index.cshtml"
                                               Write(category.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Areas\Manage\Views\BestSale3Category\Index.cshtml"
                                                                  
                                                }
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </th>\r\n                                        <td>\r\n                                            <div class=\"img-box\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "75374ecf26a25c18352675a7f2e50589586643c19090", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2981, "~/uploads/products/", 2981, 19, true);
#nullable restore
#line 61 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Areas\Manage\Views\BestSale3Category\Index.cshtml"
AddHtmlAttributeValue("", 3000, item.Image, 3000, 11, false);

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
            WriteLiteral("\r\n                                            </div>\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 64 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Areas\Manage\Views\BestSale3Category\Index.cshtml"
                                       Write(item.CreatedAt.ToString("dd:MM:yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 65 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Areas\Manage\Views\BestSale3Category\Index.cshtml"
                                       Write(item.ModifiedAt.ToString("dd:MM:yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75374ecf26a25c18352675a7f2e50589586643c111587", async() => {
                WriteLiteral("\r\n                                                <i class=\"bi bi-pencil-square\"></i>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Areas\Manage\Views\BestSale3Category\Index.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 75 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Areas\Manage\Views\BestSale3Category\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>
    <!-- /.content -->
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/sweetalert2@10/dist/sweetalert2.all.min.js\"></script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BestSaleCategory>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
