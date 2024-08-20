using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Viscometer.Stand
{
    public partial class Stand
    {
        SerialPort _serialPort;
        private string _lastCommand;
        public delegate void LinkHandler(bool IsSuccess);
        public event LinkHandler StatusLinkTypeTest;
        public event LinkHandler StatusLinkTypeRotor;
        public event LinkHandler StatusLinkTestTime;
        public event LinkHandler StatusLinkTestTemperature;
        public event LinkHandler StatusLinkTestPreheat;
        public event LinkHandler StatusLinkSetDecay;
       
        /// <summary>
        /// Испытательный стенд
        /// </summary>
        /// <param name="serialPort">Порт. Необходимо передавать настроенный порт!</param>
        public Stand(SerialPort serialPort) 
        {
            _serialPort = serialPort;
            _serialPort.DataReceived += _serialPort_DataReceived;
            if (!_serialPort.IsOpen) _serialPort.Open();
        }

        ~Stand() 
        {
            if (_serialPort.IsOpen) _serialPort.Close();
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            if (_serialPort.IsOpen) _serialPort.Close();
        }

        public void SetTypeTest(TestType testType)
        {
            //new Thread()
            if (testType == TestType.Viscosity)
                sentMsg("A 23 1");
            else if (testType == TestType.Scorch)
                sentMsg("A 23 0");
        }

        private void sentMsg(string msg)
        {
            char[] arr = msg.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                _serialPort.Write(arr, i, 1);
                Thread.Sleep(10);
            }
            _lastCommand = msg;
            Thread.Sleep(100);
        }
    }
}
