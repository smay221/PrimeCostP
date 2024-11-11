namespace PrimeCost.Models.Interfaces
{
    public interface IProductComponent
    {
        public ProductType ProductType { get; }
        public string Position { get; }
        public string Article { get; }
        public double Count { get; }
        public double Price { get;  }
        public double TotalCost { get; }





    }
}
