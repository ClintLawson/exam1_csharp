#pragma checksum "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6275178dfe83412f5765b97be076a698bb17625d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Planner.Views_Planner_PlannerCenter), @"mvc.1.0.view", @"/Views/Planner/PlannerCenter.cshtml")]
namespace MyApp.Namespace.Planner
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
#line 3 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\_ViewImports.cshtml"
using login_register.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\_ViewImports.cshtml"
using exam1_csharp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6275178dfe83412f5765b97be076a698bb17625d", @"/Views/Planner/PlannerCenter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d23e7c0b6af2b62a99feb411f2628ced07f38bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Planner_PlannerCenter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlannerVmod>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6275178dfe83412f5765b97be076a698bb17625d3350", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Dojo Activity Center</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6275178dfe83412f5765b97be076a698bb17625d4473", async() => {
                WriteLiteral(@"
    <div style=""width: 800px; margin:auto;"">

        <div class=""header"" style=""display: flex; justify-content: space-between; border-bottom: black 1px solid;"">
            <h1>Dojo Activity Center</h1>
            <div style=""margin: auto 15px; display: flex;"">
                <p>Welcome, ");
#nullable restore
#line 15 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                       Write(Model.User.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                <a href=""/logout"" style=""margin-left: 30px;""><p>Logout</p></a>
            </div>
        </div>

        <div>
            <table style=""margin: 20px 0px; width: 100%;"">
                <tr style=""background-color: gray;"">
                    <th>Activity</th>
                    <th>Date and Time</th>
                    <th>Duration</th>
                    <th>Event Coordinator</th>
                    <th>No. of Participants</th>
                    <th>Actions</th>
                </tr>
");
#nullable restore
#line 30 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                 foreach(var r in Model.Parties)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr style=\"background-color: lightgray;\">\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 1234, "\"", 1260, 2);
                WriteAttributeValue("", 1241, "activity/", 1241, 9, true);
#nullable restore
#line 33 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
WriteAttributeValue("", 1250, r.PartyId, 1250, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ");
#nullable restore
#line 33 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                                                      Write(r.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                       Write(r.Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
                WriteLiteral("@ ");
#nullable restore
#line 34 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                                                         Write(r.Date.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                       Write(r.Duration);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                                   Write(r.DurationUnit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                       Write(r.Owner.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                       Write(r.RSVPs.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 38 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                         if(r.OwnerId == Model.User.UserId){

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td><a");
                BeginWriteAttribute("href", " href=\"", 1634, "\"", 1659, 2);
                WriteAttributeValue("", 1641, "/delete/", 1641, 8, true);
#nullable restore
#line 39 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
WriteAttributeValue("", 1649, r.PartyId, 1649, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Delete</a></td>\r\n");
#nullable restore
#line 40 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                        }
                        else{
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                             if(r.RSVPs.Any(r => r.UserId == Model.User.UserId)){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td><a");
                BeginWriteAttribute("href", " href=\"", 1857, "\"", 1889, 3);
                WriteAttributeValue("", 1864, "/change_rsvp/", 1864, 13, true);
#nullable restore
#line 43 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
WriteAttributeValue("", 1877, r.PartyId, 1877, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1887, "/0", 1887, 2, true);
                EndWriteAttribute();
                WriteLiteral(">Leave</a></td>\r\n");
#nullable restore
#line 44 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                            }
                            else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td><a");
                BeginWriteAttribute("href", " href=\"", 2011, "\"", 2043, 3);
                WriteAttributeValue("", 2018, "/change_rsvp/", 2018, 13, true);
#nullable restore
#line 46 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
WriteAttributeValue("", 2031, r.PartyId, 2031, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2041, "/0", 2041, 2, true);
                EndWriteAttribute();
                WriteLiteral(">Join</a></td>\r\n");
#nullable restore
#line 47 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 50 "C:\Users\Clint\Desktop\Dojo_Assignments\C#\exam1_csharp\Views\Planner\PlannerCenter.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </table>
            <div style=""text-align: right; margin-right: 20px;"">
                <a href=""/new"" style=""padding: 5px 10px; text-decoration: none; border: black 1px solid; box-shadow: 3px 3px black;"">
                    Add New Activity
                </a>
            </div>
        </div>

    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlannerVmod> Html { get; private set; }
    }
}
#pragma warning restore 1591
