using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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
        public void Oblicz_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(aLiczba.Text);
            double b = double.Parse(bLiczba.Text);
            double c = double.Parse(cLiczba.Text);

            double delta = b * b - 4 * a * c;
            wynik.Text ="Delta wynosi: "+ delta.ToString();
        }
    }
}