#pragma checksum "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/Group/MyGroups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a7edec2b2c64f48424d1643ea0ed6849ece6e0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_MyGroups), @"mvc.1.0.view", @"/Views/Group/MyGroups.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a7edec2b2c64f48424d1643ea0ed6849ece6e0a", @"/Views/Group/MyGroups.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb0c48b48b144c6cc13f62f1bcd3497516f68842", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_MyGroups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<(Group,Subject)>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LayoutAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/Group/MyGroups.cshtml"
  
    ViewData["Title"] = "My Groups";
    Layout ="_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a7edec2b2c64f48424d1643ea0ed6849ece6e0a3737", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    <div class=\"view\">\n");
#nullable restore
#line 10 "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/Group/MyGroups.cshtml"
           
        if(HttpContextAccessor.HttpContext.User.IsInRole("Cordinator")){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                <li class=""nav-item"">
                    <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""/Group/Groups"" aria-selected=""false"">Groups</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""/Group/MyGroups"" aria-selected=""true"">MyGroups</a>
                </li>
            </ul>
");
#nullable restore
#line 20 "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/Group/MyGroups.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br>\n");
            WriteLiteral("        <div class=\"container\">\n");
            WriteLiteral(@"                 <table class=""table"">
                        <tbody>
                            <tr>
                                <th>Subject</th>
                                <th>Theory Hours</th>
                                <th>Practice Hours</th>
                                <th>Group</th>
                                <th>Period</th>
                            </tr>
");
#nullable restore
#line 34 "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/Group/MyGroups.cshtml"
                 foreach (var item in @Model)
                {
                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                        <td>");
#nullable restore
#line 38 "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/Group/MyGroups.cshtml"
                       Write(item.Item2.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 39 "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/Group/MyGroups.cshtml"
                       Write(item.Item2.TheoryHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 40 "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/Group/MyGroups.cshtml"
                       Write(item.Item2.PracticeHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 41 "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/Group/MyGroups.cshtml"
                       Write(item.Item1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 42 "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/Group/MyGroups.cshtml"
                          if(@item.Item1.Period == true){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Quarter</td>\n");
#nullable restore
#line 44 "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/Group/MyGroups.cshtml"
                        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Semester</td>\n");
#nullable restore
#line 46 "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/Group/MyGroups.cshtml"
                        }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                       </tr>\n");
#nullable restore
#line 49 "/Users/fernandajimenez/Documents/Archivos escolares/Programacion Avanzada/Csharp/FridaSchoolWeb/Views/Group/MyGroups.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n");
            WriteLiteral("            \n\n\n        </div>\n\n    </div>\n\n    \n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<(Group,Subject)>> Html { get; private set; }
    }
}
#pragma warning restore 1591
