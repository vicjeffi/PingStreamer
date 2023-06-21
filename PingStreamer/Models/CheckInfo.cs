using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingStreamer.Models
{
    public class CheckInfo
    {
        IPAddress _ipAddress;
        short? _port;
        ScanSettings _scanSettings;
        public IPAddress IPAddress { get { return _ipAddress; } private set { _ipAddress = value; } }
        public short? Port { get { return _port; } private set { _port = value; } }
        public ScanSettings ScanConfigure { get { return _scanSettings; }  private set { _scanSettings = value; } }

        public CheckInfo(IPAddress ip, short port, ScanSettings settings)
        {
            _ipAddress = ip;
            _port = port;
            _scanSettings = settings;
            CheckData();
        }
        public CheckInfo(string ip, short port, ScanSettings settings)
        {
            _ipAddress = ip.ParseToIp();
            _port = port;
            _scanSettings = settings;
            CheckData();
        }
        // To remove after Tests!!!
        public static CheckInfo GetTestInstance()
        {
            Random random = new Random();
            var data = new byte[4];
            random.NextBytes(data);
            IPAddress ip = new IPAddress(data);
            CheckInfo testInfo = new CheckInfo(ip, (short)random.Next(0, 10000), ScanSettings.ScanPortAndIpAdress);
            return testInfo;
        }
        private void CheckData()
        {
            InvalidCheckInfoDataException ex;
            bool result = DataСorrectness(out ex);
            if(!result)
            {
                throw ex;
            }
        }
        private bool DataСorrectness(out InvalidCheckInfoDataException ex)
        {
            switch (ScanConfigure)
            {
                case ScanSettings.ScanPortOnThisPc:
                    if (Port == null)
                    {
                        ex = new InvalidCheckInfoDataException("No port exception!");
                        return false;
                    }
                    else
                    {
                        ex = new InvalidCheckInfoDataException();
                        return true;
                    }
                case ScanSettings.ScanPortAndIpAdress:
                    bool noPort = false;
                    if (Port == null)
                    {
                        noPort = true;
                    }
                    if (IPAddress == null)
                    {
                        ex = new InvalidCheckInfoDataException($"No ip{(noPort ? " and port" : "")} exception!");
                        return false;
                    }
                    else
                    {
                        if (noPort)
                        {
                            ex = new InvalidCheckInfoDataException("No port exception!");
                            return false;
                        }
                        ex = new InvalidCheckInfoDataException();
                        return true;
                    }
                case ScanSettings.ScanIpAdress:
                    if (IPAddress == null)
                    {
                        ex = new InvalidCheckInfoDataException("No ip exception!");
                        return false;
                    }
                    else
                    {
                        ex = new InvalidCheckInfoDataException();
                        return true;
                    }
                default:
                    throw new NotImplementedException("New not implemented object in ScanConfigure enum");
            }
        }
        public override string ToString()
        {
            return $"{(IPAddress != null ? "Ip: " + IPAddress.ToString() : "")}{(Port != null ? " Port: " + Port.ToString() : "")}";
        }
    }
    internal static class StringToIpParser
    {
        public static IPAddress ParseToIp(this string ipAddress)
        {
            try
            {
                IPAddress address = IPAddress.Parse(ipAddress);
                return address;
            }

            catch (ArgumentNullException e)
            {
                MessageBox.Show($"Fatall Error!\nArgumentNullException caught!!!\nSource : \" + {e.Source}\nMessage : \n + {e.Message}");
                throw e;
            }

            catch (FormatException e)
            {
                MessageBox.Show($"Fatall Error!\nFormatException caught!!!\nSource : \" + {e.Source}\nMessage : \" + {e.Message}");
                throw e;
            }

            catch (Exception e)
            {
                MessageBox.Show($"Fatall Error!\nException caught!!!\nSource : \" + {e.Source}\nMessage : \" + {e.Message}");
                throw e;
            }
        }
    }
    [Serializable]
    public class InvalidCheckInfoDataException : Exception
    {
        public InvalidCheckInfoDataException() : base() { }
        public InvalidCheckInfoDataException(string message) : base(message) { }
        public InvalidCheckInfoDataException(string message, Exception inner) : base(message, inner) { }
        
        // Не для того Эксепшона, но пусть будет...
        //public override string ToString()
        //{
        //    return Message == "" ? "Без ошибок" : Message;
        //}
    }
}
