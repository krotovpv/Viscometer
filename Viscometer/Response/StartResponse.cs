using System;
using Viscometer.TestObject;

namespace Viscometer.Response
{
    public class StartResponse : IResponseOfStand
    {
        /// <summary>
        /// Первый символ сообщения, является индикатором типа сообщения.
        /// </summary>
        public static char FirstSymbol { get; } = 'S';
        public TestObject.Program Programm { get; }
        public string FullString { get; }
        
        /// <summary>
        /// Заводской номер вискозиметра.
        /// </summary>
        public string FactoryNumber { get; } = "";

        public StartResponse(string response)
        {
            FullString = response;
            if (response.Trim()[0] == FirstSymbol)
            {
                string[] arr = response.Split(',');

                string partStartResponse = "";

                Test.EType _testType = 0;
                RotorType _rotorSize = 0;
                float _setPoint = 0;
                TimeSpan _setTime = new TimeSpan();
                TimeSpan _preheat = new TimeSpan();
                TimeSpan _decay = new TimeSpan();
                float _viscRange = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    partStartResponse = arr[i].Trim();
                    try
                    {
                        if (partStartResponse.Length < 1) break;
                        switch (partStartResponse[0])
                        {
                            case 'S'://Информация о типе испытания и применяемом роторе
                                if (partStartResponse[1] == 'V')
                                    _testType = Test.EType.Viscosity;
                                else if (partStartResponse[1] == 'S')
                                    _testType = Test.EType.Scorch;
                                if (partStartResponse[3] == 'L')
                                    _rotorSize = RotorType.Large;
                                else if (partStartResponse[3] == 'S')
                                    _rotorSize = RotorType.Small; 
                                break;
                            case 'A'://Заданная температура (Set point).
                                _setPoint = float.Parse(partStartResponse.Replace(".", ",").Substring(1)); break;
                            case 'B'://Заданная температура испытания.
                                string[] tmpSetTime = partStartResponse.Substring(1).Trim().Split(':', '.');
                                _setTime = new TimeSpan(0, 0, Convert.ToInt32(tmpSetTime[0]), Convert.ToInt32(tmpSetTime[1]), Convert.ToInt32(tmpSetTime[2])); break;
                            case 'C'://Прогрев.
                                string[] tmpPreheat = partStartResponse.Substring(1).Trim().Split(':', '.');
                                _preheat = new TimeSpan(0, 0, Convert.ToInt32(tmpPreheat[0]), Convert.ToInt32(tmpPreheat[1]), Convert.ToInt32(tmpPreheat[2])); ; break;
                            case 'D'://Релоксация.
                                string[] tmpDecay = partStartResponse.Substring(1).Trim().Split(':', '.');
                                _decay = new TimeSpan(0, 0, Convert.ToInt32(tmpDecay[0]), Convert.ToInt32(tmpDecay[1]), Convert.ToInt32(tmpDecay[2])); break;
                            case 'E'://Visc range
                                _viscRange = float.Parse(partStartResponse.Replace(".", ",").Substring(1)); break;
                            case 'F'://Заводской номер.
                                FactoryNumber = partStartResponse.Substring(1); break;
                            default:
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                Programm = new TestObject.Program(_testType, _rotorSize, _setPoint, _setTime, _preheat, _decay, _viscRange);
            }
            else
            {
                throw new Exception("StartResponse: Первый символ сообщения не соответствует!");
            }
        }
    }
}
