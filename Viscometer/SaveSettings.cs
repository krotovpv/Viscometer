using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Viscometer
{
    public static class SaveSettings
    {
        public static List<Viscometer> Viscometers = new List<Viscometer>();

        static SaveSettings()
        {
            Load();
        }

        public static void Save()
        {
            Properties.Settings.Default.DbName = JsonConvert.SerializeObject(Viscometers);
            Properties.Settings.Default.Save();
        }

        public static void Load()
        {
            Viscometers.Clear();
            string strViscosimeters = Properties.Settings.Default.DbName;
            if (strViscosimeters != "")
                Viscometers.AddRange(JsonConvert.DeserializeObject<List<Viscometer>>(strViscosimeters));
        }
    }
}
