using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viscometer.Stand
{
    public partial class Stand
    {
        private interface ICommand
        {
            string Prefix { get; }
            string GetCommandString();
        }

        private class SetTestType : ICommand
        {
            private TestType TestType { get; }
            public string Prefix { get; } = "A 23 ";

            private SetTestType(TestType testType)
            {
                TestType = testType;
            }

            public string GetCommandString()
            {
                if (TestType == TestType.Viscosity)
                    return Prefix + "1";
                if (TestType == TestType.Scorch)
                    return Prefix + "0";

                return "";
            }
        }

        private class SetRotorType : ICommand
        {
            private RotorType RotorType { get; }
            public string Prefix { get; } = "A 22 ";

            private SetRotorType(RotorType rotorType)
            {
                RotorType = rotorType;
            }

            public string GetCommandString()
            {
                if (RotorType == RotorType.Large)
                    return Prefix + "1";
                if (RotorType == RotorType.Small)
                    return Prefix + "0";

                return "";
            }
        }
    }
}
