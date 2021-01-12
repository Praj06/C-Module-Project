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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string _eleid;
        public static string _grpid;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Rectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            var elementN = (sender as Rectangle).Tag.ToString();
            //temporary static input
            //changes made from here 
            /// string inpt = "Li";
            var lst = from n in App._pt where (n.name.Equals(elementN)) select n.name;

            foreach (var x in lst)
            {
                _eleid = (x.ToString());
                break;
            }

            ElementsList win_elelist = new ElementsList();
            win_elelist.Show();
            
          

        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var groupL = (sender as Rectangle).Tag.ToString();
            //temporary static input
            //changes made from here 
            /// string inpt = "Li";
  

            var lst1 = from n in App._gl where (n.name.Equals(groupL)) select n.name;
            foreach (var x in lst1)
            {
                _grpid = (x.ToString());
                break;
            }
            GroupsList win_grouplist = new GroupsList();
            win_grouplist.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VisualElement win_velist = new VisualElement();
            win_velist.Show();
        }

        private void Buttonblocks_Click(object sender, RoutedEventArgs e)
        {

            Blocks win_block = new Blocks();
            win_block.Show();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Quiz win_block = new Quiz();
            win_block.Show();
        }

        private void Rectangle_MouseLeftButtonUp1(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
