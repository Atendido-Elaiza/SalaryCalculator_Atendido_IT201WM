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

namespace SalaryCalculator_Atendido_IT201WM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtSalary.IsEnabled = false;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtRate.Clear();
            txtHours.Clear();
            txtSalary.Clear();
        }

        private void btnCompute_Click(object sender, RoutedEventArgs e)
        {
            double value1, value2;

            double.TryParse(txtHours.Text, out value1);
            double.TryParse(txtRate.Text, out value2);

            txtSalary.Text = (value1 * value2).ToString("F2");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
