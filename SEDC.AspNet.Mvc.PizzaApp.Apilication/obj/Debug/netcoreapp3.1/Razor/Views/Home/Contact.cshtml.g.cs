#pragma checksum "C:\Users\PC\Desktop\PizzaApplication\SEDC.AspNet.Mvc.PizzaApp\SEDC.AspNet.Mvc.PizzaApp.Apilication\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "958d0808dba49866caef7698de7902383fe42924"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\PizzaApplication\SEDC.AspNet.Mvc.PizzaApp\SEDC.AspNet.Mvc.PizzaApp.Apilication\Views\_ViewImports.cshtml"
using SEDC.AspNet.Mvc.PizzaApp.Apilication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\PizzaApplication\SEDC.AspNet.Mvc.PizzaApp\SEDC.AspNet.Mvc.PizzaApp.Apilication\Views\_ViewImports.cshtml"
using SEDC.AspNet.Mvc.PizzaApp.Apilication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC\Desktop\PizzaApplication\SEDC.AspNet.Mvc.PizzaApp\SEDC.AspNet.Mvc.PizzaApp.Apilication\Views\_ViewImports.cshtml"
using SEDC.AspNet.Mvc.PizzaApp.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"958d0808dba49866caef7698de7902383fe42924", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2309e5f461104f165969a3e647c1ab3c3216c293", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\PC\Desktop\PizzaApplication\SEDC.AspNet.Mvc.PizzaApp\SEDC.AspNet.Mvc.PizzaApp.Apilication\Views\Home\Contact.cshtml"
   ViewBag.Title = "Contact"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"jumbotron\">\n    <h1 class=\"display-4\">Contact</h1>\n    <p class=\"lead\">Please contact us at:</p>\n    <p>Phone: 08004521233</p>\n    <p>Mail: hello@pizzaApp.com</p>\n    <hr class=\"my-4\">\n    ");
#nullable restore
#line 10 "C:\Users\PC\Desktop\PizzaApplication\SEDC.AspNet.Mvc.PizzaApp\SEDC.AspNet.Mvc.PizzaApp.Apilication\Views\Home\Contact.cshtml"
Write(Html.ActionLink("Give us your feedback", "Feedback", "Home", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
