#pragma checksum "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminAbout\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6385544743d96a832562c3b911ca98b29fd255cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminAbout_Update), @"mvc.1.0.view", @"/Views/AdminAbout/Update.cshtml")]
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
#line 1 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\_ViewImports.cshtml"
using FilmPuanlamaSitesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\_ViewImports.cshtml"
using FilmPuanlamaSitesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6385544743d96a832562c3b911ca98b29fd255cb", @"/Views/AdminAbout/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05ae501c9594dd0807d3c8f531a8ee631f98fd85", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminAbout_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmPuanlamaSitesi.Models.Siniflar.About>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminAbout\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Views/Shared/_AdminAboutLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"margin-right:750px; margin-top:100px;\">\r\n    <br />\r\n");
#nullable restore
#line 9 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminAbout\Update.cshtml"
     using (Html.BeginForm("UpdateAbout", "AdminAbout", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminAbout\Update.cshtml"
   Write(Html.LabelFor(x => x.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 13 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminAbout\Update.cshtml"
   Write(Html.TextBoxFor(x => x.ID, new { @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 15 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminAbout\Update.cshtml"
   Write(Html.LabelFor(x => x.Baslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 17 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminAbout\Update.cshtml"
   Write(Html.TextBoxFor(x => x.Baslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 19 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminAbout\Update.cshtml"
   Write(Html.LabelFor(x => x.FotoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 21 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminAbout\Update.cshtml"
   Write(Html.TextBoxFor(x => x.FotoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 23 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminAbout\Update.cshtml"
   Write(Html.LabelFor(x => x.Aciklama));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 25 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminAbout\Update.cshtml"
   Write(Html.TextBoxFor(x => x.Aciklama));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 27 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminAbout\Update.cshtml"
   Write(Html.LabelFor(x => x.Istatistik));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 29 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminAbout\Update.cshtml"
   Write(Html.TextBoxFor(x => x.Istatistik));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"margin-top:10px;\">\r\n            <button class=\"btn btn-primary\">Update About</button>\r\n        </div>\r\n");
#nullable restore
#line 33 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminAbout\Update.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmPuanlamaSitesi.Models.Siniflar.About> Html { get; private set; }
    }
}
#pragma warning restore 1591