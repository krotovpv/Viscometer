using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Viscometer
{
    public interface IResponseOfStand
    {

    }

    /// <summary>
    /// Ответ от стенда
    /// </summary>
    public static class ResponseOfStand
    {
        public static IResponseOfStand Parse(string response)
        {
            if (ParameterResponse.FirstSymbol == response[0])
                return new ParameterResponse(response);
            if (StartResponse.FirstSymbol == response[0])
                return new StartResponse(response);
            if (EndResponse.FirstSymbol == response[0])
                return new EndResponse(response);
            if (CurrentResponse.FirstSymbol == response[0])
                return new CurrentResponse(response);

            return null;
        }
    }

    /// <summary>
    /// Ответ стенда после получения установочных параметров
    /// </summary>
    public class ParameterResponse : IResponseOfStand
    {
        public static char FirstSymbol { get; } = 'A';

        public ParameterResponse(string response)
        {
            if (response[0] == FirstSymbol)
            {

            }
        }
    }

    /// <summary>
    /// Ответ стенда в процессе испытания о текущих пораметрах испытания
    /// </summary>
    public class CurrentResponse : IResponseOfStand
    {
        public static char FirstSymbol { get; } = 'L';

        public CurrentResponse(string response)
        {
            if (response[0] == FirstSymbol)
            {

            }
        }
    }

    /// <summary>
    /// Ответ стенда о начале испытания с указанными в ответе параметрами
    /// </summary>
    public class StartResponse : IResponseOfStand
    {
        public static char FirstSymbol { get; } = 'S';

        public StartResponse(string response)
        {
            if (response[0] == FirstSymbol)
            {

            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class EndResponse : IResponseOfStand
    {
        public static char FirstSymbol { get; } = 'E';

        public EndResponse(string response)
        {
            if (response[0] == FirstSymbol)
            {

            }
        }
    }
}
