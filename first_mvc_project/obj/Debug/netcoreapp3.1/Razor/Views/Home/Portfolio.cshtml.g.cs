#pragma checksum "/home/yasfatft/mvc/Views/Home/Portfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93637c4dcb9a00901af83c667085965079e52f6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Portfolio), @"mvc.1.0.view", @"/Views/Home/Portfolio.cshtml")]
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
#line 1 "/home/yasfatft/mvc/Views/_ViewImports.cshtml"
using mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/yasfatft/mvc/Views/_ViewImports.cshtml"
using mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93637c4dcb9a00901af83c667085965079e52f6c", @"/Views/Home/Portfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6a06753573638890b0ff2d42042a0bcf031bf36", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Portfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/yasfatft/mvc/Views/Home/Portfolio.cshtml"
  
    ViewData["Title"] = "About Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
	<!--================ Start portfolio Banner Area =================-->
	<section class=""banner_area"">
		<div class=""banner_inner d-flex align-items-center"">
			<div class=""container"">
				<div class=""banner_content text-right"">
					<h1>My Portfolio</h1>
					<div class=""page_link"">
						<a href=""index.html"">Home</a>
						<a href=""portfolio.html"">Portfolio</a>
					</div>
				</div>
			</div>
		</div>
	</section>
	<!--================ End Portfolio Banner Area =================-->

	<!--================ Start Portfolio Area =================-->
	<section class=""section_gap portfolio_area"" id=""work"">
		<div class=""container"">
			<div class=""row justify-content-center"">
				<div class=""col-lg-6 text-center"">
					<div class=""main-title"">
						<h1>Latest Works</h1>
						<p>If you are looking at blank cassettes on the web, you may be very confused at the difference in price. You may
							see some for as low as $.17 each.</p>
					</div>
				</div>
			</div>
			<div class=""row j");
            WriteLiteral(@"ustify-content-center"">
				<div class=""col-lg-10"">
					<div class=""projects_fillter"">
						<ul class=""filter list"">
							<li class=""active"" data-filter=""*"">All Categories</li>
							<li data-filter="".brand"">Branding</li>
							<li data-filter="".work"">Creative Work </li>
							<li data-filter="".web"">Web Design</li>
						</ul>
					</div>
				</div>
			</div>
			<div class=""projects_inner row grid"">
				<div class=""grid-sizer col-sm-6 col-md-3 col-lg-3""></div>
				<div class=""col-lg-6 col-sm-6 col-sm-12 brand web grid-item"">
					<div class=""projects_item"">
						<img class=""img-fluid w-100"" src=""img/works/work1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1717, "\"", 1723, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""projects_text"">
							<a href=""portfolio-details.html"">
								<h4>2D Vinyl Design</h4>
							</a>
							<p>Client Project</p>
						</div>
					</div>
				</div>
				<div class=""col-lg-3 col-sm-6 col-sm-12 brand work grid-item"">
					<div class=""projects_item"">
						<img class=""img-fluid w-100"" src=""img/works/work2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2082, "\"", 2088, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""projects_text"">
							<a href=""portfolio-details.html"">
								<h4>2D Vinyl Design</h4>
							</a>
							<p>Client Project</p>
						</div>
					</div>
				</div>
				<div class=""col-lg-3 col-sm-6 work grid-item"">
					<div class=""projects_item"">
						<img class=""img-fluid w-100"" src=""img/works/work3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2431, "\"", 2437, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""projects_text"">
							<a href=""portfolio-details.html"">
								<h4>2D Vinyl Design</h4>
							</a>
							<p>Client Project</p>
						</div>
					</div>
				</div>
				<div class=""col-lg-6 col-sm-6 brand work grid-item"">
					<div class=""projects_item"">
						<img class=""img-fluid w-100"" src=""img/works/work5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2786, "\"", 2792, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""projects_text"">
							<a href=""portfolio-details.html"">
								<h4>2D Vinyl Design</h4>
							</a>
							<p>Client Project</p>
						</div>
					</div>
				</div>
				<div class=""col-lg-6 col-sm-6 brand web grid-item"">
					<div class=""projects_item"">
						<img class=""img-fluid w-100"" src=""img/works/work4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3140, "\"", 3146, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""projects_text"">
							<a href=""portfolio-details.html"">
								<h4>2D Vinyl Design</h4>
							</a>
							<p>Client Project</p>
						</div>
					</div>
				</div>
				<div class=""col-lg-6 col-sm-6 brand work web grid-item"">
					<div class=""projects_item"">
						<img class=""img-fluid w-100"" src=""img/works/work8.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3499, "\"", 3505, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""projects_text"">
							<a href=""portfolio-details.html"">
								<h4>2D Vinyl Design</h4>
							</a>
							<p>Client Project</p>
						</div>
					</div>
				</div>
				<div class=""col-lg-3 col-sm-6 brand work web grid-item"">
					<div class=""projects_item"">
						<img class=""img-fluid w-100"" src=""img/works/work6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3858, "\"", 3864, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""projects_text"">
							<a href=""portfolio-details.html"">
								<h4>2D Vinyl Design</h4>
							</a>
							<p>Client Project</p>
						</div>
					</div>
				</div>
				<div class=""col-lg-3 col-sm-6 brand work web grid-item"">
					<div class=""projects_item"">
						<img class=""img-fluid w-100"" src=""img/works/work7.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4217, "\"", 4223, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""projects_text"">
							<a href=""portfolio-details.html"">
								<h4>2D Vinyl Design</h4>
							</a>
							<p>Client Project</p>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>
	<!--================ End Portfolio Area =================-->
");
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
