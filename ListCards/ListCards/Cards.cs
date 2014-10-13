using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCardsProject
{
    public class Card
    {
        public int Nomination { get; set; }
        public override string ToString()
        {
            return Nomination.ToString();
        }
    }

    public class ListCards : ObservableCollection<Card>
    {
        public ListCards()
            : base()
        {
            Random r = new Random();
            for(int i=0;i<9;i++)
                Add(new Card(){Nomination=r.Next(6,14)});
        }
    }

}
