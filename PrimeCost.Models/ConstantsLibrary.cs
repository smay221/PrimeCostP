using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCost.Models
{
    public class ConstantsLibrary
    {
        public static readonly string pathToJson = File.ReadAllText("C:\\Users\\smirn\\source\\repos\\PrimeCostF\\PrimeCostWPF\\Resource\\TestPrice.txt");
        //public static readonly RootObject root = JsonConvert.DeserializeObject<RootObject>(pathToJson);

    }
}
