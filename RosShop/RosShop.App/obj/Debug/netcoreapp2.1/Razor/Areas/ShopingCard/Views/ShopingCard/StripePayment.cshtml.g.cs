#pragma checksum "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\ShopingCard\Views\ShopingCard\StripePayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a90678fb09719e03629ff8b53d252c7d6a07a32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RosShop.App.Areas.ShopingCard.ShopingCard.Areas_ShopingCard_Views_ShopingCard_StripePayment), @"mvc.1.0.view", @"/Areas/ShopingCard/Views/ShopingCard/StripePayment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ShopingCard/Views/ShopingCard/StripePayment.cshtml", typeof(RosShop.App.Areas.ShopingCard.ShopingCard.Areas_ShopingCard_Views_ShopingCard_StripePayment))]
namespace RosShop.App.Areas.ShopingCard.ShopingCard
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\ShopingCard\Views\_ViewImports.cshtml"
using RosShop.App;

#line default
#line hidden
#line 2 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\ShopingCard\Views\_ViewImports.cshtml"
using RosShop.App.Models;

#line default
#line hidden
#line 3 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\ShopingCard\Views\_ViewImports.cshtml"
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
#line 4 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\ShopingCard\Views\_ViewImports.cshtml"
using RosShop.Services.Models.ShopingCard;

#line default
#line hidden
#line 5 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\ShopingCard\Views\_ViewImports.cshtml"
using RosShop.App.Areas.ShopingCard.Models.ShopingCard;

#line default
#line hidden
#line 6 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\ShopingCard\Views\_ViewImports.cshtml"
using RosShop.App.Areas.ShopingCard.Models;

#line default
#line hidden
#line 7 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\ShopingCard\Views\_ViewImports.cshtml"
using RosShop.Services.Models.ShopingCard.Stripe;

#line default
#line hidden
#line 1 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\ShopingCard\Views\ShopingCard\StripePayment.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a90678fb09719e03629ff8b53d252c7d6a07a32", @"/Areas/ShopingCard/Views/ShopingCard/StripePayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba7ba155524846b62b5c7727c6048b9f44bac74", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee3b109bf5b0705b2f6b83bbe603dd1da85ca8f2", @"/Areas/ShopingCard/Views/_ViewImports.cshtml")]
    public class Areas_ShopingCard_Views_ShopingCard_StripePayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StripeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "ShopingCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShopingCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StripePayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\ShopingCard\Views\ShopingCard\StripePayment.cshtml"
  
	ViewData["Title"] = "StripePayment";

#line default
#line hidden
            BeginContext(163, 146, true);
            WriteLiteral("\r\n<h2>Stripe Payment</h2>\r\n\r\n\r\n<div class=\"container\">\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-md-6 col-sm-offset-3\">\r\n\t\t\t<h2>Stripe Form</h2>\r\n\t\t\t");
            EndContext();
            BeginContext(309, 1066, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6c94582ffbe4f7db2eff273f158c669", async() => {
                BeginContext(426, 942, true);
                WriteLiteral(@"
				<div class=""form-group"">
					<div>
						<label for=""card-number"">Card Number</label>
						<div id=""card-number"">

						</div>
					</div>
				</div>
				<div class=""form-group"">
					<label for=""card-name"">Name</label>
					<input type=""text"" name=""cardName"" class=""form-control"" id=""card-name"" placeholder=""First and Second name"" />
				</div>
				<div class=""form-group"">
					<div class=""form-group"">
						<div class=""row"">
							<div class=""col-md-6"">
								<label for=""card-cvc"">cvc</label>
								<div id=""card-cvc"">

								</div>
							</div>
							<div class=""col-md-6"">
								<label for=""card-exp"">exp</label>
								<div id=""card-exp"">

								</div>
							</div>
						</div>
					</div>
					<div id=""card-errors"" role=""alert""></div>
				</div>
				<div class=""form-group"">
					<button class=""form-control btn btn-primary"">Submit Payment</button>
				</div>				
				
			");
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
            BeginContext(1375, 35, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(1410, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8fa1c828a5d447781b6d494ec70872b", async() => {
                BeginContext(1509, 2, true);
                WriteLiteral("\r\n");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1518, 10, true);
            WriteLiteral("\r\n<div>\r\n\t");
            EndContext();
            BeginContext(1528, 372, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0f8fd7d783a4eb7a7da6e024889e1a8", async() => {
                BeginContext(1627, 157, true);
                WriteLiteral("\r\n\t\t<article>\r\n\t\t\t<label>Amount: $5.00</label>\r\n\t\t</article>\r\n\t\t<script src=\"//checkout.stripe.com/v2/checkout.js\"\r\n\t\t\t\tclass=\"stripe-button\"\r\n\t\t\t\tdata-key=\"");
                EndContext();
                BeginContext(1785, 27, false);
#line 68 "D:\C#\C# Web.ASP.NetCore-Поправка\C# Web.ASP.NetCore-Поправка\RosShop\RosShop.App\Areas\ShopingCard\Views\ShopingCard\StripePayment.cshtml"
                     Write(Stripe.Value.PublishableKey);

#line default
#line hidden
                EndContext();
                BeginContext(1812, 81, true);
                WriteLiteral("\"\r\n\t\t\t\tdata-local=\"auto\"\r\n\t\t\t\tdata-description=\"Sample Charge\">\r\n\r\n\t\t</script>\r\n\t");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1900, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("stripe", async() => {
                BeginContext(1928, 2655, true);
                WriteLiteral(@"
	<script src=""https://js.stripe.com/v3/""></script>

	<script>
		// Create a Stripe client.
		var stripe = Stripe('pk_test_ODaolVcBoP6bGy8JRORgZASz00bVj7bu9I');

		// Create an instance of Elements.
		var elements = stripe.elements();

		// Custom styling can be passed to options when creating an Element.
		// (Note that this demo uses a wider set of styles than the guide below.)
		var style = {
			base: {
				color: '#32325d',
				fontFamily: '""Helvetica Neue"", Helvetica, sans-serif',
				fontSmoothing: 'antialiased',
				fontSize: '16px',
				'::placeholder': {
					color: '#aab7c4'
				}
			},
			invalid: {
				color: '#fa755a',
				iconColor: '#fa755a'
			}
		};

		// Create an instance of the card Element.
		var card = elements.create('cardNumber', {
			classes: {
				base: ""form-control"",
				invalid: ""error""
			}
		});

		var cvc = elements.create('cardCvc', {
			classes: {
				base: ""form-control"",
				invalid: ""error""
			}
		});

		var exp = elements.create(");
                WriteLiteral(@"'cardExpiry', {
			classes: {
				base: ""form-control"",
				invalid: ""error""
			}
		});

		

		// Add an instance of the card Element into the `card-element` <div>.
		card.mount('#card-number');
		cvc.mount('#card-cvc');
		exp.mount('#card-exp');

		// Handle real-time validation errors from the card Element.
		card.addEventListener('change', function (event) {
			var displayError = document.getElementById('card-errors');
			if (event.error) {
				displayError.textContent = event.error.message;
			} else {
				displayError.textContent = '';
			}
		});

		// Handle form submission.
		var form = document.getElementById('payment-form');
		form.addEventListener('submit', function (event) {
			event.preventDefault();

			stripe.createToken(card).then(function (result) {
				if (result.error) {
					// Inform the user if there was an error.
					var errorElement = document.getElementById('card-errors');
					errorElement.textContent = result.error.message;
				} else {
					// Sen");
                WriteLiteral(@"d the token to your server.
					stripeTokenHandler(result.token);
				}
			});
		});

		// Submit the form with the token ID.
		function stripeTokenHandler(token) {
			// Insert the token ID into the form so it gets submitted to the server
			var form = document.getElementById('payment-form');
			var hiddenInput = document.createElement('input');
			hiddenInput.setAttribute('type', 'hidden');
			hiddenInput.setAttribute('name', 'StripeToken');
			hiddenInput.setAttribute('value', token.id);
			form.appendChild(hiddenInput);

			// Submit the form
			form.submit();
		}
	</script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RosShop.App.Data.StripeSettings> Stripe { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StripeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
