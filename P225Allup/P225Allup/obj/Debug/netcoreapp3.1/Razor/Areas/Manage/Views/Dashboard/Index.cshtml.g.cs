#pragma checksum "C:\Users\user\Downloads\Login\P225Allup\P225Allup\Areas\Manage\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e83975dbe11c8843417065b42092081d40f9c93c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Dashboard/Index.cshtml")]
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
#line 2 "C:\Users\user\Downloads\Login\P225Allup\P225Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P225Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Downloads\Login\P225Allup\P225Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P225Allup.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Downloads\Login\P225Allup\P225Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P225Allup.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Downloads\Login\P225Allup\P225Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P225Allup.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Downloads\Login\P225Allup\P225Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P225Allup.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e83975dbe11c8843417065b42092081d40f9c93c", @"/Areas/Manage/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d754142dc10bb7594d12a03309532143c1dc13b", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/img-fluid px-3 px-sm-4 mt-3 mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 25rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/img/undraw_posting_photo.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\user\Downloads\Login\P225Allup\P225Allup\Areas\Manage\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page Heading -->
<div class=""d-sm-flex align-items-center justify-content-between mb-4"">
    <h1 class=""h3 mb-0 text-gray-800"">Dashboard</h1>
    <a href=""#"" class=""d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"">
        <i class=""fas fa-download fa-sm text-white-50""></i> Generate Report
    </a>
</div>

<!-- Content Row -->
<div class=""row"">

    <!-- Earnings (Monthly) Card Example -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-primary shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                            Earnings (Monthly)
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">$40,000</div>
                    </div>
                    <div class=""col-auto"">
                        <i class");
            WriteLiteral(@"=""fas fa-calendar fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Earnings (Monthly) Card Example -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-success shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">
                            Earnings (Annual)
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">$215,000</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-dollar-sign fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Earnings (Monthly) Card Example -->
    <div class=""col-xl-3 col-md-6 mb");
            WriteLiteral(@"-4"">
        <div class=""card border-left-info shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">
                            Tasks
                        </div>
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col-auto"">
                                <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">50%</div>
                            </div>
                            <div class=""col"">
                                <div class=""progress progress-sm mr-2"">
                                    <div class=""progress-bar bg-info"" role=""progressbar""
                                         style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0""
                                         aria-valuemax=""100""></div>
                           ");
            WriteLiteral(@"     </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-clipboard-list fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Pending Requests Card Example -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-warning shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">
                            Pending Requests
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">18</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-comments fa-2x text-gray-300""></i>
   ");
            WriteLiteral(@"                 </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Content Row -->

<div class=""row"">

    <!-- Area Chart -->
    <div class=""col-xl-8 col-lg-7"">
        <div class=""card shadow mb-4"">
            <!-- Card Header - Dropdown -->
            <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                <h6 class=""m-0 font-weight-bold text-primary"">Earnings Overview</h6>
                <div class=""dropdown no-arrow"">
                    <a class=""dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink""
                       data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fas fa-ellipsis-v fa-sm fa-fw text-gray-400""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right shadow animated--fade-in""
                         aria-labelledby=""dropdownMenuLink"">
                        <div class=""dropdown-header"">Dropdown");
            WriteLiteral(@" Header:</div>
                        <a class=""dropdown-item"" href=""#"">Action</a>
                        <a class=""dropdown-item"" href=""#"">Another action</a>
                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""#"">Something else here</a>
                    </div>
                </div>
            </div>
            <!-- Card Body -->
            <div class=""card-body"">
                <div class=""chart-area"">
                    <canvas id=""myAreaChart""></canvas>
                </div>
            </div>
        </div>
    </div>

    <!-- Pie Chart -->
    <div class=""col-xl-4 col-lg-5"">
        <div class=""card shadow mb-4"">
            <!-- Card Header - Dropdown -->
            <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                <h6 class=""m-0 font-weight-bold text-primary"">Revenue Sources</h6>
                <div class=""dropdown no-arrow"">
                    <a class=""dropdown-toggl");
            WriteLiteral(@"e"" href=""#"" role=""button"" id=""dropdownMenuLink""
                       data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fas fa-ellipsis-v fa-sm fa-fw text-gray-400""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right shadow animated--fade-in""
                         aria-labelledby=""dropdownMenuLink"">
                        <div class=""dropdown-header"">Dropdown Header:</div>
                        <a class=""dropdown-item"" href=""#"">Action</a>
                        <a class=""dropdown-item"" href=""#"">Another action</a>
                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""#"">Something else here</a>
                    </div>
                </div>
            </div>
            <!-- Card Body -->
            <div class=""card-body"">
                <div class=""chart-pie pt-4 pb-2"">
                    <canvas id=""myPieChart""></canvas>
                </d");
            WriteLiteral(@"iv>
                <div class=""mt-4 text-center small"">
                    <span class=""mr-2"">
                        <i class=""fas fa-circle text-primary""></i> Direct
                    </span>
                    <span class=""mr-2"">
                        <i class=""fas fa-circle text-success""></i> Social
                    </span>
                    <span class=""mr-2"">
                        <i class=""fas fa-circle text-info""></i> Referral
                    </span>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Content Row -->
<div class=""row"">

    <!-- Content Column -->
    <div class=""col-lg-6 mb-4"">

        <!-- Project Card Example -->
        <div class=""card shadow mb-4"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Projects</h6>
            </div>
            <div class=""card-body"">
                <h4 class=""small font-weight-bold"">
                    Server Migration <span class=""float-right""");
            WriteLiteral(@">20%</span>
                </h4>
                <div class=""progress mb-4"">
                    <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 20%""
                         aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                </div>
                <h4 class=""small font-weight-bold"">
                    Sales Tracking <span class=""float-right"">40%</span>
                </h4>
                <div class=""progress mb-4"">
                    <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 40%""
                         aria-valuenow=""40"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                </div>
                <h4 class=""small font-weight-bold"">
                    Customer Database <span class=""float-right"">60%</span>
                </h4>
                <div class=""progress mb-4"">
                    <div class=""progress-bar"" role=""progressbar"" style=""width: 60%""
                         aria-valuenow=""60"" aria-valuemin=""0"" aria");
            WriteLiteral(@"-valuemax=""100""></div>
                </div>
                <h4 class=""small font-weight-bold"">
                    Payout Details <span class=""float-right"">80%</span>
                </h4>
                <div class=""progress mb-4"">
                    <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 80%""
                         aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                </div>
                <h4 class=""small font-weight-bold"">
                    Account Setup <span class=""float-right"">Complete!</span>
                </h4>
                <div class=""progress"">
                    <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 100%""
                         aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                </div>
            </div>
        </div>

        <!-- Color System -->
        <div class=""row"">
            <div class=""col-lg-6 mb-4"">
                <div class=""card bg-primary text-white");
            WriteLiteral(@" shadow"">
                    <div class=""card-body"">
                        Primary
                        <div class=""text-white-50 small"">#4e73df</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 mb-4"">
                <div class=""card bg-success text-white shadow"">
                    <div class=""card-body"">
                        Success
                        <div class=""text-white-50 small"">#1cc88a</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 mb-4"">
                <div class=""card bg-info text-white shadow"">
                    <div class=""card-body"">
                        Info
                        <div class=""text-white-50 small"">#36b9cc</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 mb-4"">
                <div class=""card bg-warning text-white shadow"">
                    <div class=""card-body"">
                ");
            WriteLiteral(@"        Warning
                        <div class=""text-white-50 small"">#f6c23e</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 mb-4"">
                <div class=""card bg-danger text-white shadow"">
                    <div class=""card-body"">
                        Danger
                        <div class=""text-white-50 small"">#e74a3b</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 mb-4"">
                <div class=""card bg-secondary text-white shadow"">
                    <div class=""card-body"">
                        Secondary
                        <div class=""text-white-50 small"">#858796</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 mb-4"">
                <div class=""card bg-light text-black shadow"">
                    <div class=""card-body"">
                        Light
                        <div class=""text-black-50 ");
            WriteLiteral(@"small"">#f8f9fc</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 mb-4"">
                <div class=""card bg-dark text-white shadow"">
                    <div class=""card-body"">
                        Dark
                        <div class=""text-white-50 small"">#5a5c69</div>
                    </div>
                </div>
            </div>
        </div>

    </div>

    <div class=""col-lg-6 mb-4"">

        <!-- Illustrations -->
        <div class=""card shadow mb-4"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Illustrations</h6>
            </div>
            <div class=""card-body"">
                <div class=""text-center"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e83975dbe11c8843417065b42092081d40f9c93c19377", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <p>
                    Add some quality, svg illustrations to your project courtesy of <a target=""_blank"" rel=""nofollow"" href=""https://undraw.co/"">unDraw</a>, a
                    constantly updated collection of beautiful svg images that you can use
                    completely free and without attribution!
                </p>
                <a target=""_blank"" rel=""nofollow"" href=""https://undraw.co/"">
                    Browse Illustrations on
                    unDraw &rarr;
                </a>
            </div>
        </div>

        <!-- Approach -->
        <div class=""card shadow mb-4"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Development Approach</h6>
            </div>
            <div class=""card-body"">
                <p>
                    SB Admin 2 makes extensive use of Bootstrap 4 utility classes in order to reduce
                    CSS bloat and poor page performance. Custom CS");
            WriteLiteral(@"S classes are used to create
                    custom components and custom utility classes.
                </p>
                <p class=""mb-0"">
                    Before working with this theme, you should become familiar with the
                    Bootstrap framework, especially the utility classes.
                </p>
            </div>
        </div>

    </div>
</div>");
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
