using PrimeCostWPF.Core;
using PrimeCostWPF.Model;
using PrimeCostWPF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace PrimeCostWPF.ViewModel
{
    internal class DownViewModel : ViewModelBase
    {
        private List<object> _goDownData;
        private static List<object> _dataContextRec;
        private SubPosition _selectedBlock = null;
        private INavigationService _navigation;
        private List<SubPosition> historyData = BlockViewModel.getHistoryData();
        private bool isInDown = true;

        public SubPosition SelectedBlock
        {
            get => _selectedBlock;
            set
            {
                _selectedBlock = value;
                OnPropertyChanged(nameof(SelectedBlock));


            }
        }

        public INavigationService Navigation
        {
            get => _navigation;
            set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }
        public List<object> GoDownData
        {
            get => _goDownData;
            set
            {
                _goDownData = value;
                OnPropertyChanged(nameof(GoDownData));

            }
        }
        public List<object> DataContextRec
        {
            get => _dataContextRec;
            set
            {
                _dataContextRec = value;
                OnPropertyChanged(nameof(DataContextRec));
            }
        }
        public RelayCommand NewDataContext { get; set; }
        public RelayCommand GoToPastContext { get; set; }





        public List<object> getJsonDataDown(bool IsGoNext) // Метод возвращает форматированные данные для Блоков
        {
            List<object> jsonData = new List<object>();
            if (_selectedBlock != null)
            {
                var materialData = new ObservableCollection<IMaterial>(_selectedBlock.materials);
                var subPositionData = new ObservableCollection<SubPosition>(_selectedBlock.SubPositions);
                for (int i = 0; i < materialData.Count; i++)
                {
                    jsonData.Add(materialData[i]);

                }
                for (int i = 0; i < subPositionData.Count; i++)
                {
                    jsonData.Add(subPositionData[i]);

                }
                if (IsGoNext)
                {
                    historyData.Add(_selectedBlock);
                }
                GoDownData = jsonData;
            }
           
            return jsonData;
        }

        public void backInContext()
        {
            historyData.RemoveAt(historyData.Count - 1);
            if (historyData.Count == 0)
            {
                Navigation.NavigateTo<BlockViewModel>();
            }
            _selectedBlock = historyData[historyData.Count - 1];
            getJsonDataDown(false);

        }




        public DownViewModel(INavigationService navService)
        {

            GoDownData = BlockViewModel.getDataContext();
            historyData = BlockViewModel.getHistoryData();
            NewDataContext = new RelayCommand(o => { getJsonDataDown(true); }, o => true);
            GoToPastContext = new RelayCommand(o => { backInContext(); }, o => true);


        }



    } 
    
}
