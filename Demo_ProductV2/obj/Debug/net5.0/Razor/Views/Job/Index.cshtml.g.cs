#pragma checksum "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "949f77282f1ed8d75cd4c6709a62922425501113"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Index), @"mvc.1.0.view", @"/Views/Job/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\Index.cshtml"
using EntitiyLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"949f77282f1ed8d75cd4c6709a62922425501113", @"/Views/Job/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6f8ed1d814826b0325b7edc2445af88a4a60689", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Job_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Job>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Meslek</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n        <th>Detaylar</th>\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\Index.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\Index.cshtml"
           Write(item.JobID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n     \r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 481, "\"", 514, 2);
            WriteAttributeValue("", 488, "/Job/DeleteJob/", 488, 15, true);
#nullable restore
#line 27 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\Index.cshtml"
WriteAttributeValue("", 503, item.JobID, 503, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a> </td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 581, "\"", 614, 2);
            WriteAttributeValue("", 588, "/Job/UpdateJob/", 588, 15, true);
#nullable restore
#line 28 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\Index.cshtml"
WriteAttributeValue("", 603, item.JobID, 603, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a> </td>\r\n                   <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "949f77282f1ed8d75cd4c6709a629224255011136103", async() => {
                WriteLiteral("Detaylar");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 701, "~/Job/DetailsJob/", 701, 17, true);
#nullable restore
#line 29 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\Index.cshtml"
AddHtmlAttributeValue("", 718, item.JobID, 718, 11, false);

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
            WriteLiteral(" </td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Job\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table></h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Job>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
