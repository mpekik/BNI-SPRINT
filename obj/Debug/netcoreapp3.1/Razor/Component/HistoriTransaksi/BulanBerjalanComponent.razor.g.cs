#pragma checksum "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ecee45d44ad2278d0ec2c93a529bcd911bb0a95"
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
#line 1 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Integrasi_HTML;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Integrasi_HTML.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
using Integrasi_HTML.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
using System.Drawing.Printing;

#line default
#line hidden
#nullable disable
    public partial class BulanBerjalanComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-md-8");
            __builder.AddAttribute(2, "style", "margin-top: 6.5%;");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "h2");
            __builder.AddAttribute(5, "id", true);
            __builder.AddAttribute(6, "class", "teks-hello2");
            __builder.AddContent(7, "Hello, ");
            __builder.OpenElement(8, "b");
            __builder.AddAttribute(9, "class", "nama-pelanggan");
            __builder.AddContent(10, 
#nullable restore
#line 11 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
                                                                    trx._nasabah

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.AddMarkupContent(12, "<p id class=\"teks-desc4\">Anda akan mencetak transaksi</p>\r\n    ");
            __builder.AddMarkupContent(13, "<p id class=\"periode-terpilih\">Periode bulan berjalan</p>\r\n    ");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "id", true);
            __builder.AddAttribute(16, "class", "waktu-periode");
            __builder.AddContent(17, 
#nullable restore
#line 14 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
                                    startdate

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(18, " s/d ");
            __builder.AddContent(19, 
#nullable restore
#line 14 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
                                                   enddate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "id", true);
            __builder.AddAttribute(23, "style", "text-align: center; margin-top: 10%;");
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "p");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "class", "btn btn-danger2");
            __builder.AddAttribute(29, "id", "myBtn");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
                                                                              CheckVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Ya");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "p");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "class", "btn btn-danger-no");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
                                                                       ()=>OnClick.InvokeAsync("default")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Tidak");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n");
#nullable restore
#line 21 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
 if (isVisible)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "    ");
            __builder.AddMarkupContent(43, @"<div class=""modal"" id=""myModal"" aria-hidden=""true"">
        <div class=""modal-dialog2 modal-dialog-centered"" role=""document"" style=""top: -2rem;"">
            <div class=""modal-content"">
                <div class=""modal-body"">
                    <img src=""../../assets/img/loading.gif"" style=""width: 30%;"">
                    <p>Mohon tunggu,</p>
                    <p style=""margin-top: -1rem;"">Histori transaksi sedang dicetak...</p>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 34 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 36 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
 if (isBaris)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal");
            __builder.AddAttribute(48, "id", "myModal");
            __builder.AddAttribute(49, "aria-hidden", "true");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "modal-dialog2 modal-dialog-centered");
            __builder.AddAttribute(53, "role", "document");
            __builder.AddAttribute(54, "style", "top: -2rem;");
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "modal-content");
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "modal-body");
            __builder.AddMarkupContent(61, "\r\n                    <img src=\"../../assets/img/loading.gif\" style=\"width: 30%;\">\r\n                    ");
            __builder.AddMarkupContent(62, "<p style=\"margin-top: -1rem;\">Apakah anda ingin mencetak halaman berikutnya?</p>\r\n                    ");
            __builder.OpenElement(63, "p");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "class", "btn btn-danger2");
            __builder.AddAttribute(67, "id", "myBtn");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
                                                                                          testVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(69, "Ya");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenElement(71, "p");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "type", "button");
            __builder.AddAttribute(74, "class", "btn btn-danger-no");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
                                                                                 home

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(76, "Tidak");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 50 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Component\HistoriTransaksi\BulanBerjalanComponent.razor"
       
    private bool isVisible = false;
    private bool isBaris = false;
    private bool berhasil = true;
    private string startdate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToString("yyyy-MM-dd");
    private string enddate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd");
    private string hour = DateTime.Now.ToString("HH:mm:ss");
    /*private string[] uraian =
    {
        "TRANSFER KE PT TOKOPEDIA",
        "TRF/PAY/TOP-UP ECHANNEL KARTU 5269212590018178 PREEPS 1111111JKT DIRECT EPRS 75461300008065949",
        "TRANSFER KE PT TOKOPEDIA",
        "TRANSFER DARI Sdr. ANDREAS TANIZAR PURBA",
        "TARIK TUNAI KARTU 5269212590018178 JAKARTA 119820-KC BEKASI"
    };
    private string[] tipe = { "D", "D", "D", "K", "D" };
    private string[] nominal = { "102000", "50000", "129000", "130000", "400000" };*/
    private string[] uraian;
    private string[] tipe;
    private string[] nominal;
    private string periodeprint = "Periode Satu Bulan Berjalan";
    private string saldo = "1000000";

    private async Task CheckVisible()
    {
        isVisible = !isVisible;
        trx.clearArray();
        string path = "C:\\Trilogi Persada-BNI\\input histori a4.csv";
        string[] lines = System.IO.File.ReadAllLines(path);
        uraian = new string[lines.Length];
        tipe = new string[lines.Length];
        nominal = new string[lines.Length];
        for (int i = 0; i < lines.Length; i++)
        {
            string[] column = lines[i].Split(";");
            for (int j = 0; j < column.Length; j++)
            {
                if (j == 0)
                {
                    uraian[i] = column[j];
                }
                else if (j == 1)
                {
                    tipe[i] = column[j];
                }
                else if (j == 2)
                {
                    nominal[i] = column[j];
                }
            }
        }
        string jumlahtransaksi = uraian.Length.ToString();
        trx.setTransaksiHistori(jumlahtransaksi, periodeprint, uraian, tipe, nominal, saldo, startdate, enddate, hour);
        //Random rnd = new Random();
        //int next = rnd.Next(0, 1);
        if (berhasil)
        {
            int maxbaris = 12;
            int totalbaris = trx._uraian.Length;
            int halaman;
            int maxhalaman;
            if (totalbaris > maxbaris)
            {
                int n = totalbaris / maxbaris;
                string[] tempuraian = null;
                string[] temptipe = null;
                string[] tempnominal = null;
                int startindex = 0;
                if (totalbaris % maxbaris > 0)
                {
                    n += 1;
                }
                maxhalaman = n;
                trx.setMaxHalaman(maxhalaman.ToString());
                tempuraian = new string[trx._uraian.Length];
                temptipe = new string[trx._tipe.Length];
                tempnominal = new string[trx._nominal.Length];
                Array.Copy(trx._uraian, startindex, tempuraian, 0, trx._uraian.Length);
                Array.Copy(trx._tipe, startindex, temptipe, 0, trx._tipe.Length);
                Array.Copy(trx._nominal, startindex, tempnominal, 0, trx._nominal.Length);
                halaman = 1;
                for (int i = 0; i < n; i++)
                {
                    uraian = null;
                    tipe = null;
                    nominal = null;
                    if (i == n - 1)
                    {
                        trx.clearArray();
                        int sisabaris = tempuraian.Length - startindex;
                        uraian = new string[sisabaris];
                        tipe = new string[sisabaris];
                        nominal = new string[sisabaris];
                        Array.Copy(tempuraian, startindex, uraian, 0, sisabaris);
                        Array.Copy(temptipe, startindex, tipe, 0, sisabaris);
                        Array.Copy(tempnominal, startindex, nominal, 0, sisabaris);
                        trx.setTransaksiHistori(uraian, tipe, nominal, halaman.ToString());
                        saldo = await Task.Run(()=>print.HistoriPrint(trx));
                        await Task.Delay(20000);
                        OnClick.InvokeAsync("transaksiberhasil");
                        break;
                    }
                    else
                    {
                        trx.clearArray();
                        uraian = new string[maxbaris];
                        tipe = new string[maxbaris];
                        nominal = new string[maxbaris];
                        Array.Copy(tempuraian, startindex, uraian, 0, maxbaris);
                        Array.Copy(temptipe, startindex, tipe, 0, maxbaris);
                        Array.Copy(tempnominal, startindex, nominal, 0, maxbaris);
                        trx.setTransaksiHistori(uraian, tipe, nominal, halaman.ToString());
                        saldo = await Task.Run(()=>print.HistoriPrint(trx));
                        startindex += maxbaris;
                        halaman += 1;
                        maxhalaman -= 1;
                        await Task.Delay(1000);
                    }
                    isVisible = false;
                    if (maxhalaman > 1)
                    {
                        isBaris = !isBaris;
                        StateHasChanged();
                        do
                        {
                            await Task.Delay(100);
                        } while (isBaris);
                    }
                }
            }
            else if (totalbaris < maxbaris)
            {
                saldo = await Task.Run(()=>print.HistoriPrint(trx));
                await Task.Delay(10000);
                OnClick.InvokeAsync("transaksiberhasil");
            }
        }
        else
        {
            OnClick.InvokeAsync("transaksigagal");
        }
    }

    private void testVisible()
    {
        isVisible = true;
        isBaris = false;
    }

    private void home()
    {
        navman.NavigateTo("/");
    }

    [Parameter]
    public EventCallback<string> OnClick { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navman { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private printer print { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private transaksi trx { get; set; }
    }
}
#pragma warning restore 1591