#pragma checksum "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7d73d968a246653d5e82a1d3c9b1db5adf66c76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RosShop.App.Areas.Admin.Admin.Areas_Admin_Views_Admin_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Admin/Details.cshtml", typeof(RosShop.App.Areas.Admin.Admin.Areas_Admin_Views_Admin_Details))]
namespace RosShop.App.Areas.Admin.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\_ViewImports.cshtml"
using RosShop.App;

#line default
#line hidden
#line 2 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\_ViewImports.cshtml"
using RosShop.App.Models;

#line default
#line hidden
#line 3 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\_ViewImports.cshtml"
using RosShop.Data.Models;

#line default
#line hidden
#line 5 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\_ViewImports.cshtml"
using RosShop.Services.Models;

#line default
#line hidden
#line 4 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\_ViewImports.cshtml"
using RosShop.App.Areas.Admin.Models;

#line default
#line hidden
#line 6 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\_ViewImports.cshtml"
using RosShop.Services.Models.ShopingCard;

#line default
#line hidden
#line 7 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\_ViewImports.cshtml"
using RosShop.App.Areas.Admin.Models.Shipper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7d73d968a246653d5e82a1d3c9b1db5adf66c76", @"/Areas/Admin/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba7ba155524846b62b5c7727c6048b9f44bac74", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b56900d15182f01e20e03f74d066ac4c78e6ceb6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetailsProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-image-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:250px;height:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\Admin\Details.cshtml"
  
    ViewData["Title"] = "Details";
	var photoPath = "~/Images/" + (Model.DetailsProductModel.ImagePath ?? "noimage.jpg");

#line default
#line hidden
            BeginContext(163, 101, true);
            WriteLiteral("\r\n<h2>Details </h2>\r\n\r\n<div class=\"container-fluid\">\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-12\">\r\n\t\t\t");
            EndContext();
            BeginContext(264, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fb8434ceff65443595852d8cdd65dc2c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 12 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\Admin\Details.cshtml"
                                 WriteLiteral(photoPath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\Admin\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(371, 11, true);
            WriteLiteral("\r\n\r\n\t\t\t<h4>");
            EndContext();
            BeginContext(383, 30, false);
#line 14 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\Admin\Details.cshtml"
           Write(Model.DetailsProductModel.Type);

#line default
#line hidden
            EndContext();
            BeginContext(413, 14, true);
            WriteLiteral("</h4>\r\n\t\t\t<h4>");
            EndContext();
            BeginContext(428, 35, false);
#line 15 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\Admin\Details.cshtml"
           Write(Model.DetailsProductModel.BrandName);

#line default
#line hidden
            EndContext();
            BeginContext(463, 14, true);
            WriteLiteral("</h4>\r\n\t\t\t<h4>");
            EndContext();
            BeginContext(478, 37, false);
#line 16 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\Admin\Details.cshtml"
           Write(Model.DetailsProductModel.NameOfModel);

#line default
#line hidden
            EndContext();
            BeginContext(515, 56, true);
            WriteLiteral("</h4>\r\n\t\t\t<p class=\"card-text\"><strong>Price</strong> - ");
            EndContext();
            BeginContext(572, 31, false);
#line 17 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\Admin\Details.cshtml"
                                                     Write(Model.DetailsProductModel.Price);

#line default
#line hidden
            EndContext();
            BeginContext(603, 54, true);
            WriteLiteral("</p>\r\n\t\t\t<p class=\"card-text\"><strong>Size</strong> - ");
            EndContext();
            BeginContext(658, 38, false);
#line 18 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\Admin\Details.cshtml"
                                                    Write(Model.DetailsProductModel.NumberOfSize);

#line default
#line hidden
            EndContext();
            BeginContext(696, 30, true);
            WriteLiteral("</p>\r\n\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(727, 37, false);
#line 19 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\Admin\Details.cshtml"
                            Write(Model.DetailsProductModel.Description);

#line default
#line hidden
            EndContext();
            BeginContext(764, 30, true);
            WriteLiteral("</p>\r\n\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(795, 32, false);
#line 20 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\Admin\Details.cshtml"
                            Write(Model.DetailsProductModel.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(827, 30, true);
            WriteLiteral("</p>\r\n\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(858, 31, false);
#line 21 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\Admin\Details.cshtml"
                            Write(Model.DetailsProductModel.Color);

#line default
#line hidden
            EndContext();
            BeginContext(889, 9, true);
            WriteLiteral("</p>\r\n\t\t\t");
            EndContext();
            BeginContext(898, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddaf0fa0775e4c38a4846dc700c071a1", async() => {
                BeginContext(1028, 5, true);
                WriteLiteral("Edit ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\Admin\Details.cshtml"
                                                                                                   WriteLiteral(Model.DetailsProductModel.Id);

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
            BeginContext(1037, 5, true);
            WriteLiteral("\r\n\t\t\t");
            EndContext();
            BeginContext(1042, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "705a786fcb504153ac0b046126090f0f", async() => {
                BeginContext(1174, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\Admin\Details.cshtml"
                                                                                                     WriteLiteral(Model.DetailsProductModel.Id);

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
            BeginContext(1184, 5, true);
            WriteLiteral("\r\n\t\t\t");
            EndContext();
            BeginContext(1189, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c813ba864b54b1999c246d1dbbfa521", async() => {
                BeginContext(1326, 12, true);
                WriteLiteral("Change Image");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\Admin\Views\Admin\Details.cshtml"
                                                                                                          WriteLiteral(Model.DetailsProductModel.Id);

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
            BeginContext(1342, 29, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
