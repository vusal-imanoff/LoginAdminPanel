#pragma checksum "C:\Users\user\Downloads\Login\P225Allup\P225Allup\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7c9e50ebdde54589049ce8c9c5dd2763a1c0cc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 2 "C:\Users\user\Downloads\Login\P225Allup\P225Allup\Views\_ViewImports.cshtml"
using P225Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Downloads\Login\P225Allup\P225Allup\Views\_ViewImports.cshtml"
using P225Allup.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Downloads\Login\P225Allup\P225Allup\Views\_ViewImports.cshtml"
using P225Allup.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Downloads\Login\P225Allup\P225Allup\Views\_ViewImports.cshtml"
using P225Allup.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Downloads\Login\P225Allup\P225Allup\Views\_ViewImports.cshtml"
using P225Allup.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c9e50ebdde54589049ce8c9c5dd2763a1c0cc9", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d754142dc10bb7594d12a03309532143c1dc13b", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://demo.hasthemes.com/allup/allup/assets/contact.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\user\Downloads\Login\P225Allup\P225Allup\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <!--====== Breadcrumb Part Start ======-->

    <div class=""breadcrumb-area"">
        <div class=""container-fluid custom-container"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                    <li class=""breadcrumb-item active"">Contact</li>
                </ol>
            </nav>
        </div> <!-- container -->
    </div>

    <!--====== Breadcrumb Part Ends ======-->

    <!--====== Contact PART START ======-->

    <div class=""contact-map-area pt-50"">
        <div id=""contact-map""></div>
    </div>

    <!--====== Contact PART ENDS ======-->

    <!--====== Contact Part Start ======-->

    <section class=""contact-page pt-20"">
        <div class=""container-fluid custom-container"">
            <div class=""row"">
                <div class=""col-lg-7 col-xl-8"">
                    <div class=""contact-form mt-30"">
                        <h4 class=""allup-title"">Billing Address</h4>");
            WriteLiteral("\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7c9e50ebdde54589049ce8c9c5dd2763a1c0cc96184", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""single-form"">
                                        <input type=""text"" name=""name"" placeholder=""Your Name"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""single-form"">
                                        <input type=""email"" name=""email"" placeholder=""Your Email"">
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                                    <div class=""single-form"">
                                        <input type=""text"" name=""subject"" placeholder=""Subject"">
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                               ");
                WriteLiteral(@"     <div class=""single-form"">
                                        <textarea name=""message"" placeholder=""Your Message""></textarea>
                                    </div>
                                </div>
                                <p class=""form-message""></p>
                                <div class=""col-md-12"">
                                    <div class=""single-form"">
                                        <button class=""main-btn main-btn-2"">Send Message</button>
                                    </div>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-lg-5 col-xl-4"">
                    <div class=""contact-info mt-30"">
                        <h4 class=""title"">Contact Us</h4>
                        <p class=""text"">Claritas est etiam processus dynamicus, qui sequitur mutationem consuetudium lectorum. Mirum est notare quam littera gothica, quam nunc putamus parum claram anteposuerit litterarum formas human.</p>

                        <ul class=""contact-info-block"">
                            <li>
                                <div class=""single-info"">
                                    <div class=""info-icon-title d-flex align-item-center"">
                                        <div class=""info-icon"">
                                            <i class=""icon ion-map""></i>
                                        </div>
                                        <h5 class=""info-title media-body"">Address</h5>
                                    </div>
                      ");
            WriteLiteral(@"              <p>123 Main Street, Anytown, CA 12345 – USA</p>
                                </div>
                            </li>
                            <li>
                                <div class=""single-info"">
                                    <div class=""info-icon-title d-flex align-item-center"">
                                        <div class=""info-icon"">
                                            <i class=""icon ion-ios-telephone-outline""></i>
                                        </div>
                                        <h5 class=""info-title media-body"">Phone</h5>
                                    </div>
                                    <p>Mobile: (08) 123 456 789</p>
                                    <p>Hotline: 1009 678 456</p>
                                </div>
                            </li>
                            <li>
                                <div class=""single-info"">
                                    <div class=""info-icon-title d-flex align-ite");
            WriteLiteral(@"m-center"">
                                        <div class=""info-icon"">
                                            <i class=""icon ion-ios-email-outline""></i>
                                        </div>
                                        <h5 class=""info-title media-body"">Email</h5>
                                    </div>
                                    <p>yourmail@domain.com</p>
                                    <p>support@hastech.company</p>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!--====== Contact Part Ends ======-->");
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
