#pragma checksum "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\HistoriTransaksi\PilihTransaksiComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e42216d8e717ec9371779c3e6a5a3e53934113a"
// <auto-generated/>
#pragma warning disable 1591
namespace Integrasi_HTML.Component.HistoriTransaksi
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 1 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\HistoriTransaksi\PilihTransaksiComponent.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\HistoriTransaksi\PilihTransaksiComponent.razor"
using Integrasi_HTML.Data;

#line default
#line hidden
#nullable disable
    public partial class PilihTransaksiComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-md-8");
            __builder.AddAttribute(2, "style", "margin-top: 6.5%;");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "h2");
            __builder.AddAttribute(5, "class", "teks-hello2");
            __builder.AddContent(6, "Hello, ");
            __builder.OpenElement(7, "b");
            __builder.AddAttribute(8, "class", "nama-pelanggan");
            __builder.AddContent(9, 
#nullable restore
#line 8 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\HistoriTransaksi\PilihTransaksiComponent.razor"
                                                                  trx._nasabah

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.AddMarkupContent(11, "<p id=\"teks\" class=\"teks-desc4\">Pilih periode cetak transaksi</p>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "form-input-data");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "id", "btn-periode");
            __builder.AddAttribute(17, "class", "col-md-12");
            __builder.AddAttribute(18, "style", "text-align: center;");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "class", "btn2 btn-outline-danger2");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\HistoriTransaksi\PilihTransaksiComponent.razor"
                                                                                       ()=>OnClick.InvokeAsync("bulanberjalan")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Periode bulan berjalan");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "class", "btn2 btn-outline-danger2");
            __builder.AddAttribute(32, "style", "margin-left: 0.5rem;");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\HistoriTransaksi\PilihTransaksiComponent.razor"
                                                                                                                    ()=>OnClick.InvokeAsync("bulanterakhir")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Periode 1 bulan terakhir");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "type", "button");
            __builder.AddAttribute(42, "class", "btn2 btn-outline-danger2");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\HistoriTransaksi\PilihTransaksiComponent.razor"
                                                                                       ()=>OnClick.InvokeAsync("bulanlalu")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Periode bulan lalu");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "type", "button");
            __builder.AddAttribute(48, "class", "btn2 btn-outline-danger2");
            __builder.AddAttribute(49, "style", "margin-left: 0.5rem;");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\HistoriTransaksi\PilihTransaksiComponent.razor"
                                                                                                                    ()=>OnClick.InvokeAsync("sepuluhterakhir")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "10 transaksi terakhir");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.OpenElement(56, "nav");
            __builder.AddAttribute(57, "class", "navbar navbar-expand-lg navbar-transparent navbar-absolute");
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "container-fluid");
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.AddMarkupContent(62, "<div class=\"col-md-4\">\r\n                </div>\r\n                ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "col-md-8");
            __builder.AddAttribute(65, "style", "margin-top: 40px; margin-left: 30px;");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\HistoriTransaksi\PilihTransaksiComponent.razor"
                                                                                             pilihmenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(67, "\r\n                    <img src=\"../../assets/img/btn-back.png\" style=\"width: 30px;\">\r\n                    ");
            __builder.AddMarkupContent(68, "<class><b>&nbsp;Kembali</b></class>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\HistoriTransaksi\PilihTransaksiComponent.razor"
       
    [Parameter]
    public EventCallback<string> OnClick { get; set; }

    private void pilihmenu()
    {
        navman.NavigateTo("/pilihmenu");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navman { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private transaksi trx { get; set; }
    }
}
#pragma warning restore 1591
