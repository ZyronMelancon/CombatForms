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
        public List<Party> Parties = new List<Party>();
        State current;

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
        abstract public void StateInit();
        abstract public void Hand1Hit();
        abstract public void Hand2Hit();
        abstract public void Hand3Hit();
        abstract public void Hand4Hit();
        abstract public void Field1Hit();
        abstract public void Field2Hit();
    }

    class InitState : State
    {
        public override string Name { get {return "Start";} }
        public override string Desc { get { return "Start state thing lmao"; } }

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
        }

        public override void Hand1Hit()
        {
            throw new NotImplementedException();
        }

        public override void Hand2Hit()
        {
            throw new NotImplementedException();
        }

        public override void Hand3Hit()
        {
            throw new NotImplementedException();
        }

        public override void Hand4Hit()
        {
            throw new NotImplementedException();
        }

        public override void Field1Hit()
        {
            throw new NotImplementedException();
        }

        public override void Field2Hit()
        {
            throw new NotImplementedException();
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
        }

        public override void Hand1Hit()
        {
            throw new NotImplementedException();
        }

        public override void Hand2Hit()
        {
            throw new NotImplementedException();
        }

        public override void Hand3Hit()
        {
            throw new NotImplementedException();
        }

        public override void Hand4Hit()
        {
            throw new NotImplementedException();
        }

        public override void Field1Hit()
        {
            throw new NotImplementedException();
        }

        public override void Field2Hit()
        {
            throw new NotImplementedException();
        }

        public PlayerChooseState(Button fi1, Button fi2, Button fi3, Button fi4, Button ha1, Button ha2, Button ha3, Button ha4, Button na, Player pa, Player ea)
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
}
