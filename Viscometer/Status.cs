using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viscometer
{
    public static class Status
    {
        public enum TestStatus
        {
            /// <summary>
            /// Испытание не проводилось
            /// </summary>
            Blank = 1,
            /// <summary>
            /// Испытание провалено
            /// </summary>
            Fail = 2,
            /// <summary>
            /// Испытание завершилось успешно
            /// </summary>
            Success = 3,
            /// <summary>
            /// Результат испытания принят испытателем
            /// </summary>
            Handshake = 4,
            /// <summary>
            /// Результат испытания отброшен испытателем
            /// </summary>
            Ignor = 5,
            /// <summary>
            /// Испытание в процессе
            /// </summary>
            Work = 6
        }
    }
}
