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

namespace MakeASandwitch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMakeSandwitch_Click(object sender, RoutedEventArgs e)
        {
            string bread = "";
            string veggis = "";
            string meat="";

            CustomSandwitch customSandwitch = new CustomSandwitch();
            customSandwitch.Owner = this;

            customSandwitch.BackValues += (a, b, c) => { bread = a; veggis = b; meat = c; };
            bool? result = customSandwitch.ShowDialog();
            if (result == true)
            {
                lblBread.Content = bread;
                lblVeggis.Content = veggis;
                lblMeat.Content = meat;
            }
            else if (result == false)
            {
                MessageBox.Show("Request canceled","Cancel",MessageBoxButton.OK,MessageBoxImage.Error);
            }

        }
    }
}
