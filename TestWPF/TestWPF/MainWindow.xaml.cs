using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace TestWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> mPeople = new ObservableCollection<Person>();
        

        public ObservableCollection<Person> People
        {
            get
            {
                return mPeople;
            }
        }

        public int t
        { get { return 1; } }

        public MainWindow()
        {
            DataContext = this;
            //mPeople.Add(new Employee { Name = "x", ManagerName = "foo" });
            //mPeople.Add(new Manager { Name = "y" });
            mPeople.Add(new Manager { Name = "Vasya" });
            mPeople.Add(new Manager { Name = "Petya" });
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mPeople.Add(new Manager { Name = "Vasya" });
        }
    }

}
