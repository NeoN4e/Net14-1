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

namespace ListCardsProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListCards list = new ListCards();

        public MainWindow()
        {
         //   DataContext = this;
           // ListCards list = new ListCards();
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            //ListCards list = new ListCards();
            listCards.ItemsSource = list;
            //listCards.ItemTemplate = new DataTemplate(new Card());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var str = newElem.Text.Trim();
            if (str != "")
                list.Add(new Card() { Nomination = Convert.ToInt32(str) });

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(list.Count != 0)
                list.RemoveAt(0);
        }
    }
}
