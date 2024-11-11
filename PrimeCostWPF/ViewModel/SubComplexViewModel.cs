using PrimeCostWPF.Core;
using PrimeCostWPF.Model;
using PrimeCostWPF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace PrimeCostWPF.ViewModel
{
    internal class SubComplexViewModel : ViewModelBase
    {
        private ObservableCollection<IProductComponent> _subComplex;
        private INavigationService _navigation;
        private static IProductComponent _selectedSubComplex;
        private static List<object> _dataContext;
        private static SubPosition historyData;
        private static IProductComponent currentSubComplex;





        public INavigationService Navigation
        {
            get => _navigation;
            set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }

        public IProductComponent SelectedSubComplex
        {
            get => _selectedSubComplex;
            set
            {
                _selectedSubComplex = value;
                OnPropertyChanged(nameof(SelectedSubComplex));
                currentSubComplex = _selectedSubComplex;
               


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

        public static IProductComponent getSelectedSubComplex()
        {

            return currentSubComplex;
        }

        public RelayCommand NavigateToBlockViewModel { get; set; }
        public RelayCommand NavigateToSubComplexViewModel { get; set; }

        public static ObservableCollection<IProductComponent> getJsonDataSubComplex() // Метод возвращает данные для Субкомплекса
        {
            return new ObservableCollection<IProductComponent>(); //ConstantsLibrary.root.productComposition
        }

        public SubComplexViewModel(INavigationService navService)
        {
            Navigation = navService;
            SubComplex = getJsonDataSubComplex();
            NavigateToBlockViewModel = new RelayCommand(o => { Navigation.NavigateTo<BlockViewModel>(); }, o => true);
            NavigateToSubComplexViewModel = new RelayCommand(o => { Navigation.NavigateTo<SubComplexViewModel>(); }, o => true);

        }
    }
}
