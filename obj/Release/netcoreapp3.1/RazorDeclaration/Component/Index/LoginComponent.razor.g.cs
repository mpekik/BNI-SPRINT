#pragma checksum "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\Index\LoginComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be773118c08b120dd4362a167fd46927d06b88a8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Integrasi_HTML.Component.Index
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
#line 1 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\Index\LoginComponent.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\Index\LoginComponent.razor"
using Integrasi_HTML.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\Index\LoginComponent.razor"
using System.IO.Ports;

#line default
#line hidden
#nullable disable
    public partial class LoginComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\Index\LoginComponent.razor"
               
            private bool kartuvalid = false;
            private bool pinvalid = true;
            private string pin;
            private string[] validasi = { "valid", "invalid" };
            private int trylimit = 3;
            //private string pinNasabah = "123456";
            private string namaNasabah = "Andreas Lamen";
            private string rekeningNasabah = "1234567890";
            private string alamatNasabah = "Tangerang";


            [Parameter]
            public EventCallback<string> OnClick { get; set; }

            private void cardInput()
            {
                Random rnd = new Random();
                int next = rnd.Next(0, 1);
                checkcardvalid(next);
            }

            /*protected override async Task OnInitializedAsync()
            {

                edc.Clear();
                edc.serialPort = new SerialPort();
                edc.serialPort.PortName = "COM6";
                edc.serialPort.DataReceived += new SerialDataReceivedEventHandler(edc.port_DataReceived);
                await Task.Run(()=>edc.SendCommand(edc.serialPort, "11"));
                Task.Delay(3000);
                do
                {
                    Task.Delay(100);
                    if (edc.statusCode == "00")
                    {
                        await Task.Delay(4000);

                        kartuvalid = true;
                        StateHasChanged();
                        edc.Clear();
                        edc.serialPort = new SerialPort();
                        edc.serialPort.PortName = "COM6";
                        edc.serialPort.DataReceived += new SerialDataReceivedEventHandler(edc.port_DataReceived);
                        await Task.Run(()=>edc.SendCommand(edc.serialPort, "12"));
                        Task.Delay(3000);
                        do
                        {
                            Task.Delay(100);
                            if (edc.statusCode == "00")
                            {
                                trx.setNasabah(namaNasabah, rekeningNasabah,alamatNasabah);
                                OnClick.InvokeAsync("pilihmenu");
                                break;
                            }
                            else if(edc.statusCode!=string.Empty)
                            {
                                //trx.setNasabah(namaNasabah, rekeningNasabah);
                                OnClick.InvokeAsync("default");
                                break;
                            }
                        } while (edc.statusCode == string.Empty);
                    }
                    else if(edc.statusCode=="55"||edc.statusCode=="TO")
                    {
                        //trx.setNasabah(namaNasabah, rekeningNasabah);
                        OnClick.InvokeAsync("default");
                        break;
                    }
                } while (!kartuvalid);
            }*/

            private void checkcardvalid(int number)
            {
                if(number == 0)
                {
                    string valid = validasi[0];
                    kartuvalid = true;
                }
                else
                {
                    string valid = validasi[1];
                }
            }

            private void pinInput()
            {
                Random rnd = new Random();
                int next = rnd.Next(0, 1);
                //int next = 1;
                checkpinvalid(next);
                /*if (pin != pinNasabah)
                {
                    pinError = true;
                    trylimit -= 1;
                    if(trylimit == 0)
                    {
                        OnClick.InvokeAsync("default");
                    }
                }
                else
                {
                    OnClick.InvokeAsync("pilihmenu");
                    trx.setNasabah(namaNasabah, rekeningNasabah);
                }*/
            }

            private void checkpinvalid(int next)
            {
                if(next == 0)
                {
                    OnClick.InvokeAsync("pilihmenu");
                    trx.setNasabah(namaNasabah, rekeningNasabah,alamatNasabah);
                }
                else
                {
                    pinvalid = false;
                    trylimit -= 1;
                    if (trylimit == 0)
                    {
                        OnClick.InvokeAsync("default");
                    }
                }
            }

        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EDC edc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private transaksi trx { get; set; }
    }
}
#pragma warning restore 1591
