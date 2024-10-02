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

namespace egz2desktopowa
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

        private void Sprawdz_Click(object sender, RoutedEventArgs e)
        {
            if (RadioButtonPocztowka.IsChecked == true)
            {
                Cena.Content = "Cena: 1 zł";
                Zdjecie.Source = new BitmapImage(new Uri(@"/Images/pocztowka.png", UriKind.Relative));

            }
            else if (RadioButtonList.IsChecked == true)
            {
                Cena.Content = "Cena: 1,5 zł";
                Zdjecie.Source = new BitmapImage(new Uri(@"/Images/list.png", UriKind.Relative));
            }
            else if (RadioButtonPaczka.IsChecked == true)
            {
                Cena.Content = "Cena: 10 zł";
                Zdjecie.Source = new BitmapImage(new Uri(@"/Images/paczka.png", UriKind.Relative));
            }            
        }
    }
}