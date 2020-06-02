using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrasi_HTML.Data
{
    public class transaksi
    {
        public string _rekening { get; set; }
        public string _nasabah { get; set; }
        public string _saldo { get; set; }
        public string _baris { get; set; }
        public string _halaman { get; set; }
        public string _startdate { get; set; }
        public string _enddate { get; set; }
        public string[] _tanggal { get; set; }
        public string[] _sandi { get; set; }
        public string[] _debet { get; set; }
        public string[] _kredit { get; set; }
        public string[] _pengesahan { get; set; }
        public string[] _uraian { get; set; }
        public string[] _tipe { get; set; }
        public string[] _nominal { get; set; }
        public string _jam { get; set; }
        public bool _norek { get; set; }

        public void setNasabah(string strnasabah, string strrekening)
        {
            _nasabah = strnasabah;
            _rekening = strrekening;
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

        public void setTransaksiHistori(string[] struraian, string[] strtipe, string[] strnominal, string strsaldo, string strtanggal, string strjam)
        {
            _uraian = struraian;
            _tipe = strtipe;
            _nominal = strnominal;
            _saldo = strsaldo;
            _enddate = strtanggal;
            _jam = strjam;
        }

        public void setPrintThermal(string[] strtanggal, string[] strketerangan, string[] strkode, string strsaldo)
        {
            _tanggal = strtanggal;
            _uraian = strketerangan;
            _tipe = strkode;
            _saldo = strsaldo;
        }

        public void clear()
        {
            _rekening = string.Empty;
            _nasabah = string.Empty;
            _saldo = string.Empty;
            _baris = string.Empty;
            _startdate = string.Empty;
            _enddate = string.Empty;
            _jam = string.Empty;
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
    }
}
