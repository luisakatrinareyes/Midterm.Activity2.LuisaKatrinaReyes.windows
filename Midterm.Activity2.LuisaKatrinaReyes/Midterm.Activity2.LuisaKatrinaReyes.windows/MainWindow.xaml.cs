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

namespace Midterm.Activity2.LuisaKatrinaReyes.windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void BtnButton_Click(object sender, RoutedEventArgs e)
        {

            int From = int.Parse(TextBox_From.Text);
            int To = int.Parse(TextBox_To.Text);

            int sum = 0;
            for (int x = From ; x <= To; x++)
            {
                sum += x;
            }
            lblResult.Content = sum.ToString();
        }
    }
}
