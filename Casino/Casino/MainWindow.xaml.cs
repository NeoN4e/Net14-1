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

namespace Casino
{
    
    public partial class MainWindow : Window
    {
        Table table;
        Player human;

        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void StartGame(object sender, RoutedEventArgs re)
        {
            //Создадим стол
            this.table = new Table();

            //Добавим игроков
            this.human = new Player(PlayerType.Human);
            human.OnCartAdd     += (p, e) => { this.PlayerScore.Content = p.Score; };
            human.OnOverflow    += (p, c) => { this.PlayerScore.Foreground = Brushes.Red;};
            human.On21Score     += (p, c) => { this.PlayerScore.Foreground = Brushes.Green; };

            this.table.PlayerList.Add(human);

            Player Casino = new Player(PlayerType.PC);
            Casino.OnCartAdd += (p, e) => { this.CasinoScore.Content = p.Score; };
            this.table.PlayerList.Add(Casino);
 
            //Начнем
            table.StartGame();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            human.AddCard( table.GetNextCart());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            table.EndGame();
        }
    }
}
