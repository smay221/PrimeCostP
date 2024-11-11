using Newtonsoft.Json.Linq;
using PrimeCostWPF.Core;
using PrimeCostWPF.Model;
using PrimeCostWPF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Net.WebRequestMethods;

namespace PrimeCostWPF.ViewModel
{
    internal class BlockViewModel: ViewModelBase
    {
        private ObservableCollection<IProductComponent> _subComplex;
      
        private static List<object> _dataContext;
        private INavigationService _navigation;
        private static List<SubPosition> historyData = new List<SubPosition>();

        public INavigationService Navigation
        {
            get => _navigation;
            set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }

        private static SubPosition _selectedBlock;
        public SubPosition SelectedBlock
        {
            get => _selectedBlock;
            set
            {
                _selectedBlock = value;
                OnPropertyChanged(nameof(SelectedBlock));
                DataContext = DataHandler.chageLevelList(_selectedBlock); 


            }
        }


        private ObservableCollection<BlockItemViewModel> _block;
        public ObservableCollection<BlockItemViewModel> Block
        {
            get => _block;
            set
            {
                _block = value;
                OnPropertyChanged(nameof(Block));
            }
        }
        public ObservableCollection<IProductComponent> SubComplex 
        {
            get => _subComplex;
            set
            {
                _subComplex = value;
                OnPropertyChanged(nameof(SubComplex));
            }
        }
        public List<object> DataContext
        {
            get => _dataContext;
            set
            {
                _dataContext = value;
                OnPropertyChanged(nameof(DataContext));

            }
        }

        public static List<object> getDataContext()
        {
            historyData.Add(_selectedBlock);
            return _dataContext;
        }

        public static List<SubPosition> getHistoryData()
        {
            return historyData;
        }




        public List<object> getJsonDataBlock(bool IsGoNext) // Метод возвращает форматированные данные для Блоков
        {
            List<object> jsonData = new List<object>();
            //if (SubComplexViewModel.getSelectedSubComplex() != null && SubComplexViewModel.getSelectedSubComplex() != null)
            //{
            //    var materialData = new ObservableCollection<IMaterial>(SubComplexViewModel.getSelectedSubComplex().materials);
            //    var subPositionData = new ObservableCollection<SubPosition>(SubComplexViewModel.getSelectedSubComplex().SubPositions);
            //    for (int i = 0; i < materialData.Count; i++)
            //    {
            //        jsonData.Add(materialData[i]);

            //    }
            //    for (int i = 0; i < subPositionData.Count; i++)
            //    {
            //        jsonData.Add(subPositionData[i]);

            //    }
            //    if (IsGoNext)
            //    {
            //        historyData.Add(_selectedBlock);
            //    }
            //    Block = jsonData;
            //}
            return jsonData;
        }

        public RelayCommand NavigateToDownViewModel { get; set; }

        public BlockViewModel(INavigationService navService)
        {
            Navigation = navService;
            Block = new ObservableCollection<BlockItemViewModel>(); // new  (getJsonDataBlock(false))
            NavigateToDownViewModel = new RelayCommand(o => { Navigation.NavigateTo<DownViewModel>(); }, o => true);




        }
        
    }
}
