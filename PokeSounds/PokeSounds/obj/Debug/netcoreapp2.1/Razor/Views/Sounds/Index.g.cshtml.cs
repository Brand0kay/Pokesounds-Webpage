#pragma checksum "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8e1a309d91f3357d2ffd9fe45fed707d2f41086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sounds_Index), @"mvc.1.0.view", @"/Views/Sounds/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sounds/Index.cshtml", typeof(AspNetCore.Views_Sounds_Index))]
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
#line 1 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\_ViewImports.cshtml"
using PokeSounds;

#line default
#line hidden
#line 2 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\_ViewImports.cshtml"
using PokeSounds.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e1a309d91f3357d2ffd9fe45fed707d2f41086", @"/Views/Sounds/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c4ccbec4e979eb71f27678222f33f4b2429050f", @"/Views/_ViewImports.cshtml")]
    public class Views_Sounds_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Pokemon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sprite"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("PLAY"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("play()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("audio"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int i = 1;

#line default
#line hidden
            BeginContext(80, 50, true);
            WriteLiteral("\r\n<h2>Pokemedley</h2>\r\n\r\n\r\n<div id=\"Pokemons\">\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
     foreach (var Pokemon in Model)
    {

#line default
#line hidden
            BeginContext(174, 39, true);
            WriteLiteral("    <div class=\"Pokemon\">\r\n\r\n        \r\n");
            EndContext();
#line 17 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
         if (i < 10)
        {

#line default
#line hidden
            BeginContext(246, 16, true);
            WriteLiteral("        <h3># 00");
            EndContext();
            BeginContext(264, 1, false);
#line 19 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
            Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(266, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(270, 12, false);
#line 19 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
                  Write(Pokemon.Name);

#line default
#line hidden
            EndContext();
            BeginContext(282, 8, true);
            WriteLiteral(" </h3>\r\n");
            EndContext();
#line 20 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(301, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 21 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
         if (i < 100 & i >= 10)
        {

#line default
#line hidden
            BeginContext(345, 15, true);
            WriteLiteral("        <h3># 0");
            EndContext();
            BeginContext(362, 1, false);
#line 23 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(364, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(368, 12, false);
#line 23 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
                 Write(Pokemon.Name);

#line default
#line hidden
            EndContext();
            BeginContext(380, 8, true);
            WriteLiteral(" </h3>\r\n");
            EndContext();
#line 24 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(399, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 25 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
         if (i > 100)
        {

#line default
#line hidden
            BeginContext(433, 14, true);
            WriteLiteral("        <h3># ");
            EndContext();
            BeginContext(448, 1, false);
#line 27 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
         Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(449, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(453, 12, false);
#line 27 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
              Write(Pokemon.Name);

#line default
#line hidden
            EndContext();
            BeginContext(465, 8, true);
            WriteLiteral(" </h3>\r\n");
            EndContext();
#line 28 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(484, 212, true);
            WriteLiteral("\r\n        <script type=\"text/javascript\">\r\n            function play() {\r\n                var audio = document.getElementById(\"audio\");\r\n                audio.play();\r\n            }\r\n        </script>\r\n\r\n        ");
            EndContext();
            BeginContext(696, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1be1bd9969b9463dad9087c33fbca714", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 721, "~/images/", 721, 9, true);
#line 37 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
AddHtmlAttributeValue("", 730, i, 730, 4, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 734, ".png", 734, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 37 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
AddHtmlAttributeValue("", 745, i, 745, 4, false);

#line default
#line hidden
            AddHtmlAttributeValue(" ", 749, "|", 750, 2, true);
#line 37 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
AddHtmlAttributeValue(" ", 751, Pokemon.Name, 752, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(797, 16, true);
            WriteLiteral("\r\n            \r\n");
            EndContext();
#line 39 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
         if (i < 10)
        {

#line default
#line hidden
            BeginContext(846, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(858, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("audio", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4ca06aba58c4b74a2e799c07c363f0c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 881, "~/audio/00", 881, 10, true);
#line 41 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
AddHtmlAttributeValue("", 891, i, 891, 4, false);

#line default
#line hidden
            AddHtmlAttributeValue(" ", 895, "-", 896, 2, true);
#line 41 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
AddHtmlAttributeValue(" ", 897, Pokemon.Name, 898, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 913, ".wav", 913, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(927, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 42 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(940, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 43 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
         if (i < 100 & i >= 10)
        {

#line default
#line hidden
            BeginContext(984, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(996, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("audio", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31aecb095350492594533092bd6e8018", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1019, "~/Audio/0", 1019, 9, true);
#line 45 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
AddHtmlAttributeValue("", 1028, i, 1028, 4, false);

#line default
#line hidden
            AddHtmlAttributeValue(" ", 1032, "-", 1033, 2, true);
#line 45 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
AddHtmlAttributeValue(" ", 1034, Pokemon.Name, 1035, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1050, ".wav", 1050, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1064, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1077, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 47 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
         if (i > 100)
        {

#line default
#line hidden
            BeginContext(1111, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1123, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("audio", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75ee5f1235b4469abd271f8ddeb11074", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1146, "~/Audio/", 1146, 8, true);
#line 49 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
AddHtmlAttributeValue("", 1154, i, 1154, 4, false);

#line default
#line hidden
            AddHtmlAttributeValue(" ", 1158, "-", 1159, 2, true);
#line 49 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
AddHtmlAttributeValue(" ", 1160, Pokemon.Name, 1161, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1176, ".wav", 1176, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1190, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 50 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1203, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 51 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
          
            i++;
        

#line default
#line hidden
            BeginContext(1244, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 55 "C:\Users\Brandon Batel\source\repos\PokeSounds\PokeSounds\Views\Sounds\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1263, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Pokemon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
