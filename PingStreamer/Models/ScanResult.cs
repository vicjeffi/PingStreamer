using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PingStreamer.Models
{
    public class ScanResult
    {
        private CheckInfo _info;
        private float _delay;
        private bool _success;
        private Exception _ex;

        public bool Success { get { return _success; } set { _success = value; } }
        public CheckInfo Info { get { return _info; } set { _info = value; } }
        public float Delay { get { return _delay; } set { _delay = value; } }
        public Exception Error { get { return _ex; } set { _ex = value; } }
        public ScanResult(float delay, bool success, Exception exception)
        {
            _delay = delay;
            _success = success;
            _ex = exception;
        }
    }
}
