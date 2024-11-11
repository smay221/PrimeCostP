using PrimeCostWPF.Core;

namespace PrimeCostWPF.ViewModel
{
    public enum BlockType
    {
        Material,
        Subposition
    }


    internal class BlockItemViewModel: ViewModelBase
    {
        public BlockType BlockType { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Cost { get; set; } = string.Empty;
        public string Article { get; set; } = string.Empty;
    }
}