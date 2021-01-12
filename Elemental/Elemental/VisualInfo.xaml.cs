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

namespace Elemental
{
    /// <summary>
    /// Interaction logic for VisualInfo.xaml
    /// </summary>
    public partial class VisualInfo : Page
    {
        string imgsrc2;
        public VisualInfo()
        {
            InitializeComponent();
        }

        private void txt_1_Loaded(object sender, RoutedEventArgs e)
        {
            var lst13 = from n in App._vi where (n.name.Equals(VisualElement._vid)) select n.image;

            foreach (var x in lst13)
            {
                //to show one value

                imgsrc2 = (x.ToString());
                break;

            }
            ///string imgpth = "N:\\H.png";
            BitmapImage b = new BitmapImage();
            b.BeginInit();
            b.UriSource = new Uri(imgsrc2);
            b.EndInit();
            var imgs = sender as Image;
            imgs.Source = b;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var lst = from n in App._vi where (n.name.Equals(VisualElement._vid)) select n.info;

            foreach (var x in lst)
            {
                //to show one value
                txt_1.Text = (x.ToString());
                break;
            }
        }
    }
}
