#pragma checksum "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Views\Shared\_PolicyPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "667820e3d37afc0a8275515b831c34ff26f38a71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PolicyPartial), @"mvc.1.0.view", @"/Views/Shared/_PolicyPartial.cshtml")]
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
#line 1 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Views\_ViewImports.cshtml"
using DSLTD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Views\_ViewImports.cshtml"
using DSLTD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Views\_ViewImports.cshtml"
using DSLTD.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"667820e3d37afc0a8275515b831c34ff26f38a71", @"/Views/Shared/_PolicyPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f50de37e4efc05d5f1441f99caba87a8e97ec9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__PolicyPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Policy>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"modal-header\">\r\n    <h5 class=\"modal-title\" id=\"PolicyModal\">Refund policy</h5>\r\n    <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"modal\" aria-label=\"Close\"></button>\r\n</div>\r\n<div class=\"modal-body\">\r\n    \r\n    ");
#nullable restore
#line 10 "C:\Users\SWIFT\Desktop\DSTLDProject\DSLTD\DSLTD\Views\Shared\_PolicyPartial.cshtml"
Write(Html.Raw(Model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Policy> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
