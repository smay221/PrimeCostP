using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PrimeCostWPF.Model;
using PrimeCostWPF.Services;
using PrimeCostWPF.View;
using PrimeCostWPF.ViewModel;

namespace PrimeCostWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
          
            InitializeComponent();
            //DataContext = new BlockViewModel();
            //dataGridSubComplex.IsReadOnly = true;
            //root.productComposition[0].TotalSebes = totalPrice.ToString();
            //rootObject.productComposition[0].TotalSebes = blockViewModel.getTotalPrice();
            //dataGridSubComplex.ItemsSource = blockViewModel.jsonDataSubComplexGetter();
            

        }

    }
}
