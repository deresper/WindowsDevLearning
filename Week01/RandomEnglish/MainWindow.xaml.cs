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

namespace RandomEnglish
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

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            string[] names = { "001", "002", "003", "004", "005", "006", "007", "008", "009", "010" };
            string[] fruits = {"MANGO", "PINEAPPLE", "STRAWBERRY", "COCONUT", "WATERMELON","GRAPE", "PEACH",
                                "KIWI", "DRAGON FRUIT", "SOURSOP"};

            Random rng = new Random();
            int i = rng.Next() % names.Length;
            string name = names[i];
            string context = fruits[i];

            var bitmap = new BitmapImage(new Uri($"/Fruits/img{name}.jpg", UriKind.Relative));
            imgFruit.Source = bitmap;

            lbName.Content = context.ToString();
        }
    }
}
