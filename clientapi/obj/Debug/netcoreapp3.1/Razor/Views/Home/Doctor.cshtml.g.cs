#pragma checksum "D:\DockerAppCommunication\DockerCommunication\ClientAPP\Views\Home\Doctor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d23fb0f917dd913bb876e6f1a5b167becf5c820"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Doctor), @"mvc.1.0.view", @"/Views/Home/Doctor.cshtml")]
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
#line 1 "D:\DockerAppCommunication\DockerCommunication\ClientAPP\Views\_ViewImports.cshtml"
using ClientAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DockerAppCommunication\DockerCommunication\ClientAPP\Views\_ViewImports.cshtml"
using ClientAPP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d23fb0f917dd913bb876e6f1a5b167becf5c820", @"/Views/Home/Doctor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4a77df65563fc223a76d6a8d9bb669032b14d6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Doctor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClientAPP.Models.Hospital.Doctor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DockerAppCommunication\DockerCommunication\ClientAPP\Views\Home\Doctor.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"form-horizontal\">\r\n    <hr />\r\n    <div class=\"form-group\">\r\n        <table class=\"table table-responsive\" style=\"width:400px\">\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 12 "D:\DockerAppCommunication\DockerCommunication\ClientAPP\Views\Home\Doctor.cshtml"
               Write(Html.DisplayNameFor(model => model.DoctorID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "D:\DockerAppCommunication\DockerCommunication\ClientAPP\Views\Home\Doctor.cshtml"
               Write(Html.DisplayNameFor(model => model.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n");
#nullable restore
#line 18 "D:\DockerAppCommunication\DockerCommunication\ClientAPP\Views\Home\Doctor.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 22 "D:\DockerAppCommunication\DockerCommunication\ClientAPP\Views\Home\Doctor.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DoctorID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 25 "D:\DockerAppCommunication\DockerCommunication\ClientAPP\Views\Home\Doctor.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 28 "D:\DockerAppCommunication\DockerCommunication\ClientAPP\Views\Home\Doctor.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClientAPP.Models.Hospital.Doctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591