using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Viscometer
{
    public class Viscometer
    {
        public string Name { get; set; }
        public string PortName { get; set; }
        public string Number { get; set; }

        public Viscometer(string Name, string PortName, string Number = "")
        { 
            this.Name = Name;
            this.PortName = PortName;
            this.Number = Number;
        }
    }
}
