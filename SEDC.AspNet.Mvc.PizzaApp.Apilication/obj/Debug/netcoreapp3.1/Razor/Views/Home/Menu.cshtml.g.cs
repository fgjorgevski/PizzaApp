#pragma checksum "C:\Users\PC\Desktop\PizzaApplication\SEDC.AspNet.Mvc.PizzaApp\SEDC.AspNet.Mvc.PizzaApp.Apilication\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc837e6a5262a2c371fa1048a536c92ffb6a672d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Menu), @"mvc.1.0.view", @"/Views/Home/Menu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc837e6a5262a2c371fa1048a536c92ffb6a672d", @"/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2309e5f461104f165969a3e647c1ab3c3216c293", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\PC\Desktop\PizzaApplication\SEDC.AspNet.Mvc.PizzaApp\SEDC.AspNet.Mvc.PizzaApp.Apilication\Views\Home\Menu.cshtml"
   ViewBag.Title = "Menu"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"display-4\">Menu</h1>\n<div class=\"row\">\n    <div class=\"col-md-12\">\n");
#nullable restore
#line 8 "C:\Users\PC\Desktop\PizzaApplication\SEDC.AspNet.Mvc.PizzaApp\SEDC.AspNet.Mvc.PizzaApp.Apilication\Views\Home\Menu.cshtml"
          
            foreach (var menuItem in Model.Pizzas)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PC\Desktop\PizzaApplication\SEDC.AspNet.Mvc.PizzaApp\SEDC.AspNet.Mvc.PizzaApp.Apilication\Views\Home\Menu.cshtml"
           Write(Html.Partial("~/Views/Shared/_PizzaItem.cshtml",
                    new MenuPizzaVM
                    {
                        Pizza = menuItem,
                        Currency = Model.Currency
                    }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\PC\Desktop\PizzaApplication\SEDC.AspNet.Mvc.PizzaApp\SEDC.AspNet.Mvc.PizzaApp.Apilication\Views\Home\Menu.cshtml"
                      ;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuVM> Html { get; private set; }
    }
}
#pragma warning restore 1591