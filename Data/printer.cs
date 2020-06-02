using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;

namespace Integrasi_HTML.Data
{
    public class printer
    {
        PrintDocument printDoc = new PrintDocument();   
        transaksi _trx = new transaksi();
        Font font = new Font("Calibri", 8, FontStyle.Regular);

        public async Task PassbookPrintRekening(transaksi trx)
        {
            printDoc = new PrintDocument();
            _trx = trx;
            //printDoc.PrinterSettings.PrinterName = "Canon MP280 series Printer";
            printDoc.PrinterSettings.PrinterName = "PsiPR-OLI";
            printDoc.BeginPrint += new PrintEventHandler(BeginPrintEH);
            printDoc.EndPrint += new PrintEventHandler(EndPrintEH);
            printDoc.PrintPage += new PrintPageEventHandler(PassbookPrintPageRekening);
            printDoc.Print();
        }

        public void BeginPrintEH(object sender, PrintEventArgs e)
        {
            SolidBrush blackbrush = new SolidBrush(Color.Black);
        }

        public void EndPrintEH (object sender, PrintEventArgs e)
        {
            SolidBrush blackbrush = new SolidBrush(Color.Black);
            blackbrush.Dispose();
        }

        public void PassbookPrintPageRekening(object sender, PrintPageEventArgs e)
        {
            SolidBrush blackbrush = new SolidBrush(Color.Black);
            Graphics g = e.Graphics;

            /*g.DrawString("CETAK BUKU REKENING", new Font("Arial", 24, FontStyle.Bold), blackbrush, new Point(200, 20));
            
            g.DrawString("NO", font, blackbrush, new Point(0, 70));
            g.DrawString("TANGGAL", font, blackbrush, new Point(30, 70));
            g.DrawString("SANDI", font, blackbrush, new Point(87, 70));
            g.DrawString("DEBET", font, blackbrush, new Point(155, 70));
            g.DrawString("KREDIT", font, blackbrush, new Point(249, 70));
            g.DrawString("SALDO", font, blackbrush, new Point(340, 70));
            g.DrawString("PENGESAHAN", font, blackbrush, new Point(412, 65));
            g.DrawString("PETUGAS BANK", font, blackbrush, new Point(412, 75));*/

            int saldo = int.Parse(_trx._saldo);
            int baris = int.Parse(_trx._baris);
            int ypoint = 70;
            int sisabaris = 12 * baris;
            if (baris > 20)
            {
                sisabaris = sisabaris + (12 * 8);
            }
            ypoint += sisabaris;
            for(int i = 0; i < _trx._tipe.Length; i++)
            {
                    //int next = 1;
                    string keterangan = _trx._sandi[i];
                    //int debet = int.Parse(_trx._debet[i]);
                    //int kredit = int.Parse(_trx._kredit[i]);
                    int nominal = int.Parse(_trx._nominal[i]);

                    if (keterangan == "DBT")
                    {
                        //Random rnd = new Random();
                        string sandi = _trx._tipe[i];
                        saldo -= nominal;
                        string debetprint = "-" + nominal.ToString();
                        g.DrawString(sandi, font, blackbrush, new Point(87, ypoint));
                        g.DrawString(debetprint, font, blackbrush, new Point(155, ypoint));
                        g.DrawString(saldo.ToString(), font, blackbrush, new Point(340, ypoint));
                    }
                    else
                    {
                        //Random rnd = new Random();
                        string sandi = _trx._tipe[i];
                        saldo += nominal;
                        string kreditprint = nominal.ToString();
                        g.DrawString(sandi, font, blackbrush, new Point(87, ypoint));
                        g.DrawString(kreditprint, font, blackbrush, new Point(249, ypoint));
                        g.DrawString(saldo.ToString(), font, blackbrush, new Point(340, ypoint));
                    }

                    g.DrawString(baris.ToString(), font, blackbrush, new Point(0, ypoint));
                    g.DrawString(_trx._startdate, font, blackbrush, new Point(30, ypoint));
                    g.DrawString(_trx._pengesahan[i], font, blackbrush, new Point(442, ypoint));
                    baris += 1;
                    ypoint += 12;
                    if (baris == 21)
                    {
                        ypoint = ypoint + (12 * 8);
                    }
                }
        }
        public async Task PassbookPrintBisnis(transaksi trx)
        {
            printDoc = new PrintDocument();
            _trx = trx;
            //printDoc.PrinterSettings.PrinterName = "Canon MP280 series Printer";
            printDoc.PrinterSettings.PrinterName = "PsiPR-OLI";
            printDoc.BeginPrint += new PrintEventHandler(BeginPrintEH);
            printDoc.EndPrint += new PrintEventHandler(EndPrintEH);
            printDoc.PrintPage += new PrintPageEventHandler(PassbookPrintPageBisnis);
            printDoc.Print();
        }

        public void PassbookPrintPageBisnis(object sender, PrintPageEventArgs e)
        {
            SolidBrush blackbrush = new SolidBrush(Color.Black);
            Graphics g = e.Graphics;

            /*g.DrawString("CETAK BUKU REKENING", new Font("Arial", 24, FontStyle.Bold), blackbrush, new Point(200, 20));
            
            g.DrawString("NO", font, blackbrush, new Point(0, 70));
            g.DrawString("TANGGAL", font, blackbrush, new Point(30, 70));
            g.DrawString("SANDI", font, blackbrush, new Point(87, 70));
            g.DrawString("DEBET", font, blackbrush, new Point(155, 70));
            g.DrawString("KREDIT", font, blackbrush, new Point(249, 70));
            g.DrawString("SALDO", font, blackbrush, new Point(340, 70));
            g.DrawString("PENGESAHAN", font, blackbrush, new Point(412, 65));
            g.DrawString("PETUGAS BANK", font, blackbrush, new Point(412, 75));*/

            int saldo = int.Parse(_trx._saldo);
            int baris = int.Parse(_trx._baris);
            int ypoint = 70;
            int sisabaris = 12 * baris;
            if (baris > 10)
            {
                sisabaris = sisabaris + (12 * 8);
            }
            ypoint += sisabaris;
            for (int i = 0; i < _trx._tipe.Length; i++)
            {

                if (i % 2 == 0)
                {
                    //int next = 1;
                    string keterangan = _trx._sandi[i];
                    //int debet = int.Parse(_trx._debet[i]);
                    //int kredit = int.Parse(_trx._kredit[i]);
                    int nominal = int.Parse(_trx._nominal[i]);

                    if (keterangan == "DBT")
                    {
                        //Random rnd = new Random();
                        string sandi = _trx._tipe[i];
                        saldo -= nominal;
                        string debetprint = "-" + nominal.ToString();
                        g.DrawString(sandi, font, blackbrush, new Point(87, ypoint));
                        g.DrawString(debetprint, font, blackbrush, new Point(155, ypoint));
                        g.DrawString(saldo.ToString(), font, blackbrush, new Point(340, ypoint));
                    }
                    else
                    {
                        //Random rnd = new Random();
                        string sandi = _trx._tipe[i];
                        saldo += nominal;
                        string kreditprint = nominal.ToString();
                        g.DrawString(sandi, font, blackbrush, new Point(87, ypoint));
                        g.DrawString(kreditprint, font, blackbrush, new Point(249, ypoint));
                        g.DrawString(saldo.ToString(), font, blackbrush, new Point(340, ypoint));
                    }

                    g.DrawString(baris.ToString(), font, blackbrush, new Point(0, ypoint));
                    g.DrawString(_trx._startdate, font, blackbrush, new Point(30, ypoint));
                    g.DrawString(_trx._pengesahan[i], font, blackbrush, new Point(442, ypoint));
                    baris += 1;
                    ypoint += (12 * 2);
                    if (baris == 11)
                    {
                        ypoint = ypoint + (24 * 3);
                    }
                }
            }
        }
        public async Task HistoriPrint(transaksi trx)
        {
            printDoc = new PrintDocument();
            _trx = trx;
            //printDoc.PrinterSettings.PrinterName = "Canon MP280 series Printer";
            //printDoc.PrinterSettings.PrinterName = "PsiPR-OLI";
            printDoc.PrinterSettings.PrinterName = "Brother HL-L2360D series";
            printDoc.BeginPrint += new PrintEventHandler(BeginPrintEH);
            printDoc.EndPrint += new PrintEventHandler(EndPrintEH);
            printDoc.PrintPage += new PrintPageEventHandler(HistoriPrintPage);
            printDoc.Print();
        } 
        public void HistoriPrintPage(object sender, PrintPageEventArgs e)
        {
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Graphics g = e.Graphics;
            font = new Font("Arial", 10, FontStyle.Regular);

            g.DrawString("CETAK TRANSAKSI", new Font("Arial", 24, FontStyle.Bold), blackBrush, new Point(200, 20));

            g.DrawString("Uraian", new Font("Arial", 12, FontStyle.Regular), blackBrush, new Point(30, 150));
            g.DrawString("Tipe", new Font("Arial", 12, FontStyle.Regular), blackBrush, new Point(350, 150));
            g.DrawString("Nominal", new Font("Arial", 12, FontStyle.Regular), blackBrush, new Point(450, 150));
            g.DrawString("Saldo", new Font("Arial", 12, FontStyle.Regular), blackBrush, new Point(600, 130));
            g.DrawString("Akhir", new Font("Arial", 12, FontStyle.Regular), blackBrush, new Point(600, 150));

            int saldo = int.Parse(_trx._saldo);
            int ypoint = 170;
            for(int i = 0; i < _trx._uraian.Length; i++)
            {
                if(_trx._uraian[i].Length >= 40)
                {
                    string[] arrayhsl = stringSplit(_trx._uraian[i]);
                    int nominal = int.Parse(_trx._nominal[i]);
                    int ypoint1 = ypoint;
                    for(int j = 0; j < arrayhsl.Length; j++)
                    {
                        g.DrawString(arrayhsl[j], font, blackBrush, new Point(30, ypoint1));
                        ypoint1 += 20;
                    }
                    g.DrawString(_trx._enddate, font, blackBrush, new Point(30, ypoint1));
                    g.DrawString(_trx._jam, font, blackBrush, new Point(130, ypoint1));
                    ypoint1 += 40;
                    g.DrawString(_trx._tipe[i], font, blackBrush, new Point(350, ypoint));
                    g.DrawString(nominal.ToString(), font, blackBrush, new Point(450, ypoint));
                    g.DrawString(saldo.ToString(), font, blackBrush, new Point(600, ypoint));
                    ypoint = ypoint1;
                    saldo += nominal;
                }
                else
                {
                    g.DrawString(_trx._uraian[i], font, blackBrush, new Point(30, ypoint));
                    int nominal = int.Parse(_trx._nominal[i]);
                    int ypoint1 = ypoint;
                    ypoint1 += 20;
                    g.DrawString(_trx._enddate, font, blackBrush, new Point(30, ypoint1));
                    g.DrawString(_trx._jam, font, blackBrush, new Point(130, ypoint1));
                    ypoint1 += 40;
                    g.DrawString(_trx._tipe[i], font, blackBrush, new Point(350, ypoint));
                    g.DrawString(nominal.ToString(), font, blackBrush, new Point(450, ypoint));
                    g.DrawString(saldo.ToString(), font, blackBrush, new Point(600, ypoint));
                    ypoint = ypoint1;
                    saldo += nominal;
                }
            }
        }
        public string[] stringSplit(string strtext)
        {
            //string result = ypoint;
            string[] strarray = strtext.Split().ToArray();
            string temp = string.Empty;
            int j = 0;
            int pos = 0;
            //int ypoint = 170;
            int n = strtext.Length / 40;
            if(strtext.Length%40 > 0)
            {
                n += 1;
            }
            string[] arrayhasil = new string[n];
            string[] temparray = null;
            for(int i = 0; i < n; i++)
            {
                while(j < strarray.Length)
                {
                    if(j == 0)
                    {
                        temp = temp + strarray[j];
                        pos = j;
                    }
                    else
                    {
                        temp = temp + " " + strarray[j];
                        pos = j;
                    }
                    if (temp.Length < 40)
                    {
                        arrayhasil[i] = temp;
                    }
                    else
                    {
                        j += strarray.Length;
                    }
                    j++;
                }
                
                if ((strarray.Length - pos) != 0)
                    temparray = new string[strarray.Length - pos];
                else
                    temparray = new string[1];
                Array.Copy(strarray, pos, temparray, 0, strarray.Length - pos);
                //strarray = new string[temparray.Length];
                strarray = temparray;
                pos = 0;
                j = 0;
                temp = string.Empty;
                //strtext.Substring(temp.Length);
                //strarray = strtext.Split().ToArray();
             }
            return arrayhasil;
        }
        /*public string checkprinterstatus(PrintDocument printDoc)
        {

        }*/
        public async Task ThermalPrint(transaksi trx)
        {
            printDoc = new PrintDocument();
            _trx = trx;
            printDoc.PrinterSettings.PrinterName = "BT-T080(U) 1";
            printDoc.BeginPrint += new PrintEventHandler(BeginPrintEH);
            printDoc.EndPrint += new PrintEventHandler(EndPrintEH);
            printDoc.PrintPage += new PrintPageEventHandler(ThermalPrintPage);
            printDoc.Print();
        }
        public void ThermalPrintPage(object sender, PrintPageEventArgs e)
        {
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Graphics g = e.Graphics;
            font = new Font("Arial", 10, FontStyle.Regular);

            g.DrawString("Cetak Thermal", new Font("Arial", 12, FontStyle.Regular), blackBrush, new Point(5, 10));

            string joint = string.Empty;

            int batastrx = _trx._uraian.Length - 10;
            int ypoint = 50;
            //string joint = string.Empty;
            int saldo = int.Parse(_trx._saldo);
            for(int i = batastrx; i < _trx._uraian.Length; i++)
            {
                Random rnd = new Random();
                if(_trx._uraian[i] == "DEBET")
                {
                    saldo -= rnd.Next(100000);
                }
                else
                {
                    saldo += rnd.Next(100000);
                }
                joint = joint + _trx._tanggal[i] + " " + _trx._uraian[i] + " " + _trx._tipe[i] + " " + saldo.ToString();
                g.DrawString(joint, font, blackBrush, new Point(5, ypoint));
                ypoint += 20;
                joint = string.Empty;
            }
        }
    }
}
