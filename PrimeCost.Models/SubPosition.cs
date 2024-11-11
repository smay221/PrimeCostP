using Newtonsoft.Json;
using PrimeCost.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrimeCost.Models
{

    public class SubPosition : IProductComponent 
    {
        public List<IProductComponent> ProductComponents { get; set; } = new List<IProductComponent>(); 
        public double TotalCost => Price*Count;
        public ProductType ProductType { get; set; }
        public string Position { get; set; }
        public string Article { get; set; }
        public double Count { get; set; }
        public double Price => ProductComponents.Sum(sp => sp.TotalCost);

        public SubPosition() { }



    }

   
}
