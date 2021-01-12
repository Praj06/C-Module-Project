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
    /// Interaction logic for ElementsList.xaml
    /// </summary>
    public partial class ElementsList : Window
    {
        string imgsrc;
        public ElementsList()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var lst = from n in App._pt where (n.name.Equals(MainWindow._eleid)) select n.name;

            foreach (var x in lst)
            {
                //to show one value
                txt_1.Text = (x.ToString());
                break;
            }
            var lst2 = from n in App._pt where (n.name.Equals(MainWindow._eleid)) select n.atomicweight;

            foreach (var y in lst2)
            {
                txt_2.Text = (y.ToString());
                break;
            }
            var lst1 = from n in App._pt where (n.name.Equals(MainWindow._eleid)) select n.fname;

            foreach (var x in lst1)
            {
                //to show one value
                txt_3.Text = (x.ToString());
                break;
            }
            var lst3 = from n in App._pt where (n.name.Equals(MainWindow._eleid)) select n.atomicweight;

            foreach (var x in lst3)
            {
                //to show one value
                txt_4.Text = (x.ToString());
                break;
            }
            var lst4 = from n in App._pt where (n.name.Equals(MainWindow._eleid)) select n.meltingpoint;

            foreach (var x in lst4)
            {
                //to show one value
                txt_5.Text = (x.ToString());
                break;
            }
            var lst5 = from n in App._pt where (n.name.Equals(MainWindow._eleid)) select n.boilingpoint;

            foreach (var x in lst5)
            {
                //to show one value
                txt_6.Text = (x.ToString());
                break;
            }
            var lst6 = from n in App._pt where (n.name.Equals(MainWindow._eleid)) select n.density;

            foreach (var x in lst6)
            {
                //to show one value
                txt_7.Text = (x.ToString());
                break;
            }
            var lst7 = from n in App._pt where (n.name.Equals(MainWindow._eleid)) select n.phaseatroomtemp;

            foreach (var x in lst7)
            {
                //to show one value
                txt_8.Text = (x.ToString());
                break;
            }
            var lst8 = from n in App._pt where (n.name.Equals(MainWindow._eleid)) select n.classification;

            foreach (var x in lst8)
            {
                //to show one value
                txt_9.Text = (x.ToString());
                break;
            }
            var lst9 = from n in App._pt where (n.name.Equals(MainWindow._eleid)) select n.periodnumber;

            foreach (var x in lst9)
            {
                //to show one value
                txt_10.Text = (x.ToString());
                break;
            }
            var lst10 = from n in App._pt where (n.name.Equals(MainWindow._eleid)) select n.groupnumber;

            foreach (var x in lst10)
            {
                //to show one value
                txt_11.Text = (x.ToString());
                break;
            }
            var lst11 = from n in App._pt where (n.name.Equals(MainWindow._eleid)) select n.groupname;

            foreach (var x in lst11)
            {
                //to show one value
                txt_12.Text = (x.ToString());
                break;
            }
            var lst12 = from n in App._pt where (n.name.Equals(MainWindow._eleid)) select n.historyanduses;

            foreach (var x in lst12)
            {
                //to show one value
                txt_13.Text = (x.ToString());
                break;
            }
 
            //  MessageBox.Show(imgsrc.ToString());
        }

        private void txt_14_Loaded(object sender, RoutedEventArgs e)
        {
            var lst13 = from n in App._pt where (n.name.Equals(MainWindow._eleid)) select n.image;

            foreach (var x in lst13)
            {
                //to show one value

                imgsrc = (x.ToString());
                break;

            }
            ///string imgpth = "N:\\H.png";
            BitmapImage b = new BitmapImage();
            b.BeginInit();
            b.UriSource = new Uri(imgsrc);
            b.EndInit();
            var imgs = sender as Image;
            imgs.Source = b;

        }
    }
}
