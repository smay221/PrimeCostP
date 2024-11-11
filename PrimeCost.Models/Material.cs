using PrimeCost.Models.Interfaces;

namespace PrimeCost.Models
{
    public class Material : IProductComponent { 


        public Material()
        {
            
        }

        public ProductType ProductType { get; set; }
        public string Position { get; set; }
        public string Article { get; set; }
        public double Count { get; set; }
        public double Price { get; set; }
        public double TotalCost => Count * Price;
    }

}
