#pragma checksum "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1802e80017aabdf8706cf734ff669fa7bf7cfc73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Form), @"mvc.1.0.view", @"/Views/Products/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Form.cshtml", typeof(AspNetCore.Views_Products_Form))]
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
#line 1 "E:\Everis\SecondTake\Everis\Views\_ViewImports.cshtml"
using Everis;

#line default
#line hidden
#line 2 "E:\Everis\SecondTake\Everis\Views\_ViewImports.cshtml"
using Everis.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1802e80017aabdf8706cf734ff669fa7bf7cfc73", @"/Views/Products/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4108824d81b49f66b6066fcf6a3d2ee5e3a19c09", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("exclude", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
  
    ViewData["Title"] = "Form";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(103, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
 if (Model == null)
{

#line default
#line hidden
            BeginContext(129, 32, true);
            WriteLiteral("    <h2>Adicionar Produto</h2>\r\n");
            EndContext();
#line 10 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(173, 17, true);
            WriteLiteral("    <h2>Editando ");
            EndContext();
            BeginContext(191, 10, false);
#line 13 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
            Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(201, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 14 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
}

#line default
#line hidden
            BeginContext(211, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
 using (Html.BeginForm("SaveForm", "Products"))
{

#line default
#line hidden
            BeginContext(265, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(304, 26, false);
#line 19 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.LabelFor(p => p.Code));

#line default
#line hidden
            EndContext();
            BeginContext(330, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(341, 61, false);
#line 20 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.TextBoxFor(p => p.Code, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(402, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(413, 38, false);
#line 21 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.ValidationMessageFor(p => p.Code));

#line default
#line hidden
            EndContext();
            BeginContext(451, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(504, 26, false);
#line 24 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.LabelFor(p => p.Name));

#line default
#line hidden
            EndContext();
            BeginContext(530, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(541, 61, false);
#line 25 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.TextBoxFor(p => p.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(602, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(613, 38, false);
#line 26 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.ValidationMessageFor(p => p.Name));

#line default
#line hidden
            EndContext();
            BeginContext(651, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(704, 29, false);
#line 29 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.LabelFor(p => p.Company));

#line default
#line hidden
            EndContext();
            BeginContext(733, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(744, 64, false);
#line 30 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.TextBoxFor(p => p.Company, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(808, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(819, 41, false);
#line 31 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.ValidationMessageFor(p => p.Company));

#line default
#line hidden
            EndContext();
            BeginContext(860, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(913, 28, false);
#line 34 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.LabelFor(p => p.Income));

#line default
#line hidden
            EndContext();
            BeginContext(941, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(952, 63, false);
#line 35 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.TextBoxFor(p => p.Income, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1015, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1026, 40, false);
#line 36 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.ValidationMessageFor(p => p.Income));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1119, 29, false);
#line 39 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.LabelFor(p => p.Outcome));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1159, 64, false);
#line 40 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.TextBoxFor(p => p.Outcome, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1234, 41, false);
#line 41 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.ValidationMessageFor(p => p.Outcome));

#line default
#line hidden
            EndContext();
            BeginContext(1275, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1328, 27, false);
#line 44 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.LabelFor(p => p.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1366, 62, false);
#line 45 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.TextBoxFor(p => p.Stock, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1439, 39, false);
#line 46 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
   Write(Html.ValidationMessageFor(p => p.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(1478, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(1497, 25, false);
#line 48 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
Write(Html.HiddenFor(p => p.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 23, false);
#line 49 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
#line 50 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
     if (Model == null)
    {

#line default
#line hidden
            BeginContext(1586, 74, true);
            WriteLiteral("        <button type=\"submit\" class=\"btn btn-primary\">Adicionar</button>\r\n");
            EndContext();
#line 53 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1684, 71, true);
            WriteLiteral("        <button type=\"submit\" class=\"btn btn-primary\">Editar</button>\r\n");
            EndContext();
#line 57 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
    }

#line default
#line hidden
#line 57 "E:\Everis\SecondTake\Everis\Views\Products\Form.cshtml"
     
}

#line default
#line hidden
            BeginContext(1765, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1767, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85a3b7ce8f97474fb4bab85c50be9f9a", async() => {
                BeginContext(1802, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1808, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61cbd9273f1644e2a751d5e57a5a04bb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1879, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1895, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1899, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27f904ad7e724819b134d8edd3e8bde9", async() => {
                BeginContext(1934, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1940, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a638cf6774247bea9f467743ec7022b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2011, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591