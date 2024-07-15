using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viscometer.Response
{
    internal static class ResponseOfStand
    {
        internal static IResponseOfStand Parse(string response)
        {
            if (ParameterResponse.FirstSymbol == response[0])
                return new ParameterResponse(response);
            if (StartResponse.FirstSymbol == response[0])
                return new StartResponse(response);
            if (EndResponse.FirstSymbol == response[0])
                return new EndResponse(response);
            if (CurrentResponse.FirstSymbol == response[0])
                return new CurrentResponse(response);

            return new ErrorResponse();
        }
    }
}
