﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO.Ports;
using System.Threading.Tasks;

namespace Integrasi_HTML.Data
{
    public class EDC
    {
        public SerialPort serialPort;
        string dataRespond = string.Empty;
        private string _statusCode = string.Empty;
        private string _respondCode = string.Empty;
        private string _ecr = string.Empty;
        private string _approvalCode = string.Empty;
        public string statusCode => _statusCode;
        public string respondCode => _respondCode;
        public string ecr => _ecr;
        public string approvalCode => _approvalCode;
        string strTransType = string.Empty;
        string dataSplit = string.Empty;
        public AutoResetEvent mre = new AutoResetEvent(false);

        public int intTry = 0;
        public void Clear()
        {
            _statusCode = string.Empty;
            _respondCode = string.Empty;
            _approvalCode = string.Empty;
            dataRespond = string.Empty;
            strTransType = string.Empty;
            dataSplit = string.Empty;
            intTry = 0;
        }
        public static string StringToByteString(string p_str)
        {
            string result = string.Empty;

            try
            {
                string byte_ = string.Empty;

                int j = 0;
                int byte_count = 0;

                for (int i = 0; i < p_str.Length; i++)
                {
                    j++;
                    byte_ += p_str[i];

                    if (j >= 2)
                    {
                        byte_count++;
                        if (byte_count > 1) result += ", ";

                        result += "0x" + byte_;

                        if ((byte_count % 8) == 0)
                        {
                            result += System.Environment.NewLine;
                        }

                        byte_ = string.Empty;
                        j = 0;
                    }
                }
            }

            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }

        public static string HexaAmount(string data_amount)
        {
            data_amount = data_amount.Replace(",", "");
            data_amount = data_amount.Replace(".", "");
            data_amount = data_amount.Replace(" ", "");

            string amount = data_amount + "00";

            string amount_hex = string.Empty;
            foreach (char c in amount)
            {
                amount_hex += "3" + c.ToString();
            }
            string amount_hex_padding = "303030303030303030303030" + amount_hex;
            try
            {
                amount_hex_padding = amount_hex_padding.Substring(amount_hex_padding.Length - 24, 24);
            }
            catch { }

            return amount_hex_padding;
        }

        public static string HexaInvoice(string data_invoice)
        {
            string data_hexa = string.Empty;
            foreach (char c in data_invoice)
            {
                data_hexa += "3" + c.ToString();
            }

            string data_hex_padding = "303030303030" + data_hexa;
            try
            {
                data_hex_padding = data_hex_padding.Substring(data_hex_padding.Length - 12, 12);
            }
            catch { }

            return data_hex_padding;
        }

        public static string HexaBilling(string data_billing)
        {
            string data_hexa = string.Empty;
            foreach (char c in data_billing)
            {
                data_hexa += "3" + c.ToString();
            }

            string data_hexa_padding = "30303030303030303030303030303030" + data_hexa;
            try
            {
                data_hexa_padding = data_hexa_padding.Substring(data_hexa_padding.Length - 32, 32);
            }
            catch { }
            return data_hexa_padding;
        }

        public static string HexaBankFiller(string data_filler)
        {
            return "20202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020";
        }

        public static byte[] StringToByteArray(string p_str)
        {
            byte[] result = null;

            try
            {
                if (!p_str.Contains(","))
                {
                    p_str = StringToByteString(p_str);
                }

                p_str = p_str.Replace(Environment.NewLine, "");
                p_str = p_str.Replace("0x", "");
                p_str = p_str.Replace(" ", "");

                string[] x_bytes = p_str.Split(',');

                result = new byte[x_bytes.Length];
                int i = 0;
                foreach (string x_byte in x_bytes)
                {
                    result[i] = byte.Parse(x_byte, System.Globalization.NumberStyles.HexNumber);
                    i++;
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public static byte[] ByteToStr(string data)
        {
            byte[] bar = Encoding.ASCII.GetBytes(data);
            for (int i = 0; i < bar.Length - 1; i++)
            {
                Console.Write("0x" + bar[i] + ", ");
            }
            return bar;
        }

        public static byte[] LRC(byte[] p_data)
        {
            try
            {
                int length = p_data.Length;

                byte x = p_data[1];

                for (int i = 2; i <= length - 2; i++)
                {
                    x ^= p_data[i];
                }
                p_data[length - 1] = x;
            }
            catch { }

            return p_data;
        }
        public static string ByteArrayToString(byte[] p_bytes)
        {
            string result = string.Empty;

            try
            {
                for (int i = 0; i < p_bytes.Length; i++)
                {
                    result = result + p_bytes[i].ToString("X02");
                }
            }
            catch (Exception ex)
            {
            }

            return result;
        }
        public void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataSplit = string.Empty;
            _respondCode = string.Empty;
            _statusCode = string.Empty;
            _approvalCode = string.Empty;
            Console.WriteLine(dataRespond);
            if (serialPort.IsOpen)
            {
                string dataCurrent = serialPort.ReadExisting();
                dataRespond += dataCurrent;
                Console.WriteLine("Data Current: " + dataCurrent);
                Console.WriteLine("Data Respond: " + dataRespond);
                if (dataRespond.Contains("\x06"))
                {
                    if (dataRespond.Length > 10)
                    {
                        serialPort.Close();
                        Console.WriteLine("EDC ACK");
                        dataSplit = dataRespond.Substring(dataRespond.IndexOf("BNI"));
                        Console.WriteLine("Data Split: " + dataSplit);
                        _statusCode = dataSplit.Substring(4, 2);
                        Console.WriteLine("Status : " + _statusCode);
                    }
                }
                else if (dataRespond.Contains("\x15"))
                {
                    serialPort.Close();
                    Console.WriteLine("EDC NAK");
                    
                }
            }
        }
        public void SendCommand(SerialPort port, string ecrmsg)
        {
            _statusCode = string.Empty;
            string stx = "02";
            string ecr = "424E49"; // BNI;
            string ecr_messsage = string.Empty;
            string etx = "03";
            string lrc = "00";

            dataRespond = string.Empty;

            serialPort.Close();

            string request_BankFiller = string.Empty;

            request_BankFiller = HexaBankFiller("");

            ecr_messsage = ecrmsg
                + request_BankFiller;

            string data = stx
                + ecr
                + ecr_messsage
                + etx
                + lrc;

            byte[] data2 = StringToByteArray(data);
            byte[] data2_with_lrc = LRC(data2);
            //data2[56] = 0x77;
            serialPort.PortName = port.PortName;
            serialPort.BaudRate = 115200;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

            Console.WriteLine("1");
            serialPort.Open();

            serialPort.Write(data2_with_lrc, 0, data2_with_lrc.Length);
            Console.WriteLine("2");

            //serialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }
    }
}

