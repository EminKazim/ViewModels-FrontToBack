#pragma checksum "C:\Users\ASUS\source\repos\FrontToBack\FrontToBack\Views\Card\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6f37392ae26cae7e55acc6e3a494bf25984f6a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Card_Index), @"mvc.1.0.view", @"/Views/Card/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6f37392ae26cae7e55acc6e3a494bf25984f6a5", @"/Views/Card/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Card_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\FrontToBack\FrontToBack\Views\Card\Index.cshtml"
  
    ViewData["Title"] = "Card";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""main"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xl-8 col-sm-10"">
                <div class=""products mt-5"">
                    <div class=""row"">
                        <div class=""col-xl-7 col-sm-7"">
                            <ul>
                                <li>Product</li>
                            </ul>
                        </div>
                        <div class=""col-xl-5 col-sm-5"">
                            <ul>
                                <li style=""margin-left: 35px;"">Price</li>
                                <li style=""margin-left: 45px;"">Quantity</li>
                                <li style=""margin-left: 45px;"">Subtotal</li>
                            </ul>
                        </div>
                        <hr>
                    </div>
                    <div class=""first-product info"">
                        <div class=""row"">
                            <div class=""col-xl-7 col-sm-7"">
  ");
            WriteLiteral("                              <img src=\"./assets/img/product-image-62-150x150.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1148, "\"", 1154, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <a href=""#"">All Natural Italian-Style Chicken Meatballs</a>
                            </div>
                            <div class=""list col-xl-5 col-sm-5 mt-5"">
                                <ul>
                                    <li>$7.25</li>
                                    <li>
                                        <div class=""minus curcile"">
                                            <p>-</p>
                                        </div> <span style=""color:black"">1</span>
                                        <div class=""sum curcile"">
                                            <p>+</p>
                                        </div>
                                    </li>
                                    <li class=""ms-3"" style=""color: black;"">
                                        $7.25
                                        <i class=""fas fa-times ms-5""></i>
                                    </li>
                             ");
            WriteLiteral(@"   </ul>
                            </div>
                        </div>
                        <div class=""second-product info"">
                            <div class=""row"">
                                <div class=""col-xl-7 col-sm-7"">
                                    <img src=""./assets/img/product-image-60-600x600.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2516, "\"", 2522, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <a href=""#"">Angie's Boomchickapop Sweet & Salty Kettle Corn</a>
                                </div>
                                <div class=""list col-xl-5 col-sm-5 mt-5"">
                                    <ul>
                                        <li>$3.29</li>
                                        <li>
                                            <div class=""minus curcile"">
                                                <p>-</p>
                                            </div> <span style=""color: black;"">1</span>
                                            <div class=""sum curcile"">
                                                <p>+</p>
                                            </div>
                                        </li>
                                        <li class=""ms-3"" style=""color: black;"">
                                            $3.29
                                            <i class=""fas fa-times""></i>
       ");
            WriteLiteral(@"                                 </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""input col-sm-12"">
                    <input type=""text"" placeholder=""Coupon code"">
                    <button type=""button"" class=""btn btn-primary"">Apply coupon</button>
                    <input type=""submit"" value=""Update cart"" class=""button "">
                </div>
            </div>
            <div class=""col-xl-4 col-sm-12 mt-5 "">
                <div class=""shopping-info"">
                    <div class=""content ms-3"">
                        <div class=""card-head mt-5"">
                            <h5>CART TOTALS</h5>
                        </div>
                        <span class=""mt-3"">Subtotal</span>
                        <span class=""product-price"">$10.54</span>
                    </div>
                   ");
            WriteLiteral(@" <div class=""shipping-detail"">
                        <div class=""row"">
                            <div class=""col-6"">
                                <div class=""shipping"">
                                    <h5>Shipping</h5>

                                </div>
                            </div>
                            <div class=""col-xl-6 col-sm-12"">
                                <div class=""detail"">
                                    <span>Flat rate:</span>
                                    <span style=""color:red;"">$5.00</span>
                                    <input type=""radio"">
                                    <span class=""ms-2"">Free shipping</span>
                                    <input type=""radio"">
                                    <span class=""ms-3"">Local pickup</span>
                                    <input type=""radio"">
                                    <span class=""ms-3"">Shipping to <strong>AL.</strong> </span>
                                   ");
            WriteLiteral(@" <a href=""#"">Change address</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""total"">
                        <span class=""ms-5"">Total</span>
                        <span class=""span"">$15.54</span>
                    </div>
                    <button type=""button"" class=""btn btn-danger"">
                        <a href=""#"">
                            Proceed to checkout
                        </a>
                    </button>
                </div>
            </div>
</section>");
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
