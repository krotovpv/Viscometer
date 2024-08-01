using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viscometer.Response
{
    internal class EndResponse : IResponseOfStand
    {
        /// <summary>
        /// Первый символ сообщения, является индикатором типа сообщения.
        /// </summary>
        public static char FirstSymbol { get; } = 'E';
        /// <summary>
        /// Статус испытания. 0-неопределенное, 1-успешно пройдено, 2-первано
        /// </summary>
        public short Status { get; }
        /// <summary>
        /// Начальная вязкость.
        /// </summary>
        public float InitialMU { get; }
        /// <summary>
        /// Минимальная вязкость.
        /// </summary>
        public float MinimumMU { get; }
        /// <summary>
        /// Время необходимое вязкости для увеличения от минимального значения на 3 или 5 пунктов
        /// </summary>
        public TimeSpan T3orT5 { get; }
        /// <summary>
        /// Время необходимое вязкости для увеличения от минимального значения на 10 пунктов
        /// </summary>
        public TimeSpan T10 { get; }
        /// <summary>
        /// Время необходимое вязкости для увеличения от минимального значения на 18 или 35 пунктов
        /// </summary>
        public TimeSpan T18orT35 { get; }
        /// <summary>
        /// Вязкость. ??? Пока непонятно что именно значит. Совподает с результатом испытания.
        /// </summary>
        public float Viscosity_e { get; }
        /// <summary>
        /// Итоговая вязкость.
        /// </summary>
        public float FinalViscosity { get; }
        /// <summary>
        /// Время релоксации.
        /// </summary>
        public TimeSpan Decay { get; }
        /// <summary>
        /// ??? Неизвесный параметр.
        /// </summary>
        public string Simbol_r { get; } = "";

        public EndResponse(string response)
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
                            case 'E'://Информация о результате испытания
                                Status = short.Parse(clearResponse[1].ToString()); break;
                            case 'a'://Начальная вязкость (Initial MU).
                                InitialMU = float.Parse(clearResponse.Replace(".", ",").Substring(1)); break;
                            case 'b'://Минимальная вязкость (Minimum MU).
                                MinimumMU = float.Parse(clearResponse.Replace(".", ",").Substring(1)); break;
                            case 'c'://t3 or t5.
                                string[] tmpT3orT5 = clearResponse.Substring(1).Trim().Split(':', '.');
                                T3orT5 = new TimeSpan(0, 0, Convert.ToInt32(tmpT3orT5[0]), Convert.ToInt32(tmpT3orT5[1]), Convert.ToInt32(tmpT3orT5[2])); break;
                            case 'd'://t18 or t35.
                                string[] tmpT18orT35 = clearResponse.Substring(1).Trim().Split(':', '.');
                                T18orT35 = new TimeSpan(0, 0, Convert.ToInt32(tmpT18orT35[0]), Convert.ToInt32(tmpT18orT35[1]), Convert.ToInt32(tmpT18orT35[2])); break;
                            case 'q'://t10.
                                string[] tmpT10 = clearResponse.Substring(1).Trim().Split(':', '.');
                                T3orT5 = new TimeSpan(0, 0, Convert.ToInt32(tmpT10[0]), Convert.ToInt32(tmpT10[1]), Convert.ToInt32(tmpT10[2])); break;
                            case 'e'://???.
                                Viscosity_e = float.Parse(clearResponse.Replace(".", ",").Substring(1)); break;
                            case 'f'://Релаксация (Decay)
                                string[] tmpTDecay = clearResponse.Substring(1).Trim().Split(':', '.');
                                Decay = new TimeSpan(0, 0, Convert.ToInt32(tmpTDecay[0]), Convert.ToInt32(tmpTDecay[1]), Convert.ToInt32(tmpTDecay[2])); break;
                            case 'p'://Итоговая вязкость.
                                FinalViscosity = float.Parse(clearResponse.Replace(".", ",").Substring(1)); break;
                            case 'r'://???.
                                Simbol_r = clearResponse.Substring(1); break;
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
