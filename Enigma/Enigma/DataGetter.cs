using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;

namespace Enigma
{
    public class DataGetter
    {
        static private Dictionary<string, string> data;

        public static string Alphabet => data["alphabet"];
        public static string RotorL => data["rotorL"];
        public static string RotorM => data["rotorM"];
        public static string RotorR => data["rotorR"];
        public static string Reflector => data["reflector"];
        public static int Li => int.Parse(data["Li"]);
        public static int Mi => int.Parse(data["Mi"]);
        public static int Ri => int.Parse(data["Ri"]);

        static DataGetter()
        {
            data = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("data.json"));
        }
    }
}
