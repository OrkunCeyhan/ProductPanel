#pragma checksum "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81a64f9db750aeac755b5725a5dc8461a95c04a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Customer\Index.cshtml"
using EntitiyLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81a64f9db750aeac755b5725a5dc8461a95c04a7", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6f8ed1d814826b0325b7edc2445af88a4a60689", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Müsteri adı</th>\r\n        <th>Şehir</th>\r\n        <th>Meslek</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Customer\Index.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Customer\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Customer\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Customer\Index.cshtml"
           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Customer\Index.cshtml"
           Write(item.Job.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n   \r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 570, "\"", 610, 2);
            WriteAttributeValue("", 577, "/Customer/DeleteCustomer/", 577, 25, true);
#nullable restore
#line 28 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Customer\Index.cshtml"
WriteAttributeValue("", 602, item.Id, 602, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a> </td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 677, "\"", 717, 2);
            WriteAttributeValue("", 684, "/Customer/UpdateCustomer/", 684, 25, true);
#nullable restore
#line 29 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Customer\Index.cshtml"
WriteAttributeValue("", 709, item.Id, 709, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a> </td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Orkun\Desktop\ASPprojeler\Demo_ProductV2\Demo_ProductV2\Views\Customer\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Customer/AddCustomer/\" class=\"btn btn-outline-primary\">Yeni Müşteri</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Customer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591