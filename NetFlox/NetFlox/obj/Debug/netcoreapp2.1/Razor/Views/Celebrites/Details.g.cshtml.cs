#pragma checksum "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0deec771f9780a2de100b9e981787f90ed47015f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Celebrites_Details), @"mvc.1.0.view", @"/Views/Celebrites/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Celebrites/Details.cshtml", typeof(AspNetCore.Views_Celebrites_Details))]
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
#line 1 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\_ViewImports.cshtml"
using NetFlox;

#line default
#line hidden
#line 2 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\_ViewImports.cshtml"
using NetFlox.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0deec771f9780a2de100b9e981787f90ed47015f", @"/Views/Celebrites/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6134f49c68494dd9e95ab8c86bcd74edd7d30ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Celebrites_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetFlox.DAL.Celebrite>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Films", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml"
  
    ViewData["Title"] = Model.Nom;

#line default
#line hidden
            BeginContext(75, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(82, 9, false);
#line 7 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml"
Write(Model.Nom);

#line default
#line hidden
            EndContext();
            BeginContext(91, 81, true);
            WriteLiteral("</h2>\r\n<div style=\"display: flex; flex-direction: row;\">\r\n    <div>\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 172, "\"", 193, 1);
#line 10 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml"
WriteAttributeValue("", 178, Model.UrlPhoto, 178, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(194, 140, true);
            WriteLiteral(" style=\"max-width: 300px;\" />\r\n    </div>\r\n    <div>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(335, 39, false);
#line 16 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(374, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(430, 35, false);
#line 19 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml"
           Write(Html.DisplayFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(465, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(521, 49, false);
#line 22 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.DateNaissance));

#line default
#line hidden
            EndContext();
            BeginContext(570, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(626, 43, false);
#line 25 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml"
           Write(Model.DateNaissance?.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(669, 338, true);
            WriteLiteral(@"
            </dd>
        </dl>
    </div>
</div>
<div>
    <table class=""table"">
        <thead>
            <tr>
                <th></th>
                <th>Titre</th>
                <th>Année</th>
                <th>Rôle</th>
                <th>Personnage</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 42 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml"
             foreach (var item in Model.RoleCelebriteFilms.OrderByDescending(rcf => rcf.Film.Annee))
            {

#line default
#line hidden
            BeginContext(1124, 64, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1188, "\"", 1215, 1);
#line 46 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml"
WriteAttributeValue("", 1194, item.Film.UrlAffiche, 1194, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1216, 82, true);
            WriteLiteral(" height=\"50\" />\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1298, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15d77f499f874bc789b393441e7eaa98", async() => {
                BeginContext(1374, 45, false);
#line 49 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Film.Titre));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml"
                                                                     WriteLiteral(item.FilmId);

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
            BeginContext(1423, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1491, 45, false);
#line 52 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Film.Annee));

#line default
#line hidden
            EndContext();
            BeginContext(1536, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1604, 47, false);
#line 55 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Role.Libelle));

#line default
#line hidden
            EndContext();
            BeginContext(1651, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1719, 48, false);
#line 58 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.NomPersonnage));

#line default
#line hidden
            EndContext();
            BeginContext(1767, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 61 "C:\Users\louis\Desktop\projet.NET\net_dawin\FormationAspNetCore\NetFlox\NetFlox\Views\Celebrites\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1826, 53, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1879, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4c8fe0d7d21474782029109bfa665e6", async() => {
                BeginContext(1901, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1917, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetFlox.DAL.Celebrite> Html { get; private set; }
    }
}
#pragma warning restore 1591