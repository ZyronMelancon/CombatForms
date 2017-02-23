using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZUtilities.FSM.Combat;

namespace ZUtilities.FSM
{
    class Player : IDamageable
    {
        //Player parameters
        public string Name { get; set; }
        public int PlayerNum { get; set; }
        public List<Card> Deck { get; set; } = new List<Card>();
        public List<Card> Hand { get; set; } = new List<Card>();
        public Dictionary<string, int> Stats { get; set; }

        //Player stat functions
        public void AddStat(string name, int val)
        {
            Stats.Add(name, val);
        }

        public void RemoveStat(string name)
        {
            Stats.Remove(name);
        }

        public void AlterStat(string name, int val)
        {
            Stats[name] += val;
        }

        public void TakeDamage(string type, int dam)
        {
            if (Stats[type] >= dam)
                Stats[type] -= dam;
            else
                Stats[type] = 0;
        }

        //Card functions
        public void AddCard(Card c)
        {
            Deck.Add(c);
        }

        public void Draw()
        {
                while (Deck.Count > 0)
                {
                    if (Hand.Count > 3)
                        break;
                    else
                    {
                        Hand.Add(Deck[0]);
                        Deck.RemoveAt(0);
                    }
                }
        }

        public Card SetCard(int num)
        {
            return Hand[num];
        }


        //delegate bulls&#*
        public delegate void onEndTurn();

        public onEndTurn OnEndTurn;

        public void EndTurn()
        {
            if (OnEndTurn != null)
                OnEndTurn.Invoke();
        }
        //Constructor
        public Player(string name, int pnum)
        {
            PlayerNum = pnum;
            Stats = new Dictionary<string, int>();
            Name = name;
            Stats.Add("Health", 100);
            Stats.Add("Speed", 50);
            Stats.Add("Defense", 0);
        }
    }
}
