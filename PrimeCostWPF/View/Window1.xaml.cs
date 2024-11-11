using PrimeCostWPF.Model;
using PrimeCostWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace PrimeCostWPF.View
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            //DataContext = new BlockViewModel();
            //BlockViewModel blockViewModel = new BlockViewModel();
            //blockDataGrid.IsReadOnly = true;
            //List<ProductComposition> productCompositions = rootObject.productComposition;
            //blockDataGrid.ItemsSource = blockViewModel.jsonDataBlockGetter();



            //blockDataGrid.ItemsSource = blockViewModel.jsonDataGetter().productComposition;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void blockDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //BlockViewModel blockViewModel = new BlockViewModel();
            //SubPosition selectedSubPosition = blockViewModel.selectedDataBlockGetter(blockDataGrid.SelectedItem.ToString());
            //var materialsWindow = new Window2(selectedSubPosition);
            //materialsWindow.Show();
        }
    }
    
}
