#pragma checksum "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\UpdateJob.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c812e63abbbc8f951f8d0e367585b76066fa6bcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_UpdateJob), @"mvc.1.0.view", @"/Views/Job/UpdateJob.cshtml")]
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
#line 1 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\_ViewImports.cshtml"
using Demo_ProductV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\_ViewImports.cshtml"
using Demo_ProductV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c812e63abbbc8f951f8d0e367585b76066fa6bcb", @"/Views/Job/UpdateJob.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6f8ed1d814826b0325b7edc2445af88a4a60689", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Job_UpdateJob : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntitiyLayer.Concrete.Job>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\UpdateJob.cshtml"
  
    ViewData["Title"] = "UpdateJob";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c812e63abbbc8f951f8d0e367585b76066fa6bcb3897", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 10 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\UpdateJob.cshtml"
Write(Html.Label("Meslek ID"));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    ");
#nullable restore
#line 11 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\UpdateJob.cshtml"
Write(Html.TextBoxFor(x => x.JobID, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n      ");
#nullable restore
#line 13 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\UpdateJob.cshtml"
 Write(Html.Label("Meslek Adı"));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    ");
#nullable restore
#line 14 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\UpdateJob.cshtml"
Write(Html.TextBoxFor(x => x.Name, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n \r\n    <button class=\"btn btn-info\">Meslek güncelle</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntitiyLayer.Concrete.Job> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
