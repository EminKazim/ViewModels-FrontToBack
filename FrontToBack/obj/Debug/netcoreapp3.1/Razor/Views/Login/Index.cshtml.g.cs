#pragma checksum "C:\Users\ASUS\source\repos\FrontToBack\FrontToBack\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "307975afef5760edc3187ecdfeca4e0c9f0e736c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"307975afef5760edc3187ecdfeca4e0c9f0e736c", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\FrontToBack\FrontToBack\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""main-content"">
    <div class=""container-sm mt-3"">
        <ul>
            <li><span> <a href=""./home.html"" class=""link"">Home</a></span></li>
            <li style=""color:#d3d1d1"">
                <i class=""fal fa-angle-right fa-2xs ""></i><span>
                    <a style=""color:#d3d1d1""
                       href=""#"" disabled>MY ACCOUNT</a>
                </span>
            </li>
        </ul>
        <div class=""inputs"">
            <div class=""row"">
                <div class=""col-xl-6  col-sm-12"">
                    <div class=""login"">
                        <div class=""txt"">
                            <h6>LOGIN</h6>
                        </div>
                        <span>Username or email address *</span>
                        <div class=""input-group mt-2"">
                            <input type=""email"" class=""form"">
                        </div><br>
                        <span>Password *</span>
                        <div class=""input-group mt-3");
            WriteLiteral(@""">
                            <input type=""password"" class=""form"">
                        </div><br>
                        <input type=""checkbox"" name=""remember"">
                        <label for=""remember"">Remember me</label><br>
                        <button class=""btn mt-3"">Log in</button><br>
                        <a href=""#"" class="" mb-5"">Lost your password?</a>
                    </div>
                </div>
                <div class=""col-xl-6 col-sm-12"">
                    <div class=""register"">
                        <div class=""text"">
                            <h6>REGISTER</h6>
                        </div>
                        <span>Email address *</span>
                        <div class=""input-group mt-2"">
                            <input type=""email"" class=""form"">
                        </div><br>
                        <span>Passwor *</span>
                        <div class=""input-group mt-3"">
                            <input type=""password"" clas");
            WriteLiteral(@"s=""form"">
                        </div><br>
                        <p>
                            Your personal data will be used to support your experience throughout this website, to
                            manage access to your account, and for other purposes described in our <a href=""#"">privacy policy</a>.
                        </p>
                        <button class=""btn mt-3"">Register</button><br>
                    </div>
                </div>
            </div>
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
