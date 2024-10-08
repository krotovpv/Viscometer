namespace Viscometer.TestObject
{
    public class Viscometer
    {
        public string Name { get; set; }
        public string PortName { get; set; }
        public string FactoryNumber { get; set; }

        public Viscometer(string Name, string PortName, string Number = "")
        { 
            this.Name = Name;
            this.PortName = PortName;
            this.FactoryNumber = Number;
        }
    }
}
