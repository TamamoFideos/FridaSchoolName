#pragma checksum "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/Shared/_LayoutAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2373d1e156938aaa8fc8c940fc38c30f832c5187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutAccount), @"mvc.1.0.view", @"/Views/Shared/_LayoutAccount.cshtml")]
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
#line 1 "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/_ViewImports.cshtml"
using FridaSchoolWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/_ViewImports.cshtml"
using FridaSchoolWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2373d1e156938aaa8fc8c940fc38c30f832c5187", @"/Views/Shared/_LayoutAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb0c48b48b144c6cc13f62f1bcd3497516f68842", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"menu\">\r\n\r\n<div class=\"btn-group-vertical\">\r\n    <h3 style=\"font-family: Arial, Helvetica, sans-serif;\">Welcome, ");
#nullable restore
#line 5 "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/Shared/_LayoutAccount.cshtml"
                                                               Write(HttpContextAccessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type == "FullName")?.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"!</h3>
    <hr>
    <a type=""button"" class=""btn btn-outline-info btnMenu"" href=""/Profile/Index"">
        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-person-fill"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
        <path fill-rule=""evenodd"" d=""M3 14s-1 0-1-1 1-4 6-4 6 3 6 4-1 1-1 1H3zm5-6a3 3 0 1 0 0-6 3 3 0 0 0 0 6z""/>
        </svg>
        Profile</a>
    <a type=""button"" class=""btn btn-outline-info btnMenu"" href=""/Subject/MySubjects"">
        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-journal-bookmark-fill"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
        <path d=""M3 0h10a2 2 0 0 1 2 2v12a2 2 0 0 1-2 2H3a2 2 0 0 1-2-2v-1h1v1a1 1 0 0 0 1 1h10a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H3a1 1 0 0 0-1 1v1H1V2a2 2 0 0 1 2-2z""/>
        <path d=""M1 5v-.5a.5.5 0 0 1 1 0V5h.5a.5.5 0 0 1 0 1h-2a.5.5 0 0 1 0-1H1zm0 3v-.5a.5.5 0 0 1 1 0V8h.5a.5.5 0 0 1 0 1h-2a.5.5 0 0 1 0-1H1zm0 3v-.5a.5.5 0 0 1 1 0v.5h.5a.5.5 0 0 1 0 1h-2a.5.5 0 0 1 0-1H1z""/>
        <p");
            WriteLiteral(@"ath fill-rule=""evenodd"" d=""M6 1h6v7a.5.5 0 0 1-.757.429L9 7.083 6.757 8.43A.5.5 0 0 1 6 8V1z""/>
        </svg>
        Subjects</a>
    <a type=""button"" class=""btn btn-outline-info btnMenu"" href=""/Group/MyGroups"">
        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-clipboard-check"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
        <path fill-rule=""evenodd"" d=""M4 1.5H3a2 2 0 0 0-2 2V14a2 2 0 0 0 2 2h10a2 2 0 0 0 2-2V3.5a2 2 0 0 0-2-2h-1v1h1a1 1 0 0 1 1 1V14a1 1 0 0 1-1 1H3a1 1 0 0 1-1-1V3.5a1 1 0 0 1 1-1h1v-1z""/>
        <path fill-rule=""evenodd"" d=""M9.5 1h-3a.5.5 0 0 0-.5.5v1a.5.5 0 0 0 .5.5h3a.5.5 0 0 0 .5-.5v-1a.5.5 0 0 0-.5-.5zm-3-1A1.5 1.5 0 0 0 5 1.5v1A1.5 1.5 0 0 0 6.5 4h3A1.5 1.5 0 0 0 11 2.5v-1A1.5 1.5 0 0 0 9.5 0h-3zm4.354 7.146a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708 0l-1.5-1.5a.5.5 0 1 1 .708-.708L7.5 9.793l2.646-2.647a.5.5 0 0 1 .708 0z""/>
        </svg>
        Groups</a>
    <a type=""button"" class=""btn btn-outline-info btnMenu"" href=""/Sort/Index"">
      ");
            WriteLiteral(@"  <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-columns"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
        <path fill-rule=""evenodd"" d=""M15 2H1v12h14V2zM1 1a1 1 0 0 0-1 1v12a1 1 0 0 0 1 1h14a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H1z""/>
        <path fill-rule=""evenodd"" d=""M7.5 14V2h1v12h-1zm0-8H1V5h6.5v1zm7.5 5H8.5v-1H15v1z""/>
        </svg>
        Sort</a>
</div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
