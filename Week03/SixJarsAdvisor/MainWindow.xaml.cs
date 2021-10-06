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

namespace SixJarsAdvisor
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

        string income;
        Account acc = null;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            acc = new Account()
            {
                NEC = 0,
                LTS = 0,
                EDU = 0,
                FFA = 0,
                PLY = 0,
                GIV = 0
            };
            this.DataContext = acc;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            income = txtIncome.Text;
            double num;
            if (!double.TryParse(income, out num))
            {
                MessageBox.Show("You must enter a numeric value.");
            }
            else
            {
                acc = new Account()
                {
                    NEC = num * 55 / 100,
                    LTS = num * 10 / 100,
                    EDU = num * 10 / 100,
                    FFA = num * 10 / 100,
                    PLY = num * 10 / 100,
                    GIV = num * 5 / 100
                };
                this.DataContext = acc;
            }
        }
    }
}
