#pragma checksum "/Users/jeff/Projects/ANSR/ANSR/Views/Home/CompletedIssues.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6862c009917bb09614052f9213561a5b2f589a82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CompletedIssues), @"mvc.1.0.view", @"/Views/Home/CompletedIssues.cshtml")]
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
#line 1 "/Users/jeff/Projects/ANSR/ANSR/Views/_ViewImports.cshtml"
using ANSR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jeff/Projects/ANSR/ANSR/Views/_ViewImports.cshtml"
using ANSR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6862c009917bb09614052f9213561a5b2f589a82", @"/Views/Home/CompletedIssues.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2795fc311108c97f07ba049503f45ef470ba28f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CompletedIssues : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/nicepage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/completed-issues.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("u-script"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("defer", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/nicepage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("u-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/jeff/Projects/ANSR/ANSR/Views/Home/CompletedIssues.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html style=\"font-size: 16px;\" lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6862c009917bb09614052f9213561a5b2f589a827008", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 226, "\"", 236, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 268, "\"", 278, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"page_type\" content=\"np-template-header-footer-from-plugin\">\r\n    <title>completed issues</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6862c009917bb09614052f9213561a5b2f589a827877", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6862c009917bb09614052f9213561a5b2f589a829127", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6862c009917bb09614052f9213561a5b2f589a8210377", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6862c009917bb09614052f9213561a5b2f589a8211721", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <meta name=""generator"" content=""Nicepage 2.27.3, nicepage.com"">
    <link id=""u-theme-google-font"" rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i|Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i"">
    <link id=""u-page-google-font"" rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=text-font"">


    <meta property=""og:title"" content=""completed issues"">
    <meta property=""og:type"" content=""website"">
    <meta name=""theme-color"" content=""#ec8700"">
    <link rel=""canonical"" href=""index.html"">
    <meta property=""og:url"" content=""index.html"">
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6862c009917bb09614052f9213561a5b2f589a8214446", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 30 "/Users/jeff/Projects/ANSR/ANSR/Views/Home/CompletedIssues.cshtml"
Write(Html.Partial("Header"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <section class=""u-clearfix u-section-1"" id=""sec-aab1"">
        <div class=""u-clearfix u-sheet u-sheet-1"">
            <div class=""u-palette-2-base u-radius-35 u-shape u-shape-round u-shape-1""></div>
            <h3 class=""u-text u-text-1"">Completed Issues</h3>
            <h5 class=""u-text u-text-2"">
                ID: 1234556<br>
            </h5>
            <h5 class=""u-text u-text-3"">Position: Seller</h5>
            <h5 class=""u-text u-text-4"">
                <a class=""u-active-none u-border-none u-btn u-button-link u-button-style u-hover-none u-none u-text-body-alt-color u-btn-1"" href=""../home/newissues"">New</a>
            </h5>
            <h5 class=""u-text u-text-5"">
                <a class=""u-active-none u-border-none u-btn u-button-link u-button-style u-hover-none u-none u-text-body-alt-color u-btn-2"" href=""../home/issuesinprogress"">In progress</a>
            </h5>
            <h6 class=""u-text u-text-default u-text-6"">
                <a class=""u-active-none u-border-none ");
                WriteLiteral(@"u-btn u-button-link u-button-style u-hover-none u-none u-text-body-alt-color u-btn-3"" href=""../home/completedissues"">Completed</a>
            </h6>
            <h5 class=""u-text u-text-7"">
                <a class=""u-active-none u-border-none u-btn u-button-link u-button-style u-hover-none u-none u-text-body-alt-color u-btn-4"" href=""../home/allissues"">All</a>
            </h5>
        </div>
    </section>
    <section class=""u-clearfix u-section-2"" id=""carousel_053b"">
        <div class=""u-clearfix u-sheet u-valign-middle-xs u-sheet-1"">
            <span class=""u-icon u-icon-rounded u-palette-2-light-1 u-radius-10 u-spacing-10 u-text-white u-icon-1""><svg class=""u-svg-link"" preserveAspectRatio=""xMidYMin slice"" viewBox=""0 -30 512 512""");
                BeginWriteAttribute("style", " style=\"", 3222, "\"", 3230, 0);
                EndWriteAttribute();
                WriteLiteral(@"><use xmlns:xlink=""http://www.w3.org/1999/xlink"" xlink:href=""#svg-b8f8""></use></svg><svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" version=""1.1"" xml:space=""preserve"" class=""u-svg-content"" viewBox=""0 -30 512 512"" id=""svg-b8f8""><path d=""m496.136719 291.480469-151-242c-19.332031-30.984375-52.65625-49.480469-89.136719-49.480469s-69.804688 18.496094-89.136719 49.480469l-151 242c-10.378906 16.632812-15.863281 35.832031-15.863281 55.519531 0 57.898438 47.101562 105 105 105h302c57.898438 0 105-47.101562 105-105 0-19.6875-5.484375-38.886719-15.863281-55.519531zm-89.136719 130.519531h-302c-41.355469 0-75-33.644531-75-75 0-14.066406 3.914062-27.773438 11.316406-39.636719l151-242c13.816406-22.144531 37.621094-35.363281 63.683594-35.363281s49.867188 13.21875 63.683594 35.363281l151 242c7.402344 11.863281 11.316406 25.570313 11.316406 39.636719 0 41.355469-33.644531 75-75 75zm0 0""></path><path d=""m294.234375 81.242188c-8.300781-13.300782-22.59375-21.242188-38.234375-21.242188s-29.933594 ");
                WriteLiteral(@"7.941406-38.234375 21.242188l-150.996094 242c-4.429687 7.097656-6.769531 15.3125-6.769531 23.757812 0 24.8125 20.1875 45 45 45h302c24.8125 0 45-20.1875 45-45 0-8.445312-2.339844-16.660156-6.765625-23.757812zm-23.234375 249.757812h-30v-30h30zm0-60h-30v-106h30zm0 0""></path></svg></span>
            <h4 class=""u-text u-text-1"">Refrigerator</h4>
            <p class=""u-small-text u-text u-text-font u-text-variant u-text-2"">Repair</p><span class=""u-icon u-icon-circle u-text-custom-color-1 u-icon-2"">
                <svg class=""u-svg-link"" preserveAspectRatio=""xMidYMin slice"" viewBox=""0 0 490.434 490.433""");
                BeginWriteAttribute("style", " style=\"", 4864, "\"", 4872, 0);
                EndWriteAttribute();
                WriteLiteral(@"><use xmlns:xlink=""http://www.w3.org/1999/xlink"" xlink:href=""#svg-54d6""></use></svg><svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" version=""1.1"" xml:space=""preserve"" class=""u-svg-content"" viewBox=""0 0 490.434 490.433"" x=""0px"" y=""0px"" id=""svg-54d6"" style=""enable-background:new 0 0 490.434 490.433;""><g><path d=""M472.003,58.36l-13.132-11.282c-21.798-18.732-54.554-16.644-73.799,4.697L165.39,295.359l-66.312-57.112   c-21.775-18.753-54.536-16.707-73.804,4.611l-11.611,12.848c-9.416,10.413-14.305,24.149-13.595,38.18   c0.717,14.023,6.973,27.188,17.402,36.6l121.553,111.311c10.524,9.883,24.628,15.037,39.044,14.272   c14.416-0.763,27.894-7.386,37.311-18.329l262.245-304.71c9.162-10.646,13.717-24.494,12.661-38.496   C489.229,80.522,482.655,67.512,472.003,58.36z""></path>
</g></svg>
            </span>
        </div>
    </section>
    <section class=""u-clearfix u-section-3"" id=""carousel_940a"">
        <div class=""u-clearfix u-sheet u-valign-middle-xs u-sheet-1"">
            <span ");
                WriteLiteral("class=\"u-icon u-icon-rounded u-palette-2-light-1 u-radius-10 u-spacing-10 u-text-white u-icon-1\"><svg class=\"u-svg-link\" preserveAspectRatio=\"xMidYMin slice\" viewBox=\"0 -30 512 512\"");
                BeginWriteAttribute("style", " style=\"", 6078, "\"", 6086, 0);
                EndWriteAttribute();
                WriteLiteral(@"><use xmlns:xlink=""http://www.w3.org/1999/xlink"" xlink:href=""#svg-b8f8""></use></svg><svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" version=""1.1"" xml:space=""preserve"" class=""u-svg-content"" viewBox=""0 -30 512 512"" id=""svg-b8f8""><path d=""m496.136719 291.480469-151-242c-19.332031-30.984375-52.65625-49.480469-89.136719-49.480469s-69.804688 18.496094-89.136719 49.480469l-151 242c-10.378906 16.632812-15.863281 35.832031-15.863281 55.519531 0 57.898438 47.101562 105 105 105h302c57.898438 0 105-47.101562 105-105 0-19.6875-5.484375-38.886719-15.863281-55.519531zm-89.136719 130.519531h-302c-41.355469 0-75-33.644531-75-75 0-14.066406 3.914062-27.773438 11.316406-39.636719l151-242c13.816406-22.144531 37.621094-35.363281 63.683594-35.363281s49.867188 13.21875 63.683594 35.363281l151 242c7.402344 11.863281 11.316406 25.570313 11.316406 39.636719 0 41.355469-33.644531 75-75 75zm0 0""></path><path d=""m294.234375 81.242188c-8.300781-13.300782-22.59375-21.242188-38.234375-21.242188s-29.933594 ");
                WriteLiteral(@"7.941406-38.234375 21.242188l-150.996094 242c-4.429687 7.097656-6.769531 15.3125-6.769531 23.757812 0 24.8125 20.1875 45 45 45h302c24.8125 0 45-20.1875 45-45 0-8.445312-2.339844-16.660156-6.765625-23.757812zm-23.234375 249.757812h-30v-30h30zm0-60h-30v-106h30zm0 0""></path></svg></span>
            <h4 class=""u-text u-text-1"">Cooler</h4>
            <p class=""u-small-text u-text u-text-font u-text-variant u-text-2"">Repair</p><span class=""u-icon u-icon-circle u-text-custom-color-1 u-icon-2"">
                <svg class=""u-svg-link"" preserveAspectRatio=""xMidYMin slice"" viewBox=""0 0 490.434 490.433""");
                BeginWriteAttribute("style", " style=\"", 7714, "\"", 7722, 0);
                EndWriteAttribute();
                WriteLiteral(@"><use xmlns:xlink=""http://www.w3.org/1999/xlink"" xlink:href=""#svg-878b""></use></svg><svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" version=""1.1"" xml:space=""preserve"" class=""u-svg-content"" viewBox=""0 0 490.434 490.433"" x=""0px"" y=""0px"" id=""svg-878b"" style=""enable-background:new 0 0 490.434 490.433;""><g><path d=""M472.003,58.36l-13.132-11.282c-21.798-18.732-54.554-16.644-73.799,4.697L165.39,295.359l-66.312-57.112   c-21.775-18.753-54.536-16.707-73.804,4.611l-11.611,12.848c-9.416,10.413-14.305,24.149-13.595,38.18   c0.717,14.023,6.973,27.188,17.402,36.6l121.553,111.311c10.524,9.883,24.628,15.037,39.044,14.272   c14.416-0.763,27.894-7.386,37.311-18.329l262.245-304.71c9.162-10.646,13.717-24.494,12.661-38.496   C489.229,80.522,482.655,67.512,472.003,58.36z""></path>
</g></svg>
            </span>
        </div>
    </section>
    <section class=""u-clearfix u-section-4"" id=""carousel_6a21"">
        <div class=""u-clearfix u-sheet u-valign-middle-xs u-sheet-1"">
            <span ");
                WriteLiteral("class=\"u-icon u-icon-rounded u-palette-2-light-1 u-radius-10 u-spacing-10 u-text-white u-icon-1\"><svg class=\"u-svg-link\" preserveAspectRatio=\"xMidYMin slice\" viewBox=\"0 -30 512 512\"");
                BeginWriteAttribute("style", " style=\"", 8928, "\"", 8936, 0);
                EndWriteAttribute();
                WriteLiteral(@"><use xmlns:xlink=""http://www.w3.org/1999/xlink"" xlink:href=""#svg-b8f8""></use></svg><svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" version=""1.1"" xml:space=""preserve"" class=""u-svg-content"" viewBox=""0 -30 512 512"" id=""svg-b8f8""><path d=""m496.136719 291.480469-151-242c-19.332031-30.984375-52.65625-49.480469-89.136719-49.480469s-69.804688 18.496094-89.136719 49.480469l-151 242c-10.378906 16.632812-15.863281 35.832031-15.863281 55.519531 0 57.898438 47.101562 105 105 105h302c57.898438 0 105-47.101562 105-105 0-19.6875-5.484375-38.886719-15.863281-55.519531zm-89.136719 130.519531h-302c-41.355469 0-75-33.644531-75-75 0-14.066406 3.914062-27.773438 11.316406-39.636719l151-242c13.816406-22.144531 37.621094-35.363281 63.683594-35.363281s49.867188 13.21875 63.683594 35.363281l151 242c7.402344 11.863281 11.316406 25.570313 11.316406 39.636719 0 41.355469-33.644531 75-75 75zm0 0""></path><path d=""m294.234375 81.242188c-8.300781-13.300782-22.59375-21.242188-38.234375-21.242188s-29.933594 ");
                WriteLiteral(@"7.941406-38.234375 21.242188l-150.996094 242c-4.429687 7.097656-6.769531 15.3125-6.769531 23.757812 0 24.8125 20.1875 45 45 45h302c24.8125 0 45-20.1875 45-45 0-8.445312-2.339844-16.660156-6.765625-23.757812zm-23.234375 249.757812h-30v-30h30zm0-60h-30v-106h30zm0 0""></path></svg></span>
            <h4 class=""u-text u-text-1"">Table</h4>
            <p class=""u-small-text u-text u-text-font u-text-variant u-text-2"">Repair</p><span class=""u-icon u-icon-circle u-text-custom-color-1 u-icon-2"">
                <svg class=""u-svg-link"" preserveAspectRatio=""xMidYMin slice"" viewBox=""0 0 490.434 490.433""");
                BeginWriteAttribute("style", " style=\"", 10563, "\"", 10571, 0);
                EndWriteAttribute();
                WriteLiteral(@"><use xmlns:xlink=""http://www.w3.org/1999/xlink"" xlink:href=""#svg-a077""></use></svg><svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" version=""1.1"" xml:space=""preserve"" class=""u-svg-content"" viewBox=""0 0 490.434 490.433"" x=""0px"" y=""0px"" id=""svg-a077"" style=""enable-background:new 0 0 490.434 490.433;""><g><path d=""M472.003,58.36l-13.132-11.282c-21.798-18.732-54.554-16.644-73.799,4.697L165.39,295.359l-66.312-57.112   c-21.775-18.753-54.536-16.707-73.804,4.611l-11.611,12.848c-9.416,10.413-14.305,24.149-13.595,38.18   c0.717,14.023,6.973,27.188,17.402,36.6l121.553,111.311c10.524,9.883,24.628,15.037,39.044,14.272   c14.416-0.763,27.894-7.386,37.311-18.329l262.245-304.71c9.162-10.646,13.717-24.494,12.661-38.496   C489.229,80.522,482.655,67.512,472.003,58.36z""></path>
</g></svg>
            </span>
        </div>
    </section>
    <section class=""u-clearfix u-section-5"" id=""carousel_2398"">
        <div class=""u-clearfix u-sheet u-valign-middle-xs u-sheet-1"">
            <span ");
                WriteLiteral("class=\"u-icon u-icon-rounded u-palette-2-light-1 u-radius-10 u-spacing-10 u-text-white u-icon-1\"><svg class=\"u-svg-link\" preserveAspectRatio=\"xMidYMin slice\" viewBox=\"0 -30 512 512\"");
                BeginWriteAttribute("style", " style=\"", 11777, "\"", 11785, 0);
                EndWriteAttribute();
                WriteLiteral(@"><use xmlns:xlink=""http://www.w3.org/1999/xlink"" xlink:href=""#svg-b8f8""></use></svg><svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" version=""1.1"" xml:space=""preserve"" class=""u-svg-content"" viewBox=""0 -30 512 512"" id=""svg-b8f8""><path d=""m496.136719 291.480469-151-242c-19.332031-30.984375-52.65625-49.480469-89.136719-49.480469s-69.804688 18.496094-89.136719 49.480469l-151 242c-10.378906 16.632812-15.863281 35.832031-15.863281 55.519531 0 57.898438 47.101562 105 105 105h302c57.898438 0 105-47.101562 105-105 0-19.6875-5.484375-38.886719-15.863281-55.519531zm-89.136719 130.519531h-302c-41.355469 0-75-33.644531-75-75 0-14.066406 3.914062-27.773438 11.316406-39.636719l151-242c13.816406-22.144531 37.621094-35.363281 63.683594-35.363281s49.867188 13.21875 63.683594 35.363281l151 242c7.402344 11.863281 11.316406 25.570313 11.316406 39.636719 0 41.355469-33.644531 75-75 75zm0 0""></path><path d=""m294.234375 81.242188c-8.300781-13.300782-22.59375-21.242188-38.234375-21.242188s-29.933594 ");
                WriteLiteral(@"7.941406-38.234375 21.242188l-150.996094 242c-4.429687 7.097656-6.769531 15.3125-6.769531 23.757812 0 24.8125 20.1875 45 45 45h302c24.8125 0 45-20.1875 45-45 0-8.445312-2.339844-16.660156-6.765625-23.757812zm-23.234375 249.757812h-30v-30h30zm0-60h-30v-106h30zm0 0""></path></svg></span>
            <h4 class=""u-text u-text-1"">Wall</h4>
            <p class=""u-small-text u-text u-text-font u-text-variant u-text-2"">Repair</p><span class=""u-icon u-icon-circle u-text-custom-color-1 u-icon-2"">
                <svg class=""u-svg-link"" preserveAspectRatio=""xMidYMin slice"" viewBox=""0 0 490.434 490.433""");
                BeginWriteAttribute("style", " style=\"", 13411, "\"", 13419, 0);
                EndWriteAttribute();
                WriteLiteral(@"><use xmlns:xlink=""http://www.w3.org/1999/xlink"" xlink:href=""#svg-ba13""></use></svg><svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" version=""1.1"" xml:space=""preserve"" class=""u-svg-content"" viewBox=""0 0 490.434 490.433"" x=""0px"" y=""0px"" id=""svg-ba13"" style=""enable-background:new 0 0 490.434 490.433;""><g><path d=""M472.003,58.36l-13.132-11.282c-21.798-18.732-54.554-16.644-73.799,4.697L165.39,295.359l-66.312-57.112   c-21.775-18.753-54.536-16.707-73.804,4.611l-11.611,12.848c-9.416,10.413-14.305,24.149-13.595,38.18   c0.717,14.023,6.973,27.188,17.402,36.6l121.553,111.311c10.524,9.883,24.628,15.037,39.044,14.272   c14.416-0.763,27.894-7.386,37.311-18.329l262.245-304.71c9.162-10.646,13.717-24.494,12.661-38.496   C489.229,80.522,482.655,67.512,472.003,58.36z""></path>
</g></svg>
            </span>
        </div>
    </section>
    <section class=""u-clearfix u-section-6"" id=""carousel_f425"">
        <div class=""u-clearfix u-sheet u-valign-middle-xs u-sheet-1"">
            <span ");
                WriteLiteral("class=\"u-icon u-icon-rounded u-palette-2-light-1 u-radius-10 u-spacing-10 u-text-white u-icon-1\"><svg class=\"u-svg-link\" preserveAspectRatio=\"xMidYMin slice\" viewBox=\"0 -30 512 512\"");
                BeginWriteAttribute("style", " style=\"", 14625, "\"", 14633, 0);
                EndWriteAttribute();
                WriteLiteral(@"><use xmlns:xlink=""http://www.w3.org/1999/xlink"" xlink:href=""#svg-b8f8""></use></svg><svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" version=""1.1"" xml:space=""preserve"" class=""u-svg-content"" viewBox=""0 -30 512 512"" id=""svg-b8f8""><path d=""m496.136719 291.480469-151-242c-19.332031-30.984375-52.65625-49.480469-89.136719-49.480469s-69.804688 18.496094-89.136719 49.480469l-151 242c-10.378906 16.632812-15.863281 35.832031-15.863281 55.519531 0 57.898438 47.101562 105 105 105h302c57.898438 0 105-47.101562 105-105 0-19.6875-5.484375-38.886719-15.863281-55.519531zm-89.136719 130.519531h-302c-41.355469 0-75-33.644531-75-75 0-14.066406 3.914062-27.773438 11.316406-39.636719l151-242c13.816406-22.144531 37.621094-35.363281 63.683594-35.363281s49.867188 13.21875 63.683594 35.363281l151 242c7.402344 11.863281 11.316406 25.570313 11.316406 39.636719 0 41.355469-33.644531 75-75 75zm0 0""></path><path d=""m294.234375 81.242188c-8.300781-13.300782-22.59375-21.242188-38.234375-21.242188s-29.933594 ");
                WriteLiteral(@"7.941406-38.234375 21.242188l-150.996094 242c-4.429687 7.097656-6.769531 15.3125-6.769531 23.757812 0 24.8125 20.1875 45 45 45h302c24.8125 0 45-20.1875 45-45 0-8.445312-2.339844-16.660156-6.765625-23.757812zm-23.234375 249.757812h-30v-30h30zm0-60h-30v-106h30zm0 0""></path></svg></span>
            <h4 class=""u-text u-text-1"">Door</h4>
            <p class=""u-small-text u-text u-text-font u-text-variant u-text-2"">Repair</p><span class=""u-icon u-icon-circle u-text-custom-color-1 u-icon-2"">
                <svg class=""u-svg-link"" preserveAspectRatio=""xMidYMin slice"" viewBox=""0 0 490.434 490.433""");
                BeginWriteAttribute("style", " style=\"", 16259, "\"", 16267, 0);
                EndWriteAttribute();
                WriteLiteral(@"><use xmlns:xlink=""http://www.w3.org/1999/xlink"" xlink:href=""#svg-9857""></use></svg><svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" version=""1.1"" xml:space=""preserve"" class=""u-svg-content"" viewBox=""0 0 490.434 490.433"" x=""0px"" y=""0px"" id=""svg-9857"" style=""enable-background:new 0 0 490.434 490.433;""><g><path d=""M472.003,58.36l-13.132-11.282c-21.798-18.732-54.554-16.644-73.799,4.697L165.39,295.359l-66.312-57.112   c-21.775-18.753-54.536-16.707-73.804,4.611l-11.611,12.848c-9.416,10.413-14.305,24.149-13.595,38.18   c0.717,14.023,6.973,27.188,17.402,36.6l121.553,111.311c10.524,9.883,24.628,15.037,39.044,14.272   c14.416-0.763,27.894-7.386,37.311-18.329l262.245-304.71c9.162-10.646,13.717-24.494,12.661-38.496   C489.229,80.522,482.655,67.512,472.003,58.36z""></path>
</g></svg>
            </span>
        </div>
    </section>
    <section class=""u-align-left-xs u-clearfix u-gradient u-section-7"" id=""sec-cf73"">
        <div class=""u-clearfix u-sheet u-sheet-1"">
            <di");
                WriteLiteral(@"v class=""u-preserve-proportions u-radius-20 u-shape u-shape-round u-white u-shape-1""></div>
        </div>
    </section>
    <section class=""u-clearfix u-grey-10 u-section-8"" id=""sec-4ae5"">
        <div class=""u-clearfix u-sheet u-sheet-1""></div>
    </section>


    ");
#nullable restore
#line 113 "/Users/jeff/Projects/ANSR/ANSR/Views/Home/CompletedIssues.cshtml"
Write(Html.Partial("Footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591