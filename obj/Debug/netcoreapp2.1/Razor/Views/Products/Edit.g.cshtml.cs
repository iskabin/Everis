#pragma checksum "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5442b83989a453ec4c6414b56e01b8e42474861d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Edit), @"mvc.1.0.view", @"/Views/Products/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Edit.cshtml", typeof(AspNetCore.Views_Products_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5442b83989a453ec4c6414b56e01b8e42474861d", @"/Views/Products/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4108824d81b49f66b6066fcf6a3d2ee5e3a19c09", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(103, 15, true);
            WriteLiteral("\r\n<h2>Editando ");
            EndContext();
            BeginContext(119, 10, false);
#line 7 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
        Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(129, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 9 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
 using (Html.BeginForm("SaveForm", "Products"))
{

#line default
#line hidden
            BeginContext(190, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(229, 26, false);
#line 12 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(p => p.Code));

#line default
#line hidden
            EndContext();
            BeginContext(255, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(266, 61, false);
#line 13 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
   Write(Html.TextBoxFor(p => p.Code, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(327, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(380, 26, false);
#line 16 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(p => p.Name));

#line default
#line hidden
            EndContext();
            BeginContext(406, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(417, 61, false);
#line 17 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
   Write(Html.TextBoxFor(p => p.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(478, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(531, 29, false);
#line 20 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(p => p.Company));

#line default
#line hidden
            EndContext();
            BeginContext(560, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(571, 64, false);
#line 21 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
   Write(Html.TextBoxFor(p => p.Company, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(635, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(688, 28, false);
#line 24 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(p => p.Income));

#line default
#line hidden
            EndContext();
            BeginContext(716, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(727, 63, false);
#line 25 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
   Write(Html.TextBoxFor(p => p.Income, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(790, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(843, 29, false);
#line 28 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(p => p.Outcome));

#line default
#line hidden
            EndContext();
            BeginContext(872, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(883, 64, false);
#line 29 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
   Write(Html.TextBoxFor(p => p.Outcome, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(947, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1000, 27, false);
#line 32 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(p => p.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1038, 62, false);
#line 33 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
   Write(Html.TextBoxFor(p => p.Stock, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(1119, 25, false);
#line 35 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
Write(Html.HiddenFor(p => p.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 67, true);
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Editar</button>\r\n");
            EndContext();
#line 37 "E:\Everis\SecondTake\Everis\Views\Products\Edit.cshtml"
}

#line default
#line hidden
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