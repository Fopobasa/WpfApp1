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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new CalcPage());
            Manager.MainFrame = MainFrame;
        }
       
        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
            BtnBack.Visibility = Visibility.Hidden;
            BtnFavour.Visibility = Visibility.Visible;
        }

        private void BtnFavour_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new StartPage());
            BtnBack.Visibility = Visibility.Visible;
            BtnFavour.Visibility = Visibility.Hidden;
        }
    }
}
