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
    /// Interaction logic for GroupsList.xaml
    /// </summary>
    public partial class GroupsList : Window
    {
        string imgsrc1;
        public GroupsList()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var lst = from n in App._gl where (n.name.Equals(MainWindow._grpid)) select n.name;

            foreach (var x in lst)
            {
                //to show one value
                txt_1.Text = (x.ToString());
                break;
            }
            var lst1 = from n in App._gl where (n.name.Equals(MainWindow._grpid)) select n.atomicweight;

            foreach (var x in lst1)
            {
                //to show one value
                txt_2.Text = (x.ToString());
                break;
            }
            var lst2 = from n in App._gl where (n.name.Equals(MainWindow._grpid)) select n.prop;

            foreach (var x in lst2)
            {
                //to show one value
                txt_3.Text = (x.ToString());
                break;
            }
            var lst3 = from n in App._gl where (n.name.Equals(MainWindow._grpid)) select n.properties;

            foreach (var y in lst3)
            {
                //to show one value
                txt_4.Text = (y.ToString());
                break;
            }
       

            var lst5 = from n in App._gl where (n.name.Equals(MainWindow._grpid)) select n.meltingp;

            foreach (var y in lst5)
            {
                //to show one value
                txt_6.Text = (y.ToString());
                break;
            }
        }

        private void txt_7_Loaded(object sender, RoutedEventArgs e)
        {
            var lst6 = from n in App._gl where (n.name.Equals(MainWindow._grpid)) select n.image;

            foreach (var x in lst6)
            {
                //to show one value

                imgsrc1 = (x.ToString());
                break;

            }
            ///string imgpth = "N:\\H.png";
            BitmapImage b = new BitmapImage();
            b.BeginInit();
            b.UriSource = new Uri(imgsrc1);
            b.EndInit();
            var imgs = sender as Image;
            imgs.Source = b;
        }
    }
}
