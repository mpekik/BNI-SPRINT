﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Printing;
using System.Runtime.CompilerServices;
using System.Text;

namespace Integrasi_HTML.Data
{
    public class printer
    {
        PrintDocument printDoc = new PrintDocument();   
        transaksi _trx = new transaksi();
        Font font = new Font("Calibri", 8, FontStyle.Regular);
        public bool isEnd = false;
        private bool isPrinting = false;
        public string PassbookPrintRekening(transaksi trx)
        {
            printDoc = new PrintDocument();
            _trx = trx;
            //printDoc.PrinterSettings.PrinterName = "Canon MP280 series Printer";
            printDoc.PrinterSettings.PrinterName = "PsiPR-OLI";
            printDoc.BeginPrint += new PrintEventHandler(BeginPrintEH);
            printDoc.EndPrint += new PrintEventHandler(EndPrintEH);
            printDoc.PrintPage += new PrintPageEventHandler(PassbookPrintPageRekening);
            printDoc.Print();
            return _trx._saldo;
        }

        public void BeginPrintEH(object sender, PrintEventArgs e)
        {
            SolidBrush blackbrush = new SolidBrush(Color.Black);
            //isEnd = false;
            //isPrinting = false;
        }

        public void EndPrintEH (object sender, PrintEventArgs e)
        {
            SolidBrush blackbrush = new SolidBrush(Color.Black);
            blackbrush.Dispose();
            /*if(isPrinting)
            {
                isEnd = true;
            }*/
        }

        public void PassbookPrintPageRekening(object sender, PrintPageEventArgs e)
        {
            font = new Font("Calibri", 8, FontStyle.Regular);
            SolidBrush blackbrush = new SolidBrush(Color.Black);
            Graphics g = e.Graphics;
            isPrinting = true;
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
            int ypoint = 75;
            int sisabaris = 13 * baris;
            if (baris > 20)
            {
                sisabaris = sisabaris + (12 * 5);
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
                        string debetprint = "-" + nominal.ToString("N0");
                        g.DrawString(sandi, font, blackbrush, new Point(87, ypoint));
                        g.DrawString(debetprint, font, blackbrush, new Point(155, ypoint));
                        g.DrawString(saldo.ToString("N0"), font, blackbrush, new Point(340, ypoint));
                    }
                    else
                    {
                        //Random rnd = new Random();
                        string sandi = _trx._tipe[i];
                        saldo += nominal;
                        string kreditprint = nominal.ToString("N0");
                        g.DrawString(sandi, font, blackbrush, new Point(87, ypoint));
                        g.DrawString(kreditprint, font, blackbrush, new Point(249, ypoint));
                        g.DrawString(saldo.ToString("N0"), font, blackbrush, new Point(340, ypoint));
                    }

                    g.DrawString(baris.ToString(), font, blackbrush, new Point(0, ypoint));
                    g.DrawString(_trx._startdate, font, blackbrush, new Point(30, ypoint));
                    g.DrawString(_trx._pengesahan[i], font, blackbrush, new Point(442, ypoint));
                    baris += 1;
                    ypoint += 13;
                    if (baris == 21)
                    {
                        ypoint = ypoint + (12 * 5);
                    }
                }
            if (!e.HasMorePages)
                isEnd = true;

            _trx._saldo = saldo.ToString();
        }
        public String PassbookPrintBisnis(transaksi trx)
        {
            printDoc = new PrintDocument();
            _trx = trx;
            //printDoc.PrinterSettings.PrinterName = "Canon MP280 series Printer";
            printDoc.PrinterSettings.PrinterName = "PsiPR-OLI";
            printDoc.BeginPrint += new PrintEventHandler(BeginPrintEH);
            printDoc.EndPrint += new PrintEventHandler(EndPrintEH);
            printDoc.PrintPage += new PrintPageEventHandler(PassbookPrintPageBisnis);
            printDoc.Print();
            return _trx._saldo;
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
            int sisabaris = 13 * baris;
            if (baris > 10)
            {
                sisabaris = sisabaris + (12 * 5);
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
                    ypoint += (13 * 2);
                    if (baris == 11)
                    {
                        ypoint = ypoint + (12 * 5);
                    }
                }
            }
            if (!e.HasMorePages)
                isEnd = true;

            _trx._saldo = saldo.ToString();
        }
        public string HistoriPrint(transaksi trx)
        {
            printDoc = new PrintDocument();
            _trx = trx;
            //printDoc.PrinterSettings.PrinterName = "Canon MP280 series Printer";
            //printDoc.PrinterSettings.PrinterName = "PsiPR-OLI";
            printDoc.PrinterSettings.PrinterName = "EPSON L3150 Series";
            printDoc.BeginPrint += new PrintEventHandler(BeginPrintEH);
            printDoc.EndPrint += new PrintEventHandler(EndPrintEH);
            printDoc.PrintPage += new PrintPageEventHandler(HistoriPrintPage);
            printDoc.Print();
            string machinenames = Environment.MachineName;
            PrintServer myprintserver = new LocalPrintServer();
            PrintQueueCollection myprintqueue = myprintserver.GetPrintQueues();
            string printqueue = "my print queue : \n\n";
            bool isjobdone = false;
            Console.WriteLine(printqueue);
            foreach (PrintQueue pq in myprintqueue)
            {
                pq.Refresh();
                //if (pq.Name != "Brother HL-L2360D series") continue;
                if (pq.Name != "EPSON L3150 Series") continue;
                Console.WriteLine(pq.Name);
                do
                {
                    PrintJobInfoCollection jobs = pq.GetPrintJobInfoCollection();
                    foreach (PrintSystemJobInfo job in jobs)
                    {
                        Console.WriteLine(job.JobName);
                        Console.WriteLine(job.JobStatus);
                        if (job.IsPrinted)
                            isjobdone = true;
                    }
                } while (isjobdone);
            }
            Console.WriteLine("Print Selesai ...");
            Console.ReadLine();
            return _trx._saldo;
        }
        public void HistoriPrintPage(object sender, PrintPageEventArgs e)
        {
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Graphics g = e.Graphics;

            //g.DrawString("CETAK TRANSAKSI", new Font("Arial", 24, FontStyle.Bold), blackBrush, new Point(200, 20));

            string logo = "C:\\Trilogi Persada-BNI\\bniA4.bmp";
            Image img = Image.FromFile(logo);
            g.DrawImage(img, new Point(50, 50));

            string cabang = "BNI Cabang " + _trx._namacabang;
            string nasabah = _trx._nasabah;
            string alamat = _trx._alamatnasabah;

            g.DrawString("Nama Nasabah", new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(50, 130));
            g.DrawString("Alamat Nasabah", new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(50, 150));

            g.DrawString(":", new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(170, 130));
            g.DrawString(":", new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(170, 150));

            g.DrawString(cabang, new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(50, 110));
            g.DrawString(nasabah, new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(180, 130));
            g.DrawString(alamat, new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(180, 150));

            string periode = _trx._startdate + " s/d " + _trx._enddate;
            string norekening = _trx._rekening;
            string jumlah = _trx._jumlahtransaksi + " transaksi";

            g.DrawString("Periode", new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(350, 90));
            g.DrawString("Nomor Rekening", new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(350, 110));
            g.DrawString("Jenis Tabungan", new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(350, 130));
            g.DrawString("Jumlah Transaksi", new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(350, 150));

            g.DrawString(":", new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(470, 90));
            g.DrawString(":", new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(470, 110));
            g.DrawString(":", new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(470, 130));
            g.DrawString(":", new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(470, 150));

            g.DrawString(periode, new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(480, 90));
            g.DrawString(norekening, new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(480, 110));
            g.DrawString("Taplus", new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(480, 130));
            g.DrawString(jumlah, new Font("Arial", 10, FontStyle.Regular), blackBrush, new Point(480, 150));

            g.DrawString("Uraian", new Font("Arial", 12, FontStyle.Regular), blackBrush, new Point(50, 200));
            g.DrawString("Tipe", new Font("Arial", 12, FontStyle.Regular), blackBrush, new Point(350, 200));
            g.DrawString("Nominal", new Font("Arial", 12, FontStyle.Regular), blackBrush, new Point(450, 200));
            g.DrawString("Saldo", new Font("Arial", 12, FontStyle.Regular), blackBrush, new Point(600, 180));
            g.DrawString("Akhir", new Font("Arial", 12, FontStyle.Regular), blackBrush, new Point(600, 200));

            int saldo = int.Parse(_trx._saldo);
            int ypoint = 220;
            font = new Font("Arial", 10, FontStyle.Regular);
            for (int i = 0; i < _trx._uraian.Length; i++)
            {
                int ypoint1 = ypoint;
                int nominal = int.Parse(_trx._nominal[i]);
                if (_trx._uraian[i].Length >= 40)
                {
                    string[] arrayhsl = stringSplit(_trx._uraian[i]);
                    //int nominal = int.Parse(_trx._nominal[i]);
                    //int ypoint1 = ypoint;
                    for (int j = 0; j < arrayhsl.Length; j++)
                    {
                        g.DrawString(arrayhsl[j], font, blackBrush, new Point(50, ypoint1));
                        ypoint1 += 20;
                    }
                    /*g.DrawString(_trx._enddate, font, blackBrush, new Point(30, ypoint1));
                    g.DrawString(_trx._jam, font, blackBrush, new Point(130, ypoint1));
                    ypoint1 += 40;
                    g.DrawString(_trx._tipe[i], font, blackBrush, new Point(350, ypoint));
                    g.DrawString(nominal.ToString(), font, blackBrush, new Point(450, ypoint));
                    g.DrawString(saldo.ToString(), font, blackBrush, new Point(600, ypoint));
                    ypoint = ypoint1;
                    saldo += nominal;*/
                }
                else
                {
                    g.DrawString(_trx._uraian[i], font, blackBrush, new Point(50, ypoint));
                    //int nominal = int.Parse(_trx._nominal[i]);
                    //int ypoint1 = ypoint;
                    ypoint1 += 20;
                    /*g.DrawString(_trx._enddate, font, blackBrush, new Point(30, ypoint1));
                    g.DrawString(_trx._jam, font, blackBrush, new Point(130, ypoint1));
                    ypoint1 += 40;
                    g.DrawString(_trx._tipe[i], font, blackBrush, new Point(350, ypoint));
                    g.DrawString(nominal.ToString(), font, blackBrush, new Point(450, ypoint));
                    g.DrawString(saldo.ToString(), font, blackBrush, new Point(600, ypoint));
                    ypoint = ypoint1;
                    saldo += nominal;*/
                }
                g.DrawString(_trx._enddate, font, blackBrush, new Point(50, ypoint1));
                g.DrawString(_trx._jam, font, blackBrush, new Point(130, ypoint1));
                ypoint1 += 40;
                g.DrawString(_trx._tipe[i], font, blackBrush, new Point(350, ypoint));
                g.DrawString(nominal.ToString("N0"), font, blackBrush, new Point(450, ypoint));
                g.DrawString(saldo.ToString("N0"), font, blackBrush, new Point(600, ypoint));
                ypoint = ypoint1;
                if (_trx._tipe[i] == "D")
                    saldo -= nominal;
                else
                    saldo += nominal;
                //saldo += nominal;
            }
            ypoint += 40;
            string halaman = "halaman ke " + _trx._halaman + " dari " + _trx._maxhalaman;
            g.DrawString(halaman, new Font("Calibri", 10, FontStyle.Regular), blackBrush, new Point(600, ypoint));
            _trx._saldo = saldo.ToString();
        }

        public void BukuPenuhPage(object sender, PrintPageEventArgs e)
        {
            StringFormat formatLeft = new StringFormat(StringFormatFlags.NoClip);
            StringFormat formatCenter = new StringFormat(formatLeft);
            formatCenter.Alignment = StringAlignment.Center;

            string logo = "C:\\bniThermal.bmp";
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Graphics g = e.Graphics;
            font = new Font("Arial", 10, FontStyle.Regular);
            Image img = Image.FromFile(logo);

            g.DrawImage(img, (e.PageBounds.Width - img.Width) / 2, 0, img.Width, img.Height);
            //g.DrawString("Cetak Thermal", new Font("Arial", 12, FontStyle.Regular), blackBrush, new Point(5, 10));

            string lokasi = "KCP CIKUPA 3";
            string joint = "Lokasi : " + lokasi;
            g.DrawString(joint, font, blackBrush, new Point(5, 50));

            joint = "Date : " + DateTime.Now.ToString("yyyy-MM-dd");
            g.DrawString(joint, font, blackBrush, new Point(5, 70));

            joint = "No Rekening : " + _trx._rekening.Substring(0,_trx._rekening.Length-4)+"****";
            g.DrawString(joint, font, blackBrush, new Point(5, 120));

            joint = "Nama Nasabah : " + _trx._nasabah;
            g.DrawString(joint, font, blackBrush, new Point(5, 140));
            int saldo = int.Parse(_trx._saldo);
            joint = "Saldo Buku : Rp " + saldo.ToString("N0");
            g.DrawString(joint, font, blackBrush, new Point(5, 160));
            joint = "Harap Menghubungi Costumer Service";
            g.DrawString(joint, font, blackBrush, new Point(5, 210));
            joint = "Untuk Melakukan Penggantian Buku";
            g.DrawString(joint, font, blackBrush, new Point(5, 230));
            joint = "Dengan Menyertakan Struk Ini";
            g.DrawString(joint, font, blackBrush, new Point(5, 250));
        }
        public async Task BukuPenuhPrint(transaksi trx)
        {
            printDoc = new PrintDocument();
            _trx = trx;
            printDoc.PrinterSettings.PrinterName = "BT-T080(U) 1";
            printDoc.BeginPrint += new PrintEventHandler(BeginPrintEH);
            printDoc.EndPrint += new PrintEventHandler(EndPrintEH);
            printDoc.PrintPage += new PrintPageEventHandler(BukuPenuhPage);
            printDoc.Print();
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
            string logo = "C:\\bniThermal.bmp";
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Graphics g = e.Graphics;
            font = new Font("Arial", 10, FontStyle.Regular);
            Image img = Image.FromFile(logo);

            g.DrawImage(img, (e.PageBounds.Width - img.Width) / 2, 0, img.Width, img.Height);
            //g.DrawString("Cetak Thermal", new Font("Arial", 12, FontStyle.Regular), blackBrush, new Point(5, 10));

            string joint = string.Empty;
            
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            date = "Date :" + date;
            string lokasi = "KCP CIKUPA 3";

            joint = "Lokasi : " + lokasi;
            g.DrawString(joint, font, blackBrush, new Point(5, 50));
            g.DrawString(date, font, blackBrush, new Point(5, 70));

            joint = "No Rekening : " + _trx._rekening;
            g.DrawString(joint, font, blackBrush, new Point(5, 120));
            joint = "Nama Nasabah : " + _trx._nasabah;
            g.DrawString(joint, font, blackBrush, new Point(5, 140));
            
            joint = string.Empty;

            int batastrx = _trx._tipe.Length - 10;
            int ypoint = 190;
            //string joint = string.Empty;
            int saldo = int.Parse(_trx._saldo);
            for (int i = batastrx; i < _trx._tipe.Length; i++)
            {
                int nominal = int.Parse(_trx._nominal[i]);
                Random rnd = new Random();
                if (_trx._tipe[i] == "D")
                {
                    saldo -= nominal;
                }
                else
                {
                    saldo += nominal;
                }
                string spasi = " ";
                string nominalprint = nominal.ToString("N0");
                string saldoprint = saldo.ToString("N0");
                joint = joint + _trx._tanggal[i] + spasi + spasi + _trx._tipe[i] + spasi + spasi + nominalprint + spasi + spasi + saldoprint;
                g.DrawString(joint, font, blackBrush, new Point(5, ypoint));
                ypoint += 20;
                joint = string.Empty;
            }
        }
    }
}
