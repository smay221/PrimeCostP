using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace PrimeCostWPF.Model
{
    public interface IProductComponent
    {
        string Position { get; }
        string Article { get; }
        string Project { get; }
        List<Materials> materials { get; }
        List<SubPosition> SubPositions { get; }
    }

    public interface IMaterial
    {
        string Material { get; set; }
        string Article { get; set; }
        double Count { get; set; }
        double Price { get; set; }
        double Cost { get; set; }
    }
}
