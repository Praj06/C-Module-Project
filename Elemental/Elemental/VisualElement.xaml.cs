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
    /// Interaction logic for VisualElement.xaml
    /// </summary>
    public partial class VisualElement : Window
    {
        public static string _vid;
        public VisualElement()
        {
            InitializeComponent();
        }

        private void txt_1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Rectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var visualE = (sender as Rectangle).Tag.ToString();
            //temporary static input
            //changes made from here 
            /// string inpt = "Li";


            var lst1 = from n in App._vi where (n.name.Equals(visualE)) select n.name;
            foreach (var x in lst1)
            {
                _vid = (x.ToString());
                break;
            }
            VisualInfo vi = new VisualInfo();
            myframe.NavigationService.Navigate(vi);
        }
    }
}
