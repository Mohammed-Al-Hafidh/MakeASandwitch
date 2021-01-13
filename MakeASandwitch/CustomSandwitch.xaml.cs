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

namespace MakeASandwitch
{
    /// <summary>
    /// Interaction logic for CustomSandwitch.xaml
    /// </summary>
    public partial class CustomSandwitch : Window
    {
        public event Action<string, string, string> BackValues;
        public CustomSandwitch()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string bread = combBread.Text;
            string vegetables = "";
            if (chkbLettuce.IsChecked == true)
            {
                vegetables += chkbLettuce.Content.ToString() + " ";
            }
            if (chkbTomatos.IsChecked == true)
            {
                vegetables += chkbTomatos.Content.ToString() + " ";
            }
            if (chkbCucumbers.IsChecked == true)
            {
                vegetables += chkbCucumbers.Content.ToString() + " ";
            }
            string meats = "";
            if (rdbChicken.IsChecked == true)
                meats = rdbChicken.Content.ToString();
            if (rdbTurki.IsChecked == true)
                meats = rdbTurki.Content.ToString();
            if (rdbTofu.IsChecked == true)
                meats = rdbTofu.Content.ToString();
            BackValues?.Invoke(bread, vegetables, meats);
            DialogResult = true;

            
        }
    }
}
