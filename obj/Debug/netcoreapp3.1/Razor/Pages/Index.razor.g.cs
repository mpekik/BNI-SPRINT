#pragma checksum "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b60b15cb6d6ed14cc5588c11c45178dbec9906e"
// <auto-generated/>
#pragma warning disable 1591
namespace Integrasi_HTML.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Integrasi_HTML;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Integrasi_HTML.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Pages\Index.razor"
using Integrasi_HTML.Component.Index;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Pages\Index.razor"
using Integrasi_HTML.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "wrapper");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main-panel");
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "content");
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "container-fluid");
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.AddMarkupContent(15, @"<div class=""col-md-4"">
                            <img class=""bni-logo"" src=""../assets/img/bni-white.png""><br><br><br>
                            <div class=""text-white"">
                                <h2 class=""teks-sidebar font-qs-bold"">Cetak Transaksi Anda</h2><br>
                            </div>
                            <img class=""nav-vektor"" src=""../assets/img/vektor-a.png"">
                        </div>
                        
");
#nullable restore
#line 21 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Pages\Index.razor"
                             switch (message)
                            {
                                case "login":
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                                        ");
            __builder.OpenComponent<Integrasi_HTML.Component.Index.LoginComponent>(17);
            __builder.AddAttribute(18, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 25 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Pages\Index.razor"
                                                                 ClickHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 26 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Pages\Index.razor"
                                        break;
                                    }

                                case "pilihmenu":
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                                        ");
            __builder.OpenComponent<Integrasi_HTML.Component.Index.PilihMenuComponent>(21);
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 32 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Pages\Index.razor"
                                        break;
                                    }

                                default:
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                                        ");
            __builder.OpenComponent<Integrasi_HTML.Component.Index.HomeComponent>(24);
            __builder.AddAttribute(25, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 37 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Pages\Index.razor"
                                                                ClickHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 38 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Pages\Index.razor"
                                        break;
                                    }
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "                       \r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Pages\Index.razor"
      
    private string message = string.Empty;
    void ClickHandler(string newMessage)
    {
        message = newMessage;
    }

    protected override async Task OnInitializedAsync()
    {
        trx.clear();
        trx.clearArray();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private transaksi trx { get; set; }
    }
}
#pragma warning restore 1591
