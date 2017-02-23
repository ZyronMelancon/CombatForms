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
        public void RandomDeck(int size)
        {
            Deck = new List<Card>();

            Random r = new Random();
            string n = "";

            for (int i = 0; i < size; i++)
            {
                switch (r.Next(1, 3))
                {
                    case 1:
                        n = "ATK";
                        break;
                    case 2:
                        n = "DEF";
                        break;
                    case 3:
                        n = "SPD";
                        break;
                    default:
                        break;
                }

                Deck.Add(new Card(n, r.Next(5, 15), PlayerNum));

            }
        }

        public void Draw()
        {
            while (Hand.Count < 4)
            {
                Hand.Add(Deck[0]);
                Deck.RemoveAt(0);
            }
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
