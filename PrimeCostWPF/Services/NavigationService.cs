using PrimeCostWPF.Core;
using PrimeCostWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCostWPF.Services
{
    public interface INavigationService
    {
        ViewModelBase CurrentView { get; }
        void NavigateTo<T>() where T : ViewModelBase;
    }
    public class NavigationService : ObservableObject, INavigationService
    {
        private readonly Func<Type, ViewModelBase> _viewModelFactory;
        private ViewModelBase _currentView;
        public ViewModelBase CurrentView 
        {
            get => _currentView;
            private set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public NavigationService(Func<Type, ViewModelBase> viewModelFactory) 
        {
            _viewModelFactory = viewModelFactory;
        }
        public void NavigateTo<TViewModel>() where TViewModel : ViewModelBase
        {
            //NavigateTo<SubComplexViewModel>();
            ViewModelBase viewModelBase = _viewModelFactory.Invoke(typeof(TViewModel));
            CurrentView = viewModelBase;
        }

        
    }
}
