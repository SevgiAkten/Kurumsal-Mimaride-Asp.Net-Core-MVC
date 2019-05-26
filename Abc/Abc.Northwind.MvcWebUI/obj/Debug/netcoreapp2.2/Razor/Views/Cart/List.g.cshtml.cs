#pragma checksum "C:\Users\Sevgi AKTEN\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Cart\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b345881a80e59c25fe307fd07084b9e96fb9ece"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_List), @"mvc.1.0.view", @"/Views/Cart/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/List.cshtml", typeof(AspNetCore.Views_Cart_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b345881a80e59c25fe307fd07084b9e96fb9ece", @"/Views/Cart/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72128193af89fb6e59ccd8fd70c12cfa7eb30861", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Abc.Northwind.MvcWebUI.Models.CartListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Complete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Sevgi AKTEN\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Cart\List.cshtml"
  
	ViewData["Title"] = "List";
	Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 169, true);
            WriteLiteral("\r\n<h2>Your Cart</h2>\r\n<table class=\"table\">\r\n\t<tr>\r\n\t\t<td>Product Name</td>\r\n\t\t<td>Unit Price</td>\r\n\t\t<td>Units In Stock</td>\r\n\t\t<td>Quantity</td>\r\n\t\t<td></td>\r\n\t</tr>\r\n");
            EndContext();
#line 16 "C:\Users\Sevgi AKTEN\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Cart\List.cshtml"
     foreach (var item in Model.Cart.CartLines)
	{

#line default
#line hidden
            BeginContext(349, 15, true);
            WriteLiteral("\t\t<tr>\r\n\t\t\t<td>");
            EndContext();
            BeginContext(365, 24, false);
#line 19 "C:\Users\Sevgi AKTEN\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Cart\List.cshtml"
           Write(item.Product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(389, 14, true);
            WriteLiteral("</td>\r\n\t\t\t<td>");
            EndContext();
            BeginContext(404, 22, false);
#line 20 "C:\Users\Sevgi AKTEN\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Cart\List.cshtml"
           Write(item.Product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(426, 14, true);
            WriteLiteral("</td>\r\n\t\t\t<td>");
            EndContext();
            BeginContext(441, 25, false);
#line 21 "C:\Users\Sevgi AKTEN\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Cart\List.cshtml"
           Write(item.Product.UnitsInStock);

#line default
#line hidden
            EndContext();
            BeginContext(466, 14, true);
            WriteLiteral("</td>\r\n\t\t\t<td>");
            EndContext();
            BeginContext(481, 13, false);
#line 22 "C:\Users\Sevgi AKTEN\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Cart\List.cshtml"
           Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(494, 33, true);
            WriteLiteral("</td>\r\n\t\t\t<td class=\"text-right\">");
            EndContext();
            BeginContext(527, 189, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b345881a80e59c25fe307fd07084b9e96fb9ece7671", async() => {
                BeginContext(648, 64, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-remove\"></span>remove from cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "C:\Users\Sevgi AKTEN\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Cart\List.cshtml"
                                                                                                                       WriteLiteral(item.Product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(716, 16, true);
            WriteLiteral("</td>\r\n\t\t</tr>\r\n");
            EndContext();
#line 25 "C:\Users\Sevgi AKTEN\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Cart\List.cshtml"
	}

#line default
#line hidden
            BeginContext(736, 130, true);
            WriteLiteral("\t<tr>\r\n\t\t<td></td>\r\n\t\t<td></td>\r\n\t\t<td></td>\r\n\t\t<td>\r\n\t\t\t<h3>Total</h3>\r\n\t\t</td>\r\n\t\t<td class=\"text-right\">\r\n\t\t\t<h3>\r\n\t\t\t\t<strong>");
            EndContext();
            BeginContext(867, 16, false);
#line 35 "C:\Users\Sevgi AKTEN\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Cart\List.cshtml"
                   Write(Model.Cart.Total);

#line default
#line hidden
            EndContext();
            BeginContext(883, 116, true);
            WriteLiteral("</strong>\r\n\t\t\t</h3>\r\n\t\t</td>\r\n\t</tr>\r\n\t<tr>\r\n\t\t<td></td>\r\n\t\t<td></td>\r\n\t\t<td></td>\r\n\t\t<td>\r\n\t\t<td></td>\r\n\t\t<td>\r\n\t\t\t");
            EndContext();
            BeginContext(999, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b345881a80e59c25fe307fd07084b9e96fb9ece11401", async() => {
                BeginContext(1077, 83, true);
                WriteLiteral("\r\n\t\t\t\t<span class=\"glyphicon glyphicon-shopping-play\"></span>Continue Shopping\r\n\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1164, 22, true);
            WriteLiteral("\r\n\t\t</td>\r\n\t\t<td>\r\n\t\t\t");
            EndContext();
            BeginContext(1186, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b345881a80e59c25fe307fd07084b9e96fb9ece13187", async() => {
                BeginContext(1264, 80, true);
                WriteLiteral("\r\n\t\t\t\t<span class=\"glyphicon glyphicon-shopping-play\"></span>Go To Checkout\r\n\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1348, 27, true);
            WriteLiteral("\r\n\t\t</td>\r\n\t</tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abc.Northwind.MvcWebUI.Models.CartListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
