using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viscometer.Response
{
    internal class ParameterResponse : IResponseOfStand
    {
        /// <summary>
        /// Первый символ сообщения, является индикатором типа сообщения.
        /// </summary>
        public static char FirstSymbol { get; } = 'A';

        public ParameterResponse(string response)
        {
            if (response.Trim()[0] == FirstSymbol)
            {
                string[] arr = response.Split(',');

                if (arr.Length > 3 && arr[0].Trim() == "0" && arr[1].Trim() == "0")
                {

                }
                else
                {
                    Console.WriteLine($"Ошибка в получении данных - {response}");
                }
            }
        }
    }
}
