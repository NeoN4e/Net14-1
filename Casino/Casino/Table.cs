using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    [Serializable]
    class Cart 
    {
        public int Score;
        public Cart(int score)
        { this.Score = score; }
    }

    [Serializable]
    class Table
    {
        /// <summary>Игровая колода</summary>
        List<Cart> CartPool;

        /// <summary>Очки набранные игроком</summary>
        int PlayerScore 
        { 
            get {return playerScore;} 
            set 
            {
                this.playerScore = value; 
                if (onPlayerScoreChenge != null) onPlayerScoreChenge();
            }
        }
        int playerScore;

        /// <summary>Очки набранные Крупье</summary>
        int CasinoScore
        {
            get { return casinoScore; }
            set
            {
                this.casinoScore = value;
                if (onCasinoScoreChenge != null) onCasinoScoreChenge();
            }
        }
        int casinoScore;

        public Table()
        {
            //Инициализация колоды
            this.CartPool = new List<Cart>();

                for (int i = 2; i <= 11; i++)
                {
                    this.CartPool.Add(new Cart(i));
                    this.CartPool.Add(new Cart(i));
                    this.CartPool.Add(new Cart(i));
                    this.CartPool.Add(new Cart(i));
                }

            //2 карты себе 2 карты крупье
                this.playerScore += next().Score;
                this.playerScore += next().Score;
        }

        public Cart next()
        {
            Random r = new Random();

            int index = r.Next(CartPool.Count);

            try { return CartPool[index]; }
            finally { CartPool.RemoveAt(index); }
        }

        public delegate int DelegScoreChenge();

        public event DelegScoreChenge onPlayerScoreChenge;
        public event DelegScoreChenge onCasinoScoreChenge;
    }

    class GameWinExeption : ApplicationException { }
    class GameOverExeption : ApplicationException { }
}
