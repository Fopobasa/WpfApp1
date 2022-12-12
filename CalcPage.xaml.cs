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
    /// Логика взаимодействия для CalcPage.xaml
    /// </summary>
    public partial class CalcPage : Page
    {
        Calc calc = new Calc();
        public CalcPage()
        {
            InitializeComponent();
            CmbBox.ItemsSource = AppData.db.Types.ToList();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            switch(CmbBox.SelectedIndex)
            {
                case 0:
                    Img.Source = new BitmapImage(new Uri("Resources/0.png", UriKind.Relative));
                    LbItemLength.Visibility = Visibility.Visible;
                    TbItemLength.Visibility = Visibility.Visible;
                    TbItemLength.Text = string.Empty;
                    LbHip.Visibility = Visibility.Hidden;
                    TbHip.Visibility = Visibility.Hidden;
                    LbChest.Visibility = Visibility.Hidden;
                    TbChest.Visibility = Visibility.Hidden;
                    TbSleeveLength.Visibility = Visibility.Hidden;
                    LbSleeveLength.Visibility = Visibility.Hidden;
                    TbWaist.Visibility = Visibility.Hidden;
                    LbWaist.Visibility = Visibility.Hidden;
                    BtnCalc.Visibility = Visibility.Visible;
                    lbResult.Content = string.Empty;
                    TbChest.Text = "0";
                    TbHip.Text = "0";
                    TbSleeveLength.Text = "0";
                    TbWaist.Text = "0";
                    break;
                case 1:
                    Img.Source = new BitmapImage(new Uri("Resources/1.png", UriKind.Relative));
                    LbWaist.Visibility = Visibility.Visible;
                    TbWaist.Visibility = Visibility.Visible;
                    TbWaist.Text = string.Empty;
                    LbHip.Visibility = Visibility.Visible;
                    TbHip.Visibility = Visibility.Visible;
                    TbHip.Text = string.Empty;
                    LbItemLength.Visibility = Visibility.Visible;
                    TbItemLength.Visibility = Visibility.Visible;
                    TbItemLength.Text= string.Empty;
                    TbSleeveLength.Visibility = Visibility.Hidden;
                    LbSleeveLength.Visibility = Visibility.Hidden;
                    TbChest.Visibility = Visibility.Hidden;
                    LbChest.Visibility = Visibility.Hidden;
                    BtnCalc.Visibility = Visibility.Visible;
                    lbResult.Content = string.Empty;
                    TbChest.Text = "0";
                    TbSleeveLength.Text = "0";
                    break;
                case 2:
                    Img.Source = new BitmapImage(new Uri("Resources/2.png", UriKind.Relative));
                    LbWaist.Visibility = Visibility.Visible;
                    TbWaist.Visibility = Visibility.Visible;
                    TbWaist.Text = string.Empty;
                    LbHip.Visibility = Visibility.Visible;
                    TbHip.Visibility = Visibility.Visible;
                    TbHip.Text = string.Empty;
                    LbItemLength.Visibility = Visibility.Visible;
                    TbItemLength.Visibility = Visibility.Visible;
                    TbItemLength.Text = string.Empty;
                    TbSleeveLength.Visibility = Visibility.Visible;
                    LbSleeveLength.Visibility = Visibility.Visible;
                    TbSleeveLength.Text= string.Empty;
                    TbChest.Visibility = Visibility.Visible;
                    LbChest.Visibility = Visibility.Visible;
                    TbChest.Text = string.Empty;
                    BtnCalc.Visibility = Visibility.Visible;
                    lbResult.Content = string.Empty;
                    break;
            }
           
        }
        private void BtnCalc_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(TbChest.Text))
                errors.AppendLine("Введите обхват груди");
            if (string.IsNullOrEmpty(TbWaist.Text))
                errors.AppendLine("Введите обхват талии");
            if (string.IsNullOrEmpty(TbHip.Text))
                errors.AppendLine("Введите обхват бедер");
            if (string.IsNullOrEmpty(TbItemLength.Text))
                errors.AppendLine("Введите длину изделия");
            if (string.IsNullOrEmpty(TbSleeveLength.Text))
                errors.AppendLine("Введите длину рукава");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else
            {
                switch (CmbBox.SelectedIndex)
                {
                    case 0:
                        lbResult.Content = Convert.ToDouble(calc.StraightSkirt(Convert.ToDouble(TbItemLength.Text)));
                        break;
                    case 1:
                        lbResult.Content = Convert.ToDouble(calc.Trousers(Convert.ToDouble(TbWaist.Text), Convert.ToDouble(TbHip.Text), Convert.ToDouble(TbItemLength.Text)));
                        break;
                    case 2:
                        lbResult.Content = Convert.ToDouble(calc.StraightDress(Convert.ToDouble(TbWaist.Text), Convert.ToDouble(TbHip.Text), Convert.ToDouble(TbItemLength.Text), Convert.ToDouble(TbSleeveLength.Text), Convert.ToDouble(TbChest.Text)));
                        break;
                }
                BtnSave.Visibility = Visibility.Visible;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Item item= new Item();
            var currentType = CmbBox.SelectedItem as Type;
            item.type_id = currentType.id;
            item.chest_girth = Convert.ToInt32(TbChest.Text);
            item.waist_girth = Convert.ToInt32(TbWaist.Text);
            item.hip_girth= Convert.ToInt32(TbHip.Text);
            item.item_length = Convert.ToInt32(TbItemLength.Text);
            item.sleeve_length = Convert.ToInt32(TbSleeveLength.Text);
            item.result = Convert.ToDecimal(lbResult.Content);
           
            AppData.db.Items.Add(item);
            AppData.db.SaveChanges();
            MessageBox.Show("Параметры добавлены в избранное");
        }

        private void TbChest_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }

        private void TbWaist_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }

        private void TbHip_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }

        private void TbItemLength_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }

        private void TbSleeveLength_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }
    }
}
