#pragma checksum "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28dd57718524828d8e5e027eadc5faf899c8941b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_Users_Details), @"mvc.1.0.view", @"/Areas/Users/Views/Users/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Users/Views/Users/Details.cshtml", typeof(AspNetCore.Areas_Users_Views_Users_Details))]
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
#line 1 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\_ViewImports.cshtml"
using RosShop.App;

#line default
#line hidden
#line 2 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\_ViewImports.cshtml"
using RosShop.App.Models;

#line default
#line hidden
#line 3 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\_ViewImports.cshtml"
using RosShop.Data.Models;

#line default
#line hidden
#line 4 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\_ViewImports.cshtml"
using RosShop.Services.Models;

#line default
#line hidden
#line 5 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\_ViewImports.cshtml"
using RosShop.App.Areas.Admin.Models;

#line default
#line hidden
#line 4 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\_ViewImports.cshtml"
using RosShop.Services.Models.Users;

#line default
#line hidden
#line 5 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\_ViewImports.cshtml"
using RosShop.App.Areas.Users.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28dd57718524828d8e5e027eadc5faf899c8941b", @"/Areas/Users/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba7ba155524846b62b5c7727c6048b9f44bac74", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e5ecdf3259056d0eb082a558d501fff3eba5017", @"/Areas/Users/Views/_ViewImports.cshtml")]
    public class Areas_Users_Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetailsUsersProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "ShopingCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShopingCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShopingCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 140, true);
            WriteLiteral("\r\n\r\n<h2>Details </h2>\r\n\r\n<div class=\"container-fluid\">\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-12\">\r\n\t\t\t<img class=\"img-circle\" />\r\n\r\n\t\t\t<h4>");
            EndContext();
            BeginContext(178, 30, false);
#line 11 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\Users\Details.cshtml"
           Write(Model.DetailsProductModel.Type);

#line default
#line hidden
            EndContext();
            BeginContext(208, 14, true);
            WriteLiteral("</h4>\r\n\t\t\t<h4>");
            EndContext();
            BeginContext(223, 35, false);
#line 12 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\Users\Details.cshtml"
           Write(Model.DetailsProductModel.BrandName);

#line default
#line hidden
            EndContext();
            BeginContext(258, 14, true);
            WriteLiteral("</h4>\r\n\t\t\t<h4>");
            EndContext();
            BeginContext(273, 37, false);
#line 13 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\Users\Details.cshtml"
           Write(Model.DetailsProductModel.NameOfModel);

#line default
#line hidden
            EndContext();
            BeginContext(310, 56, true);
            WriteLiteral("</h4>\r\n\t\t\t<p class=\"card-text\"><strong>Price</strong> - ");
            EndContext();
            BeginContext(367, 31, false);
#line 14 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\Users\Details.cshtml"
                                                     Write(Model.DetailsProductModel.Price);

#line default
#line hidden
            EndContext();
            BeginContext(398, 54, true);
            WriteLiteral("</p>\r\n\t\t\t<p class=\"card-text\"><strong>Size</strong> - ");
            EndContext();
            BeginContext(453, 38, false);
#line 15 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\Users\Details.cshtml"
                                                    Write(Model.DetailsProductModel.NumberOfSize);

#line default
#line hidden
            EndContext();
            BeginContext(491, 30, true);
            WriteLiteral("</p>\r\n\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(522, 37, false);
#line 16 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\Users\Details.cshtml"
                            Write(Model.DetailsProductModel.Description);

#line default
#line hidden
            EndContext();
            BeginContext(559, 30, true);
            WriteLiteral("</p>\r\n\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(590, 32, false);
#line 17 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\Users\Details.cshtml"
                            Write(Model.DetailsProductModel.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(622, 30, true);
            WriteLiteral("</p>\r\n\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(653, 31, false);
#line 18 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\Users\Details.cshtml"
                            Write(Model.DetailsProductModel.Color);

#line default
#line hidden
            EndContext();
            BeginContext(684, 11, true);
            WriteLiteral("</p>\r\n\r\n\t\t\t");
            EndContext();
            BeginContext(695, 307, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9bb12a99c7b40d2b3253ea8e45e6eff", async() => {
                BeginContext(861, 10, true);
                WriteLiteral("\r\n\t\t\t\t<!--");
                EndContext();
                BeginContext(872, 43, false);
#line 21 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\Users\Details.cshtml"
               Write(Html.HiddenFor(i=>i.DetailsProductModel.Id));

#line default
#line hidden
                EndContext();
                BeginContext(915, 80, true);
                WriteLiteral("-->\r\n\t\t\t\t<button class=\"btn btn-success\" type=\"submit\">Add to card</button>\r\n\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Users\Views\Users\Details.cshtml"
                                                                                                 WriteLiteral(Model.DetailsProductModel.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1002, 30, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsUsersProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
