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

namespace Elemental
{
    /// <summary>
    /// Interaction logic for Blocks.xaml
    /// </summary>
    public partial class Blocks : Window
    {
        public Blocks()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Lbx_phrases.ItemsSource = App._bl;
            Lbx_phrases.SelectedItem = App._bl;
        }
    }
}
