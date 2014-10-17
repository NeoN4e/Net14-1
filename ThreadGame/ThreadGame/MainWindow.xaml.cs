using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ThreadGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //static Button Mouse;
     

        class test : System.ComponentModel.INotifyPropertyChanged
        {
            Thickness th;
            public Thickness Th 
            { 
                get{return th;}
                set
                {
                    th = value;
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Th"));
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            test tes = new test();

            Button Mouse = new Button();
            Mouse.Height = 30;
            Mouse.Width = 30;

            Binding bind = new Binding();
            bind.Path = new PropertyPath("Th");
            bind.Source = tes;
            Mouse.SetBinding(Button.MarginProperty, bind);

            this.MainGrid.Children.Add(Mouse);


            
            
            try
            {
                Thread t = new Thread(() =>
                    {
                        try
                        {
                            //Mouse.Margin = new Thickness(Mouse.Margin.Left + 100);
                            //Th = new Thickness(100);
                            for (int i = 0; i < 100; i++)
                            {
                                tes.Th = new Thickness(tes.Th.Left + 10);
                                Thread.Sleep(100);
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    });
                t.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
