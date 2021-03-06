/*Noah Irving
 * Feb 11 2019
 * IPO model*/

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

namespace _304555IPO
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double length;
            double width;
            double area;

            double.TryParse(txtLength.Text, out length);
            double.TryParse(txtWidth.Text, out width);

            area = length * width;

            lblOutput.Content = "The area is:" + area.ToString (format: "#.00");
        }
    }
}
