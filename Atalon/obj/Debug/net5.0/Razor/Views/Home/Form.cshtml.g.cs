#pragma checksum "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57e2945dd404989215172383e318b3d91a0403cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Form), @"mvc.1.0.view", @"/Views/Home/Form.cshtml")]
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
#line 1 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\_ViewImports.cshtml"
using Atalon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\_ViewImports.cshtml"
using Atalon.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
using Recaptcha.Web.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57e2945dd404989215172383e318b3d91a0403cf", @"/Views/Home/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9ad5109c1f0f718b10876edf1ef2a30ab6e2c6f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FeedbackFormModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "--Выберите услугу--", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Перевозка песка", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Поставка песка", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Перевозка щебня", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Поставка щебня", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Перевозка ЩПС", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Поставка ЩПС", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Перевозка другого материала", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Поставка другого материала", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("feedbackForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("overflow-y: auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background: #81a6da; margin:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--");
#nullable restore
#line 1 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
      
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>-->\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n<link rel=\"stylesheet\" href=\"../css/Form.css\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57e2945dd404989215172383e318b3d91a0403cf8480", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"form-page\">\r\n<div class=\"form-container\">\r\n");
#nullable restore
#line 21 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
     using (Html.BeginForm("Index", "Feedback", FormMethod.Post, new { id = "feedbackForm" }))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
                                
        //для защиты от подделки межсайтовых запросов (CSRF).


#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57e2945dd404989215172383e318b3d91a0403cf9538", async() => {
                    WriteLiteral("\r\n            <h2>Форма обратной связи</h2>\r\n\r\n            <div>\r\n                ");
#nullable restore
#line 30 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.Label("Название организации"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
#nullable restore
#line 31 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.TextBoxFor(model => model.OrganizationName, new { required = "required" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
#nullable restore
#line 32 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.ValidationMessageFor(model => model.OrganizationName));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>\r\n\r\n             <div>\r\n                ");
#nullable restore
#line 36 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
#nullable restore
#line 37 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.TextBoxFor(model => model.Email, new {type="email", required = "required", style = "width: 100%;padding: 8px;" +
                $"margin-bottom: 10px;border: 1px solid #ccc; border-radius: 3px; resize: vertical;" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
#nullable restore
#line 39 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                ");
#nullable restore
#line 43 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.Label("Название услуги"));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                <select id=""ServiceName"" name=""ServiceName"" style=""width: 100%;padding: 8px;margin-bottom: 10px;
                                                                   border: 1px solid #ccc;border-radius: 3px;resize: vertical;"">
                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57e2945dd404989215172383e318b3d91a0403cf12324", async() => {
                        WriteLiteral("--Выберите услугу--");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57e2945dd404989215172383e318b3d91a0403cf13645", async() => {
                        WriteLiteral("Перевозка песка");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57e2945dd404989215172383e318b3d91a0403cf14962", async() => {
                        WriteLiteral("Поставка песка");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57e2945dd404989215172383e318b3d91a0403cf16278", async() => {
                        WriteLiteral("Перевозка щебня");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57e2945dd404989215172383e318b3d91a0403cf17595", async() => {
                        WriteLiteral("Поставка щебня");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57e2945dd404989215172383e318b3d91a0403cf18911", async() => {
                        WriteLiteral("Перевозка ЩПС");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57e2945dd404989215172383e318b3d91a0403cf20226", async() => {
                        WriteLiteral("Поставка ЩПС");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57e2945dd404989215172383e318b3d91a0403cf21540", async() => {
                        WriteLiteral("Перевозка другого материала");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57e2945dd404989215172383e318b3d91a0403cf22869", async() => {
                        WriteLiteral("Поставка другого материала");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                </select>\r\n                ");
#nullable restore
#line 56 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.ValidationMessageFor(model => model.ServiceName));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>\r\n\r\n             <div id=\"AnotherMaterial\" style=\"display: none;\">\r\n                ");
#nullable restore
#line 60 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.Label("Название другого материала"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
#nullable restore
#line 61 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.TextBoxFor(model => model.AnotherMaterial));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
#nullable restore
#line 62 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.ValidationMessageFor(model => model.AnotherMaterial));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"fromLocationContainer\">\r\n                ");
#nullable restore
#line 66 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.Label("Откуда везем"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
#nullable restore
#line 67 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.TextAreaFor(model => model.FromLocation, new{ @class= "ToLocation", style = "width: 100%;padding: 8px;" +
                $"margin-bottom: 10px;border: 1px solid #ccc; border-radius: 3px; resize: vertical;"}));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
#nullable restore
#line 69 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.ValidationMessageFor(model => model.FromLocation));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                ");
#nullable restore
#line 73 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.Label("Куда везем"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
#nullable restore
#line 74 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.TextAreaFor(model => model.ToLocation, new { required = "required", @class= "ToLocation", style = "width: 100%;padding: 8px;" +
                $"margin-bottom: 10px;border: 1px solid #ccc; border-radius: 3px; resize: vertical;" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
#nullable restore
#line 76 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.ValidationMessageFor(model => model.ToLocation));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                ");
#nullable restore
#line 80 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.Label("До какого числа доставить"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        ");
#nullable restore
#line 81 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
                   Write(Html.TextBoxFor(model => model.DeliveryDate, new { type = "date", required = "required", style = "width: 100%;padding: 8px;" +
                $"margin-bottom: 10px;border: 1px solid #ccc; border-radius: 3px; resize: vertical;" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
#nullable restore
#line 83 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.ValidationMessageFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                ");
#nullable restore
#line 87 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.Label("Телефон"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        ");
#nullable restore
#line 88 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
                   Write(Html.TextBoxFor(model => model.PhoneNumber, new {required = "required" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
#nullable restore
#line 89 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.ValidationMessageFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                ");
#nullable restore
#line 93 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.Label("Как к Вам обращаться"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
#nullable restore
#line 94 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.TextBoxFor(model => model.Greeting, new { required = "required" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
#nullable restore
#line 95 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
           Write(Html.ValidationMessageFor(model => model.Greeting));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>\r\n\r\n            \r\n            <div style=\"display:flex;justify-content: center;\">\r\n            ");
#nullable restore
#line 100 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
       Write(Html.RecaptchaWidget());

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n           </div>\r\n        <div class=\"privacy-policy\" style=\"text-align: center;margin-top: 13px;\">\r\n            <p>Нажимая на кнопку \"Отправить\", Вы соглашаетесь с ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57e2945dd404989215172383e318b3d91a0403cf30850", async() => {
                        WriteLiteral("условиями конфиденциальности");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(".</p>\r\n        </div>\r\n\r\n            <h4><button id=\"submitButton\" type=\"submit\">Отправить</button></h4>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 108 "C:\Users\Misha\source\repos\Atalon\Atalon\Views\Home\Form.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src='https://www.google.com/recaptcha/api.js'></script>

    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""./js/scripts.js""></script>
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>

    <script src='https://www.google.com/recaptcha/api.js'></script>
    <script>
        // При загрузке страницы
        window.onload = function () {
            // Найти форму и кнопку ""Отправить""
            var form = document.getElementById(""feedbackForm"");
            var submitButton = document.getElementById(""submitButton"");

            // При нажатии кнопки ""Отправить""
            submitButton.addEventListener(""click"", function (event) {
                // Отменить отправку формы, если reCAPTCHA не пройдена
                if (!isRecaptchaCompleted()) {
                    event.preventDefault();
                }
            });

            // Проверка, была ли reCAPTCHA успешно пройдена
          ");
                WriteLiteral(@"  function isRecaptchaCompleted() {
                // Получить ответ reCAPTCHA
                var recaptchaResponse = grecaptcha.getResponse();

                // Проверить, является ли ответ пустым или недействительным
                if (recaptchaResponse === """" || recaptchaResponse === null || recaptchaResponse === undefined) {
                    alert(""Пройдите проверку reCAPTCHA."");
                    return false;
                }

                // reCAPTCHA успешно пройдена
                return true;
            }
        };
    </script>

    <script> 
        var serviceNameSelect = document.getElementById(""ServiceName"");
        var fromLocationContainer = document.getElementById(""fromLocationContainer"");
        var fromAnotherMaterial = document.getElementById(""AnotherMaterial"");
        fromAnotherMaterial.display = ""none"";


        serviceNameSelect.addEventListener(""change"", function () {
            const Postavka = [""Поставка песка"", ""Поставка щебня"", ""Поста");
                WriteLiteral(@"вка ЩПС"", ""Поставка другого материала""];
            const AnotherMat = [""Перевозка другого материала"", ""Поставка другого материала""];

            if (Postavka.includes(serviceNameSelect.value)) {
                fromLocationContainer.style.display = ""none"";
            } else {
                fromLocationContainer.style.display = ""block"";
            }

            if (!AnotherMat.includes(serviceNameSelect.value)) {
                fromAnotherMaterial.style.display = ""none"";
            } else {
                fromAnotherMaterial.style.display = ""block"";
            }
        });

    </script>

    <!--<script>
        $(document).ready(function () {
            $('.ToLocation').on('input', function () {
                this.style.height = 'auto';
                this.style.height = (this.scrollHeight) + 'px';
            });
        });
    </script>-->

    <script>
        $(document).ready(function () {
            $('.ToLocation').on('input', function () {
            ");
                WriteLiteral("    this.style.height = \'auto\';\r\n                this.style.height = this.scrollHeight + \'px\';\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FeedbackFormModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
