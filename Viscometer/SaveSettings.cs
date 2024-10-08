using Newtonsoft.Json;
using System.Collections.Generic;

namespace Viscometer
{
    public static class SaveSettings
    {
        public static List<TestObject.Viscometer> Viscometers = new List<TestObject.Viscometer>();

        static SaveSettings()
        {
            Load();
        }

        public static void Save()
        {
            Properties.Settings.Default.Viscometers = JsonConvert.SerializeObject(Viscometers);
            Properties.Settings.Default.Save();
        }

        public static void Load()
        {
            Viscometers.Clear();
            string strViscosimeters = Properties.Settings.Default.Viscometers;
            if (strViscosimeters != "")
                Viscometers.AddRange(JsonConvert.DeserializeObject<List<TestObject.Viscometer>>(strViscosimeters));
        }
    }
}
