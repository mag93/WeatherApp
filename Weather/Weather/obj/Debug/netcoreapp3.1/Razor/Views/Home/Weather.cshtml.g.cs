#pragma checksum "E:\Practice\Weather\Weather\Views\Home\Weather.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70f890d0530fc379f292329d17b283229d54818b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Weather), @"mvc.1.0.view", @"/Views/Home/Weather.cshtml")]
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
#line 1 "E:\Practice\Weather\Weather\Views\_ViewImports.cshtml"
using Weather;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Practice\Weather\Weather\Views\_ViewImports.cshtml"
using Weather.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f890d0530fc379f292329d17b283229d54818b", @"/Views/Home/Weather.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b60324443873548bc452561682550276f3a62757", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Weather : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeatherType>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"col-sm-12 final\"");
            BeginWriteAttribute("style", " style=\"", 52, "\"", 114, 5);
            WriteAttributeValue("", 60, "background-image:url(\'", 60, 22, true);
#nullable restore
#line 4 "E:\Practice\Weather\Weather\Views\Home\Weather.cshtml"
WriteAttributeValue("", 82, Model.PhotoURL, 82, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 97, "\');", 97, 3, true);
            WriteAttributeValue(" ", 100, "opacity:", 101, 9, true);
            WriteAttributeValue(" ", 109, "0.6;", 110, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div style=\"opacity: 1;\">\r\n");
#nullable restore
#line 6 "E:\Practice\Weather\Weather\Views\Home\Weather.cshtml"
         switch (Model.Climate)
        {
            case "Clouds":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12 lottie\">\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 293, "\"", 373, 2);
            WriteAttributeValue("", 299, "https://unpkg.com/", 299, 18, true);
            WriteLiteral("@");
            WriteAttributeValue("", 319, "lottiefiles/lottie-player@latest/dist/lottie-player.js", 319, 54, true);
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <lottie-player src=\"https://assets6.lottiefiles.com/temp/lf20_kOfPKE.json\" background=\"transparent\" speed=\"0.8\" style=\"width: 300px; height: 300px;\" loop autoplay></lottie-player>\r\n                </div>\r\n");
#nullable restore
#line 13 "E:\Practice\Weather\Weather\Views\Home\Weather.cshtml"
                break;
            case "Clear":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12 lottie\">\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 734, "\"", 814, 2);
            WriteAttributeValue("", 740, "https://unpkg.com/", 740, 18, true);
            WriteLiteral("@");
            WriteAttributeValue("", 760, "lottiefiles/lottie-player@latest/dist/lottie-player.js", 760, 54, true);
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <lottie-player src=\"https://assets6.lottiefiles.com/temp/lf20_Stdaec.json\" background=\"transparent\" speed=\"1\" style=\"width: 300px; height: 300px;\" loop autoplay></lottie-player>\r\n                </div>\r\n");
#nullable restore
#line 19 "E:\Practice\Weather\Weather\Views\Home\Weather.cshtml"
                break;
            case "Rain":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12 lottie\">\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 1172, "\"", 1252, 2);
            WriteAttributeValue("", 1178, "https://unpkg.com/", 1178, 18, true);
            WriteLiteral("@");
            WriteAttributeValue("", 1198, "lottiefiles/lottie-player@latest/dist/lottie-player.js", 1198, 54, true);
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <lottie-player src=\"https://assets2.lottiefiles.com/packages/lf20_X1qyEw.json\" background=\"transparent\" speed=\"1\" style=\"width: 300px; height: 300px;\" loop autoplay></lottie-player>\r\n                </div>\r\n");
#nullable restore
#line 25 "E:\Practice\Weather\Weather\Views\Home\Weather.cshtml"
                break;
            case "Drizzle":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12 lottie\">\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 1617, "\"", 1697, 2);
            WriteAttributeValue("", 1623, "https://unpkg.com/", 1623, 18, true);
            WriteLiteral("@");
            WriteAttributeValue("", 1643, "lottiefiles/lottie-player@latest/dist/lottie-player.js", 1643, 54, true);
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <lottie-player src=\"https://assets8.lottiefiles.com/packages/lf20_jmBauI.json\" background=\"transparent\" speed=\"0.7\" style=\"width: 300px; height: 300px;\" loop autoplay></lottie-player>\r\n                </div>\r\n");
#nullable restore
#line 31 "E:\Practice\Weather\Weather\Views\Home\Weather.cshtml"
                break;
            case "Thunderstorm":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12 lottie\">\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 2069, "\"", 2149, 2);
            WriteAttributeValue("", 2075, "https://unpkg.com/", 2075, 18, true);
            WriteLiteral("@");
            WriteAttributeValue("", 2095, "lottiefiles/lottie-player@latest/dist/lottie-player.js", 2095, 54, true);
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <lottie-player src=\"https://assets6.lottiefiles.com/temp/lf20_XkF78Y.json\" background=\"transparent\" speed=\"1\" style=\"width: 300px; height: 300px;\" loop autoplay></lottie-player>\r\n                </div>\r\n");
#nullable restore
#line 37 "E:\Practice\Weather\Weather\Views\Home\Weather.cshtml"
                break;
            default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12 lottie\">\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 2503, "\"", 2583, 2);
            WriteAttributeValue("", 2509, "https://unpkg.com/", 2509, 18, true);
            WriteLiteral("@");
            WriteAttributeValue("", 2529, "lottiefiles/lottie-player@latest/dist/lottie-player.js", 2529, 54, true);
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <lottie-player src=\"https://assets8.lottiefiles.com/packages/lf20_kljxfos1.json\" background=\"transparent\" speed=\"0.8\" style=\"width: 300px; height: 300px;\" loop autoplay></lottie-player>\r\n                </div>\r\n");
#nullable restore
#line 43 "E:\Practice\Weather\Weather\Views\Home\Weather.cshtml"
                break;

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div id=\"Weather\">\r\n            ");
#nullable restore
#line 48 "E:\Practice\Weather\Weather\Views\Home\Weather.cshtml"
       Write(Model.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <p> ");
#nullable restore
#line 49 "E:\Practice\Weather\Weather\Views\Home\Weather.cshtml"
           Write(char.ToUpper(Model.WeatherClimate[0]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\Practice\Weather\Weather\Views\Home\Weather.cshtml"
                                                 Write(Model.WeatherClimate.Substring(1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>  ");
#nullable restore
#line 50 "E:\Practice\Weather\Weather\Views\Home\Weather.cshtml"
            Write(Model.Temperature);

#line default
#line hidden
#nullable disable
            WriteLiteral(" °C</p>\r\n            ");
#nullable restore
#line 51 "E:\Practice\Weather\Weather\Views\Home\Weather.cshtml"
       Write(Html.ActionLink("Back", "Index", "Home", new { @id = "HomeLink" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div id=\"Weather\">Created by Muzzammil Ghaffar</div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeatherType> Html { get; private set; }
    }
}
#pragma warning restore 1591