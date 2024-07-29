using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viscometer.Response
{
    internal class StartResponse : IResponseOfStand
    {
        /// <summary>
        /// Первый символ сообщения, является индикатором типа сообщения.
        /// </summary>
        public static char FirstSymbol { get; } = 'S';
        /// <summary>
        /// Тип испытания. Ex.: V - Viscosity, S - Scorch.
        /// </summary>
        public char TestType { get; }
        /// <summary>
        /// Размер ротора. Ex.: L - Large, S - Small.
        /// </summary>
        public char RotorSize { get; }
        /// <summary>
        /// Заданная температура испытания. 000.0
        /// </summary>
        public float SetPoint { get; }
        /// <summary>
        /// Заданное время испытания. mmm:ss.f
        /// </summary>
        public TimeSpan SetTime { get; }
        /// <summary>
        /// Прогрев. Осуществляется перед испытанием для лучшей стабилизации температуры. 000.0
        /// </summary>
        public TimeSpan Preheat { get; }
        /// <summary>
        /// Время для релоксации. mmm:ss.f
        /// </summary>
        public TimeSpan Decay { get; }
        /// <summary>
        /// Диапазон вязкости
        /// </summary>
        public float ViscRange { get; }
        /// <summary>
        /// Заводской номер вискозиметра.
        /// </summary>
        public string FactoryNumber { get; } = "";

        public StartResponse(string response)
        {
            if (response.Trim()[0] == FirstSymbol)
            {
                string[] arr = response.Split(',');

                string clearResponse = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    clearResponse = arr[i].Trim();
                    try
                    {
                        switch (clearResponse[0])
                        {
                            case 'S'://Информация о типе испытания и применяемом роторе
                                TestType = clearResponse[1];
                                RotorSize = clearResponse[3]; break;
                            case 'A'://Заданная температура (Set point).
                                SetPoint = float.Parse(clearResponse.Replace(".", ",").Substring(1)); break;
                            case 'B'://Заданная температура испытания.
                                string[] tmpSetTime = clearResponse.Substring(1).Trim().Split(':', '.');
                                SetTime = new TimeSpan(0, 0, Convert.ToInt32(tmpSetTime[0]), Convert.ToInt32(tmpSetTime[1]), Convert.ToInt32(tmpSetTime[2])); break;
                            case 'C'://Прогрев.
                                string[] tmpPreheat = clearResponse.Substring(1).Trim().Split(':', '.');
                                Preheat = new TimeSpan(0, 0, Convert.ToInt32(tmpPreheat[0]), Convert.ToInt32(tmpPreheat[1]), Convert.ToInt32(tmpPreheat[2])); ; break;
                            case 'D'://Релоксация.
                                string[] tmpDecay = clearResponse.Substring(1).Trim().Split(':', '.');
                                Decay = new TimeSpan(0, 0, Convert.ToInt32(tmpDecay[0]), Convert.ToInt32(tmpDecay[1]), Convert.ToInt32(tmpDecay[2])); break;
                            case 'E'://Visc range
                                ViscRange = float.Parse(clearResponse.Replace(".", ",").Substring(1)); break;
                            case 'F'://Заводской номер.
                                FactoryNumber = clearResponse.Substring(1); break;
                            default:
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
    }
}
