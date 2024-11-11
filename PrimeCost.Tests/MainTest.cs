using PrimeCost.Models;
using PrimeCost.Models.Interfaces;

namespace PrimeCost.Tests
{
    public class MainTest
    {
        [Fact]
        public void CheckIfJsonReads()
        {
            //ProductComposition productCompositionCollection = ProductComposition.GetProductCompositionsFromJson(ConstantsLibrary.pathToJson);
        }


        [Fact]
        public void CheckIfJsonWrites() 
        {
            ProductComposition productComp = new ProductComposition();
            productComp.Article = "xxx";
            productComp.ProductComponents = new List<IProductComponent>() 
            {
                new SubPosition(){},
                new Material(),
                new SubPosition()
            };

        }



    }
}