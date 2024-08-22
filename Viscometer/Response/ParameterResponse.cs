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
        public static char FirstSymbol { get; } = '0';
        public EState State { get; }
        public string ResponseCode { get; }

        public ParameterResponse(string response)
        {
            if (response.Trim()[0] == FirstSymbol)
            {
                string[] arr = response.Split(',');

                if (arr.Length < 3)
                {
                    State = EState.Unknown_Error;
                    Console.WriteLine($"Ошибка в получении данных - {response}");
                    return;
                }

                switch (arr[1].Trim())
                {
                    case "0": State = EState.Success; break;
                    case "-1": State = EState.Illegal_Comand; break;
                    case "-2": State = EState.Out_Of_Range; break;
                    case "-3": State = EState.Number_Too_Large; break;
                    case "-4": State = EState.Illegal_Comand; break;
                    case "-5": State = EState.Value_Not_Changed; break;
                    case "-6": State = EState.Invalid_string; break;
                    default:
                        State = EState.Unknown_Error;
                        Console.WriteLine($"Ошибка в получении данных - {response}");
                        return;
                }

                if (State == EState.Success)
                {
                    ResponseCode = arr[2].Trim().Split(' ')[1];
                }
            }
        }

        public enum EState
        {
            Success = 0,
            Illegal_Comand = -1,
            Out_Of_Range = -2,
            Number_Too_Large = -3,
            Illegal_Id = -4,
            Value_Not_Changed = -5,
            Invalid_string = -6,
            Unknown_Error = -99
        }
    }
}
