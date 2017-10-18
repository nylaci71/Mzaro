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
using System.Windows.Shapes;

namespace Modulzaro
{
    /// <summary>
    /// Interaction logic for BetegAdatai.xaml
    /// </summary>
    public partial class BetegAdatai : Window
    {
        public BetegAdatai()
        {
            InitializeComponent();
        }

        private void OkClick(object sender, RoutedEventArgs e)
        {
            var BetegAdataiVM = (BetegAdataiViewModel)DataContext;
            if (!BetegAdataiVM.BetegEll())
            {
                MessageBox.Show("Hibás adatok");
                return;
            }
            Close();


        }
    }
}
