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
        GemeLogic GL = new GemeLogic();

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
            Button b = (sender as Button);
            b.Content = this.symbol;

            GL.PressButton(b);

           // int pcTag = GL.GetPcButton();
            
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

        /// <summary>Определяет содержит ли текущая линия заданное значение</summary>
        public bool Contains(int item)
        {
            if (this.X1.Equals(item) || this.X2.Equals(item) || this.X3.Equals(item)) return true;
            return false;
        }
    }

    enum Players { p1, p2 }

    struct PlayerPositionQty
    {
        int p1;
        int p2;

        public PlayerPositionQty(int p1, int p2)
        {
            this.p1=p1;
            this.p2=p2;
        }

        public void incr(Players p)
        {
            if(p == Players.p1) this.p1++;
            else this.p2++;
        }
    }

    class GemeLogic
    {
        Players CurentPlayer;
        Dictionary<WinLine, PlayerPositionQty> Etalonline = new Dictionary<WinLine, PlayerPositionQty>();

        List<Button> ButtonPool = new List<Button>();

        public GemeLogic(UIElementCollection Buttons)
        {
            PlayerPositionQty qty = new PlayerPositionQty(0,0);

            Etalonline.Add(new WinLine(1, 2, 3), qty);
            Etalonline.Add(new WinLine(4, 5, 6), qty);
            Etalonline.Add(new WinLine(7, 8, 9), qty);

            Etalonline.Add(new WinLine(1, 4, 7), qty);
            Etalonline.Add(new WinLine(2, 5, 8), qty);
            Etalonline.Add(new WinLine(3, 6, 9), qty);

            Etalonline.Add(new WinLine(1, 5, 9), qty);
            Etalonline.Add(new WinLine(3, 5, 9), qty);

            foreach (var item in Buttons)
            {
                if (item is Button) ButtonPool.Add(item); 
            }
            //ButtonPool.Add(2);
            //ButtonPool.Add(3);
            //ButtonPool.Add(4);
            //ButtonPool.Add(5);
            //ButtonPool.Add(6);
            //ButtonPool.Add(7);
            //ButtonPool.Add(8);
            //ButtonPool.Add(9);

            CurentPlayer = Players.p1;
        }

        public void PressButton(Button B)
        {
            int tag = (int)B.Tag;
            
            ButtonPool.Remove(B);

            //Запишем ходы
            foreach (var item in Etalonline)
            {
                if (item.Key.Contains(tag)) item.Value.incr(this.CurentPlayer);
            }

            //сменим игрока
            if (this.CurentPlayer == Players.p1) this.CurentPlayer = Players.p2;
            else this.CurentPlayer = Players.p1;
        }

        public Button GetPcButton()
        {
            return this.ButtonPool[this.ButtonPool.Count - 1];
        }
    }
}

