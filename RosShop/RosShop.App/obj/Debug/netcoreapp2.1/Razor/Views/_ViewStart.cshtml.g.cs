#pragma checksum "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Views\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfbce7a4e63a91ba237e14562c81e4b62d615817"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__ViewStart), @"mvc.1.0.view", @"/Views/_ViewStart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/_ViewStart.cshtml", typeof(AspNetCore.Views__ViewStart))]
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
#line 1 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\_ViewImports.cshtml"
using RosShop.App;

#line default
#line hidden
#line 2 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\_ViewImports.cshtml"
using RosShop.App.Models;

#line default
#line hidden
#line 3 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\_ViewImports.cshtml"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfbce7a4e63a91ba237e14562c81e4b62d615817", @"/Views/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba7ba155524846b62b5c7727c6048b9f44bac74", @"/_ViewImports.cshtml")]
    public class Views__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Views\_ViewStart.cshtml"
  

	if (User.IsInRole("Administrator"))
	{
		Layout = "/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
	}
	else
	{
		Layout = "_Layout";
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
