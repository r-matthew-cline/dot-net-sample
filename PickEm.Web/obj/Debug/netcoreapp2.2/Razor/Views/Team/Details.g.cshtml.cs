#pragma checksum "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2413152b0696d90ee2a20eb4231245854771378e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Details), @"mvc.1.0.view", @"/Views/Team/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/Details.cshtml", typeof(AspNetCore.Views_Team_Details))]
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
#line 1 "X:\Repos\dot-net-sample\PickEm.Web\Views\_ViewImports.cshtml"
using PickEm.Web;

#line default
#line hidden
#line 2 "X:\Repos\dot-net-sample\PickEm.Web\Views\_ViewImports.cshtml"
using PickEm.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2413152b0696d90ee2a20eb4231245854771378e", @"/Views/Team/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78160ceae16cede55e026c4e3809192e7c8a31ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PickEm.Models.TeamModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(77, 132, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>TeamModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(210, 42, false);
#line 14 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TeamId));

#line default
#line hidden
            EndContext();
            BeginContext(252, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(316, 38, false);
#line 17 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayFor(model => model.TeamId));

#line default
#line hidden
            EndContext();
            BeginContext(354, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(417, 40, false);
#line 20 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(457, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(521, 36, false);
#line 23 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(557, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(620, 44, false);
#line 26 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AvgScore));

#line default
#line hidden
            EndContext();
            BeginContext(664, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(728, 40, false);
#line 29 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayFor(model => model.AvgScore));

#line default
#line hidden
            EndContext();
            BeginContext(768, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(831, 47, false);
#line 32 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AvgOppScore));

#line default
#line hidden
            EndContext();
            BeginContext(878, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(942, 43, false);
#line 35 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayFor(model => model.AvgOppScore));

#line default
#line hidden
            EndContext();
            BeginContext(985, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1048, 45, false);
#line 38 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AvgOffReb));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1157, 41, false);
#line 41 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayFor(model => model.AvgOffReb));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1261, 45, false);
#line 44 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AvgDefReb));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1370, 41, false);
#line 47 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayFor(model => model.AvgDefReb));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1474, 42, false);
#line 50 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AvgStl));

#line default
#line hidden
            EndContext();
            BeginContext(1516, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1580, 38, false);
#line 53 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayFor(model => model.AvgStl));

#line default
#line hidden
            EndContext();
            BeginContext(1618, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1681, 42, false);
#line 56 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AvgBlk));

#line default
#line hidden
            EndContext();
            BeginContext(1723, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1787, 38, false);
#line 59 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayFor(model => model.AvgBlk));

#line default
#line hidden
            EndContext();
            BeginContext(1825, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1888, 40, false);
#line 62 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Seed));

#line default
#line hidden
            EndContext();
            BeginContext(1928, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1992, 36, false);
#line 65 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
       Write(Html.DisplayFor(model => model.Seed));

#line default
#line hidden
            EndContext();
            BeginContext(2028, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2075, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2413152b0696d90ee2a20eb4231245854771378e11387", async() => {
                BeginContext(2125, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "X:\Repos\dot-net-sample\PickEm.Web\Views\Team\Details.cshtml"
                           WriteLiteral(Model.TeamId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2133, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2141, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2413152b0696d90ee2a20eb4231245854771378e13694", async() => {
                BeginContext(2163, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2179, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PickEm.Models.TeamModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
