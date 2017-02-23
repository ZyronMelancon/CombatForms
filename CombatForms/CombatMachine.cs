using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZUtilities.FSM
{
    class CombatMachine
    {
        int m_phase;
        int m_stateno;
        List<State> States = new List<State>();
        List<Party> Parties = new List<Party>();
        State current;

        public List<Card> Field { get; set; } = new List<Card>();

        public int Phase { get { return m_phase; } }
        public State CurrentState { get { return current; } }

        //Functions

        public void AddParty(Party p)
        {
            Parties.Add(p);
        }

        public void AddState(State newstate)
        {
            States.Add(newstate);

            if (current == null)
            {
                current = newstate;
            }
        }

        public void NextState()
        {
            if (m_stateno < States.Count() - 1)
                m_stateno++;
            else
            {
                m_stateno = 1;
                m_phase++;
            }

            current = States[m_stateno];
        }

        public CombatMachine()
        {
            m_phase = 1;
            m_stateno = 0;
        }

    }

    //All States under here

    abstract class State
    {
        abstract public string Name { get; }
        abstract public string Desc { get; }
        abstract public void StateInit();
        abstract public void Hand1Hit();
        abstract public void Hand2Hit();
        abstract public void Hand3Hit();
        abstract public void Hand4Hit();
        abstract public void Field1Hit();
        abstract public void Field2Hit();
        abstract public void NextHit();
    }

    class InitState : State
    {
        public override string Name { get {return "Start";} }
        public override string Desc { get { return "Start the state mechanism infinite thing lmao"; } }

        Button f1;
        Button f2;
        Button f3;
        Button f4;
        Button h1;
        Button h2;
        Button h3;
        Button h4;
        Button n;
        Player p;
        Player e;

        public override string ToString()
        {
            return Name;
        }

        public override void StateInit()
        {
            f1.Enabled = false;
            f2.Enabled = false;
            f3.Enabled = false;
            f4.Enabled = false;
            h1.Enabled = false;
            h2.Enabled = false;
            h3.Enabled = false;
            h4.Enabled = false;
            f1.Text = "N/A";
            f2.Text = "N/A";
            f3.Text = "N/A";
            f4.Text = "N/A";
            h1.Text = "N/A";
            h2.Text = "N/A";
            h3.Text = "N/A";
            h4.Text = "N/A";

            Random r = new Random();

            while (p.Deck.Count != 30 && e.Deck.Count != 30)
            {
                string namee = "";
                switch (r.Next(1, 4))
                {
                    case 1:
                        namee = "ATK";
                        break;
                    case 2:
                        namee = "DEF";
                        break;
                    case 3:
                        namee = "SPD";
                        break;
                    default:
                        break;
                }
                p.AddCard(new Card(namee, r.Next(5,15), 1));
                switch (r.Next(1, 4))
                {
                    case 1:
                        namee = "ATK";
                        break;
                    case 2:
                        namee = "DEF";
                        break;
                    case 3:
                        namee = "SPD";
                        break;
                    default:
                        break;
                }
                e.AddCard(new Card(namee, r.Next(5,15), 2));
            }
        }

        public override void Hand1Hit()
        {
        }
        public override void Hand2Hit()
        {
        }
        public override void Hand3Hit()
        {
        }
        public override void Hand4Hit()
        {
        }
        public override void Field1Hit()
        {
        }
        public override void Field2Hit()
        {
        }
        public override void NextHit()
        {
        }

        public InitState(Button fi1, Button fi2, Button fi3, Button fi4, Button ha1, Button ha2, Button ha3, Button ha4, Button na, Player pa, Player ea)
        {
            f1 = fi1;
            f2 = fi2;
            f3 = fi3;
            f4 = fi4;
            h1 = ha1;
            h2 = ha2;
            h3 = ha3;
            h4 = ha4;
            n = na;
            p = pa;
            e = ea;
        }
    }

    class PlayerChooseState : State
    {
        public override string Name { get { return "PlayerChoose"; } }
        public override string Desc { get { return "\nPlayer, choose your cards."; } }
        Button f1;
        Button f2;
        Button f3;
        Button f4;
        Button h1;
        Button h2;
        Button h3;
        Button h4;
        Button n;
        Player p;
        Player e;
        List<Card> gf;

        public override string ToString()
        {
            return Name;
        }
        public override void StateInit()
        {
            f1.Enabled = false;
            f2.Enabled = false;
            f3.Enabled = false;
            f4.Enabled = false;
            h1.Enabled = true;
            h2.Enabled = true;
            h3.Enabled = true;
            h4.Enabled = true;
            p.Draw();
            if (p.Hand.Count > 0)
                h1.Text = p.Hand[0].ToString();
            else
                h1.Text = "N/A";
            if (p.Hand.Count > 1)
                h2.Text = p.Hand[1].ToString();
            else
                h2.Text = "N/A";
            if (p.Hand.Count > 2)
                h3.Text = p.Hand[2].ToString();
            else
                h3.Text = "N/A";
            if (p.Hand.Count > 3)
                h4.Text = p.Hand[3].ToString();
            else
                h4.Text = "N/A";
            f1.Text = "N/A";
            f2.Text = "N/A";
        }
        public override void Hand1Hit()
        {
            if (p.Hand.Count > 0)
                if (gf.Count < 2)
                {
                    gf.Add(p.Hand[0]);
                    h1.Enabled = false;
                    h1.Text = "FIELD";

                    if (gf.Count == 1)
                    {
                        f1.Enabled = true;
                        f1.Text = gf[0].ToString();
                    }


                    if (gf.Count == 2)
                    {
                        f2.Enabled = true;
                        f2.Text = gf[1].ToString();

                        h1.Enabled = false;
                        h2.Enabled = false;
                        h3.Enabled = false;
                        h4.Enabled = false;
                    }
                }
        }
        public override void Hand2Hit()
        {
            if (p.Hand.Count > 1)
                if (gf.Count < 2)
                {
                    gf.Add(p.Hand[1]);
                    h2.Enabled = false;
                    h2.Text = "FIELD";

                    if (gf.Count == 1)
                    {
                        f1.Enabled = true;
                        f1.Text = gf[0].ToString();
                    }


                    if (gf.Count == 2)
                    {
                        f2.Enabled = true;
                        f2.Text = gf[1].ToString();

                        h1.Enabled = false;
                        h2.Enabled = false;
                        h3.Enabled = false;
                        h4.Enabled = false;
                    }
                }
        }
        public override void Hand3Hit()
        {
            if (p.Hand.Count > 2)
                if (gf.Count < 2)
                {
                    gf.Add(p.Hand[2]);
                    h3.Enabled = false;
                    h3.Text = "FIELD";

                    if (gf.Count == 1)
                    {
                        f1.Enabled = true;
                        f1.Text = gf[0].ToString();
                    }


                    if (gf.Count == 2)
                    {
                        f2.Enabled = true;
                        f2.Text = gf[1].ToString();

                        h1.Enabled = false;
                        h2.Enabled = false;
                        h3.Enabled = false;
                        h4.Enabled = false;
                    }
                }
        }
        public override void Hand4Hit()
        {
            if (p.Hand.Count > 3)
                if (gf.Count < 2)
                {
                    gf.Add(p.Hand[3]);
                    h4.Enabled = false;
                    h4.Text = "FIELD";

                    if (gf.Count == 1)
                    {
                        f1.Enabled = true;
                        f1.Text = gf[0].ToString();
                    }


                    if (gf.Count == 2)
                    {
                        f2.Enabled = true;
                        f2.Text = gf[1].ToString();

                        h1.Enabled = false;
                        h2.Enabled = false;
                        h3.Enabled = false;
                        h4.Enabled = false;
                    }
                }

        }
        public override void Field1Hit()
        {
            
        }
        public override void Field2Hit()
        {
            
        }

        public override void NextHit()
        {
            foreach (Card c in gf)
            {
                p.Hand.Remove(c);
            }
        }

        public PlayerChooseState(Button fi1, Button fi2, Button fi3, Button fi4, Button ha1, Button ha2, Button ha3, Button ha4, Button na, List<Card> gaf, Player pa, Player ea)
        {
            f1 = fi1;
            f2 = fi2;
            f3 = fi3;
            f4 = fi4;
            h1 = ha1;
            h2 = ha2;
            h3 = ha3;
            h4 = ha4;
            n = na;
            gf = gaf;
            p = pa;
            e = ea;
        }

    }

    class EnemyChooseState : State
    {
        public override string Desc { get { return "\nEnemy has chosen their cards."; } }

        public override string Name { get { return "EnemeyChoose"; } }

        Button f3;
        Button f4;
        Player p;
        Player e;
        List<Card> gf;

        public override void Field1Hit()
        {
        }
        public override void Field2Hit()
        {
        }
        public override void Hand1Hit()
        {
        }
        public override void Hand2Hit()
        {
        }
        public override void Hand3Hit()
        {
        }
        public override void Hand4Hit()
        {
        }
        public override void NextHit()
        {
        }
        public override void StateInit()
        {
            
            e.Draw();

            //Enemy AI always chooses first two cards in hand
            if (e.Hand.Count > 1)
            {
                gf.Add(e.Hand[0]);
                gf.Add(e.Hand[1]);
                f3.Enabled = true;
                f4.Enabled = true;
                f3.Text = "CHOSEN";
                f4.Text = "CHOSEN";
            }
            else if (e.Hand.Count == 1)
            {
                gf.Add(e.Hand[0]);
                f3.Enabled = true;
                f3.Text = "CHOSEN";
            }
            else
            { }
            
            foreach (Card c in gf)
                e.Hand.Remove(c);
        }

        public override string ToString()
        {
            return Name;
        }
        public EnemyChooseState(Button fi3, Button fi4, Player pl, Player en, List<Card> gaf)
        {
            f3 = fi3;
            f4 = fi4;
            p = pl;
            e = en;
            gf = gaf;
        }
    }

    class FieldFlipState : State
    {
        Button f3;
        Button f4;
        Button n;
        Label ph;
        Label ps;
        Label eh;
        Label es;
        List<Card> gf;
        Player p;
        Player e;
        int damtaken = 0;
        int damgiven = 0;
        string whosfirst = "";

        public override string Desc
        {
            get
            {
                return "\nCards revealed! " + whosfirst + " You take " + damtaken + " damage. Rival takes " + damgiven + " damage.";
            }
        }

        public override string Name { get { return "FieldFlip"; } }

        public override void Field1Hit()
        {
        }

        public override void Field2Hit()
        {
        }

        public override void Hand1Hit()
        {
        }

        public override void Hand2Hit()
        {
        }

        public override void Hand3Hit()
        {
        }

        public override void Hand4Hit()
        {
        }

        public override void NextHit()
        {
            //Resets these values so they aren't added upon in the next phase
            damgiven = 0;
            damtaken = 0;

            //Clears off the field
            int size = gf.Count;
            for (int i = 0; i < size; i++)
            {
                gf.RemoveAt(0);
            }

            //Resets enemy field text
            f3.Text = "N/A";
            f4.Text = "N/A";
        }

        public override void StateInit()
        {
            for (int i = 0; i < gf.Count; i++)
            {
                if (gf[i].PlayerNum == 2)
                {
                    f3.Text = gf[i].ToString();
                    f4.Text = gf[i + 1].ToString();
                    break;
                }
            }

            //Speed counted and applied first
            for (int i = 0; i < gf.Count; i++)
            {
                if (gf[i].Type == "SPD" && gf[i].PlayerNum == 2)
                    e.Stats["Speed"] += gf[i].Power;
                else if (gf[i].Type == "SPD" && gf[i].PlayerNum == 1)
                    p.Stats["Speed"] += gf[i].Power;
            }

            //If one player's speed is above the other...
            if (p.Stats["Speed"] > e.Stats["Speed"])
            {
                


            }


            //Attacks and defenses counted simultaneously if both speeds are the same

            for (int i = 0; i < gf.Count; i++)
            {
                if (gf[i].Type == "ATK" && gf[i].PlayerNum == 2)
                    damtaken += gf[i].Power;
                else if (gf[i].Type == "ATK" && gf[i].PlayerNum == 1)
                    damgiven += gf[i].Power;
                else if (gf[i].Type == "DEF" && gf[i].PlayerNum == 1)
                    damtaken -= gf[i].Power;
                else if (gf[i].Type == "DEF" && gf[i].PlayerNum == 2)
                    damgiven -= gf[i].Power;
            }

            if (damgiven < 0)
                damgiven = 0;

            if (damtaken < 0)
                damtaken = 0;

            //Apply damages
            p.Stats["Health"] -= damtaken;
            e.Stats["Health"] -= damgiven;

            //Check if either players are dead
            

            //Display new stats
            eh.Text = "Health: " + Convert.ToString(e.Stats["Health"]);
            ph.Text = "Health: " + Convert.ToString(p.Stats["Health"]);
            es.Text = "Speed: " + Convert.ToString(e.Stats["Speed"]);
            ps.Text = "Speed: " + Convert.ToString(p.Stats["Speed"]);


        }

        public override string ToString()
        {
            return Name;
        }

        public FieldFlipState(Button fi3, Button fi4, Player pl, Player en, Label plh, Label pls, Label enh, Label ens, Button nb, List<Card> gaf)
        {
            f3 = fi3;
            f4 = fi4;
            n = nb;
            p = pl;
            e = en;
            ph = plh;
            eh = enh;
            ps = pls;
            es = ens;
            gf = gaf;
        }
    }
}
