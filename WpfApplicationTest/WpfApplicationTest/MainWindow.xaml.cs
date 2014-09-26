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

namespace WpfApplicationTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<CheckBox> chblist = new List<CheckBox>();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string str = "";
            foreach (var c in this.chblist)
            {
                if (c.IsChecked == true)
                {
                    str += c.Content + " " + c.Tag + "\n";
                }
            }
            if (str == "")
                MessageBox.Show("Вы не выбрали!");
            else
                MessageBox.Show("Вы выбрали:\n" + str);
            
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
         //  grid.Background = new ImageBrush((ImageSource)(new ImageSourceConverter()).ConvertFromString("Lighthouse.jpg"));
            Uri u = new Uri(@"..\..\Penguins.jpg", UriKind.RelativeOrAbsolute);
            grid.Background = new ImageBrush(new BitmapImage(u));
        //    grid.Background = ;
            this.chb2.Tag = 23;
            foreach (var c in this.grid.Children)
            {
                if (c is CheckBox)
                {
                    this.chblist.Add(c as CheckBox);
                }
            }
            
            imgTest.Source = (ImageSource)(new ImageSourceConverter()).ConvertFromString("Lighthouse.jpg");
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (txbNewProduct.Text == "")
            {
                MessageBox.Show("Введите название нового продукта!");
            }
            else 
            {
                cmbProduct.Items.Add(txbNewProduct.Text);
                txbNewProduct.Text = "";
                MessageBox.Show("Продукт добавлен!");
            }
            

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            foreach (ListBoxItem i in lb1.SelectedItems)
            {
                
                lb2.Items.Add(i);
            }
        }
        

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            foreach (var i in lb2.SelectedItems)
            { 
                
                lb1.Items.Add(i);
            }
        }

        private void sdr_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            pgb.Value = sdr.Value;
        }

        

    }
}
