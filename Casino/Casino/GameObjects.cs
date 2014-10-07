﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    /// <summary>Описывает карты</summary>
    [Serializable]
    class Cart 
    {
        public int Score;
        public Cart(int score)
        { this.Score = score; }

        public override string ToString()
        {
            return "Cart "+this.Score;
        }
    }

    /// <summary>ТипИгрока</summary>
    enum PlayerType {Human,PC}

    /// <summary>Описывает игрока казино</summary>
    [Serializable]
    class Player 
    {
        /// <summary>Набранные Очки</summary>
        int score = 0;
        public int Score 
        { 
            get { return this.score; }
            private set 
            { 
                this.score = value;

                if (this.score == 21 && On21Score != null) On21Score(this, null);

                if (this.score > 21 && OnOverflow != null) OnOverflow(this, null);
            }
        }

        /// <summary>Человек или Компьютер</summary>
        PlayerType pt;

        /// <summary>Коллекция Карт Игрока</summary>
        List<Cart> CartPool = new List<Cart>();

        public Player(PlayerType pt = PlayerType.PC)
        {
            this.pt = pt;
        }

        /// <summary>Являеться ли текущий игрок человеком</summary>
        /// <returns></returns>
        public bool isHuman()
        {
            if (this.pt == PlayerType.Human) return true;
            return false;
        }

        /// <summary>Добавляет карту в руку</summary>
        /// <returns>Количество очков после добавления</returns>
        public int AddCard(Cart c)
        {
            CartPool.Add(c);
            this.Score += c.Score;

            if (OnCartAdd != null) OnCartAdd(this, c);
            return this.Score;
        }

        /// <summary>Начать новый раунд(сбросить карты и счет)</summary>
        public void Reset()
        {
            CartPool.Clear();
            this.Score = 0;
        }

        /// <summary>Получение карты игроком</summary>
        public event EventDelegate OnCartAdd;
        public delegate void EventDelegate(Player p,Cart c);

        /// <summary>Очко</summary>
        public event EventDelegate On21Score;

        /// <summary>Перебор</summary>
        public event EventDelegate OnOverflow;
    }

    //class GameWin21Exeption : ApplicationException { }
    //class GameOverflowException : ApplicationException { }
    
}
