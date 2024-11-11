using Newtonsoft.Json;
using PrimeCost.Models.Interfaces;

namespace PrimeCost.Models
{
    public class ProductComposition : IProductComponent
    {
         public string Project { get; set; }
         public List<IProductComponent> ProductComponents { get; set; }

        //public List<Material> materials { get; set; } = new List<Material>();
        //public List<SubPosition> SubPositions { get; set; } = new List<SubPosition>();

        public double TotalSebes => (materials?.Sum(m => m.Cost) ?? 0) + (SubPositions?.Sum(sp => sp.TotalCost) ?? 0);

        public static ProductComposition GetProductCompositionsFromJson(string pathToJson) => JsonConvert.DeserializeObject<ProductComposition>(pathToJson);

        public ProductComposition()
        {
            
        }
    }
}