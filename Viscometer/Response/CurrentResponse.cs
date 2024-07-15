using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viscometer.Response
{
    internal class CurrentResponse : IResponseOfStand
    {
        /// <summary>
        /// Первый символ сообщения, является индикатором типа сообщения.
        /// </summary>
        public static char FirstSymbol { get; } = 'L';
        /// <summary>
        /// Время. Сколько пройдено времени от начала испытания mm:ss.f
        /// </summary>
        public TimeSpan Time { get; }
        /// <summary>
        /// Вязкость
        /// </summary>
        public float Viscosity { get; }
        /// <summary>
        /// Температура верхней плиты
        /// </summary>
        public float TemperatureUp { get; }
        /// <summary>
        /// Температура нижней плиты
        /// </summary>
        public float TemperatureDown { get; }

        /// <summary>
        /// Сообщение с текущими данными процесса испытания
        /// </summary>
        /// <param name="response">Сообщение от стенда</param>
        public CurrentResponse(string response)
        {
            if (response.Trim()[0] == FirstSymbol)
            {
                string[] arr = response.Split(',');

                string clearResponse = "";
                for (int i = 1; i < arr.Length; i++)
                {
                    clearResponse = arr[i].Trim();
                    try
                    {
                        switch (clearResponse[0])
                        {
                            case 'a'://Текущее время испытания
                                Time = TimeSpan.Parse(clearResponse.Substring(1)); break;
                            case 'b'://Текущая вязкость (Viscosity)
                                Viscosity = float.Parse(clearResponse.Substring(1)); break;
                            case 'd'://Температура верхней плиты
                                TemperatureUp = float.Parse(clearResponse.Substring(1)); break;
                            case 'e'://Температура нижней плиты
                                TemperatureDown = float.Parse(clearResponse.Substring(1)); break;
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
