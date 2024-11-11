using Microsoft.Extensions.DependencyInjection;
using PrimeCostWPF.Core;
using PrimeCostWPF.Services;
using PrimeCostWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PrimeCostWPF
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<MainWindow>(provider => new MainWindow
            {
                DataContext = provider.GetRequiredService<SubComplexViewModel>()
            });
            services.AddSingleton<BlockViewModel>();
            services.AddSingleton<SubComplexViewModel>();
            services.AddSingleton<DownViewModel>(); //AddTransient
            services.AddSingleton<INavigationService, NavigationService>();


            services.AddSingleton<Func<Type, ViewModelBase>>(serviceProvider =>
            viewModelType =>
            (ViewModelBase)serviceProvider.GetRequiredService(viewModelType));

            _serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
            base.OnStartup(e);
        }
    }
}
