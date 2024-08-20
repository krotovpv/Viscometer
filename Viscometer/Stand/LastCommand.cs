using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viscometer.Stand
{
    public partial class Stand
    {
        private class LastCommand
        {
            public ICommand Command { get; }
            public bool Status { get; private set; } = false;
            public DateTime UtcDateTimeCreated { get; private set; } = DateTime.UtcNow;
            public LastCommand(ICommand command)
            {
                Command = command;
            }
        }
    }
}
