using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrasi_HTML.Data
{
    public class transaksi
    {
        public string _namacabang { get; set; }
        public string _rekening { get; set; }
        public string _nasabah { get; set; }
        public string _saldo { get; set; }
        public string _baris { get; set; }
        public string _halaman { get; set; }
        public string _maxhalaman { get; set; }
        public string _startdate { get; set; }
        public string _enddate { get; set; }
        public string[] _tanggal { get; set; }
        public string[] _sandi { get; set; }
        public string[] _debet { get; set; }
        public string[] _kredit { get; set; }
        public string[] _pengesahan { get; set; }
        public string[] _uraian { get; set; }
        public string _jumlahtransaksi { get; set; }
        public string[] _tipe { get; set; }
        public string[] _nominal { get; set; }
        public string _jam { get; set; }
        public bool _norek { get; set; }
        public string _printperiode { get; set; }
        public string _alamatnasabah { get; set; }

        public void setcabang(string strnamacabang)
        {
            _namacabang = strnamacabang;
        }
        public void setNasabah(string strnasabah, string strrekening,string alamatnasabah)
        {
            _nasabah = strnasabah;
            _rekening = strrekening;
            _alamatnasabah = alamatnasabah;
        }

        public void setTransaksiPassbook(string strbaris, string strhalaman, string strtanggal, string[] strtipe, string[] strsandi, string[] strnominal, string strsaldo, string[] strpengesahan)
        {
            _baris = strbaris;
            _halaman = strhalaman;
            _startdate = strtanggal;
            _tipe = strtipe;
            _sandi = strsandi;
            _nominal = strnominal;
            _saldo = strsaldo;
            _pengesahan = strpengesahan;
            //_debet = strdebet;
            //_kredit = strkredit;
        }

        public void setTransaksiHistori(string strprintperiode, string[] struraian, string[] strtipe, string[] strnominal, string strsaldo, string strstarttanggal, string strendtanggal, string strjam)
        {
            _printperiode = strprintperiode;
            _uraian = struraian;
            _tipe = strtipe;
            _nominal = strnominal;
            _saldo = strsaldo;
            _startdate = strstarttanggal;
            _enddate = strendtanggal;
            _jam = strjam;
        }

        public void setTransaksiHistori(string strjumlah, string strprintperiode, string[] struraian, string[] strtipe, string[] strnominal, string strsaldo, string strstarttanggal, string strendtanggal, string strjam)
        {
            _jumlahtransaksi = strjumlah;
            _printperiode = strprintperiode;
            _uraian = struraian;
            _tipe = strtipe;
            _nominal = strnominal;
            _saldo = strsaldo;
            _startdate = strstarttanggal;
            _enddate = strendtanggal;
            _jam = strjam;
        }

        public void setTransaksiHistori(string[] struraian, string[] strtipe, string[] strnominal, string strhalaman)
        {
            _uraian = struraian;
            _tipe = strtipe;
            _nominal = strnominal;
            _halaman = strhalaman;
        }

        public void setMaxHalaman(string strmaxhalaman)
        {
            _maxhalaman = strmaxhalaman;
        }

        public void setPrintThermal(string[] strtanggal, string[] strkode, string[] strnominal, string strsaldo)
        {
            _tanggal = strtanggal;
            _nominal = strnominal;
            _tipe = strkode;
            _saldo = strsaldo;
        }

        public void clear()
        {
            _namacabang = string.Empty;
            _rekening = string.Empty;
            _nasabah = string.Empty;
            _saldo = string.Empty;
            _baris = string.Empty;
            _halaman = string.Empty;
            _startdate = string.Empty;
            _enddate = string.Empty;
            _jumlahtransaksi = string.Empty;
            _jam = string.Empty;
            _printperiode = string.Empty;
            _alamatnasabah = string.Empty;
        }

        public void clearArray()
        {
            _tanggal = null;
            _sandi = null;
            _debet = null;
            _kredit = null;
            _uraian = null;
            _tipe = null;
            _pengesahan = null;
            _nominal = null;
        }
        /*public void setTransaksiHistori(string strprintperiode, string[] struraian, string[] strtipe, string[] strnominal, string strsaldo,string strtanggalstart, string strtanggalend, string strjam)
        {
            _printperiode = strprintperiode;
            _uraian = struraian;
            _tipe = strtipe;
            _nominal = strnominal;
            _saldo = strsaldo;
            _startdate = strtanggalstart;
            _enddate = strtanggalend;
            _jam = strjam;
        }*/
    }
}
