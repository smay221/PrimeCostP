using Newtonsoft.Json;
using PrimeCostWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace PrimeCostWPF.Model
{
    public class Materials : IMaterial
    {
        public string Material { get; set; }
        public string Article { get; set; }
        public double Count { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }
    }

    public class SubPosition : IProductComponent
    {
        public string Position { get; set; }
        public string Article { get; set; }
        public string Project { get; set; }
        public List<Materials> materials { get; set; } = new List<Materials>(); 
        public List<SubPosition> SubPositions { get; set; } = new List<SubPosition>(); 

        public double Cost => CostCalc(materials);

        private double CostCalc(List<Materials> materials)
        {
            return materials?.Sum(m => m.Cost) ?? 0; 
        }

        public double TotalSebes => Cost + (SubPositions?.Sum(sp => sp.TotalSebes) ?? 0);
    }

    public class ProductComposition : IProductComponent
    {
        public string Position { get; set; }
        public string Article { get; set; }
        public string Project { get; set; }
        public List<Materials> materials { get; set; } = new List<Materials>();
        public List<SubPosition> SubPositions { get; set; } = new List<SubPosition>();

        public double TotalSebes => (materials?.Sum(m => m.Cost) ?? 0) + (SubPositions?.Sum(sp => sp.TotalSebes) ?? 0);

        public static List<ProductComposition> GetProductCompositionsFromJson(string pathToJson) => JsonConvert.DeserializeObject<List<ProductComposition>>(pathToJson);
    }

    //public class RootObject
    //{
    //    public List<ProductComposition> productComposition { get; set; }

    //    public RootObject(string path)
    //    {
 
    //    }

    //    public static RootObject root(string pathToJson) => JsonConvert.DeserializeObject<RootObject>(pathToJson);
    //}
}
