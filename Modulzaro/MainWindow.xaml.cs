using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Modulzaro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly BetegListaViewModel _vm;

        public MainWindow()
        {
            InitializeComponent();
            _vm = new BetegListaViewModel();
            DataContext = _vm;
        }


        private void UjBetegClick(object sender, RoutedEventArgs e)
        {
            BetegAdataiViewModel _bavm = new BetegAdataiViewModel(new Beteg()) { IsNew = true };
            BetegAdatai BetegSzerk = new BetegAdatai { DataContext = _bavm };
            BetegSzerk.ShowDialog();
            var beteglista = _vm.BetegLista;
            if (BetegSzerk.DialogResult == true)
                beteglista.Add(_bavm.Beteg);
        }

        private void BetegSzerkClick(object sender, RoutedEventArgs e)
        {
            if (_vm.ValasztottBeteg != null)
            {
                BetegAdataiViewModel _bavm = new BetegAdataiViewModel(_vm.ValasztottBeteg);
                BetegAdatai BetegSzerk = new BetegAdatai { DataContext = _bavm };
                BetegSzerk.ShowDialog();
            }

        }






    }
}
