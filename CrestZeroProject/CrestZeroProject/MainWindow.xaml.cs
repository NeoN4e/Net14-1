using System;
using System.Collections.Generic;
//using System.Linq;
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

namespace CrestZeroProject
{
  
  

    public partial class MainWindow : Window
    {
        PcPlayer PC = new PcPlayer();

        string symbol;
        public MainWindow()
        {
            ChooseSymbolWindow win = new ChooseSymbolWindow();
            //win.ShowDialog();
            //this.symbol = win.Symbol;
            this.symbol = "X";
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            lbSymbol.Content += this.symbol;
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           (sender as Button).Content = this.symbol;
        }


    }

    struct WinLine
    {
        public int X1 ;
        public int X2 ;
        public int X3 ;

        public WinLine(int x1, int x2, int x3)
        {
            X1 = x1;
            X2 = x2;
            X3 = x3;
        }
    }

    class PcPlayer
    {
        List<WinLine> Etalonline = new List<WinLine>();

        public PcPlayer()
        {
            Etalonline.Add(new WinLine(1, 2, 3));
            Etalonline.Add(new WinLine(4, 5, 6));
            Etalonline.Add(new WinLine(7, 8, 9));

            Etalonline.Add(new WinLine(1, 4, 7));
            Etalonline.Add(new WinLine(2, 5, 8));
            Etalonline.Add(new WinLine(3, 6, 9));

            Etalonline.Add(new WinLine(1, 5, 9));
            Etalonline.Add(new WinLine(3, 5, 9));

        }

        public int move(Button enemyB)
        { 
            int tag = (int)enemyB.Tag;

            //if (loseline.Count == 0)
            //{
            //    foreach (var item in Etalonline)
            //    {
            //        if (item.X1 == BNumber || item.X2 == BNumber || item.X3 == BNumber)
            //            loseline.Add(item);
            //    }

            //    Random r = new Random();
            //    int rezalt;
            //    do
            //    {
            //        rezalt = r.Next(1, 9);
            //    } while (rezalt == BNumber);

            //    return rezalt;
            //}

            return 1;
        }
    }
}

