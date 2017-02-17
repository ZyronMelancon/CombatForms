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
        List<IState> States = new List<IState>();
        public List<Party> Parties = new List<Party>();
        IState current;

        public int Phase { get { return m_phase; } }
        public IState CurrentState { get { return current; } }

        //Functions

        public void AddParty(Party p)
        {
            Parties.Add(p);
        }

        public void AddState(IState newstate)
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
                m_stateno = 0;
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





    //ISTate
    interface IState
    {
        void StateInit();
        void Hand1Hit();
        void Hand2Hit();
        void Hand3Hit();
        void Hand4Hit();
        void Field1Hit();
        void Field2Hit();
    }





    //All States under here


    class InitState : IState
    {
        string m_name = "Start";
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

        public void StateInit()
        {
            f1.Enabled = false;
            f2.Enabled = false;
        }

        public override string ToString()
        {
            return m_name;
        }

        public void Hand1Hit()
        {
            throw new NotImplementedException();
        }

        public void Hand2Hit()
        {
            throw new NotImplementedException();
        }

        public void Hand3Hit()
        {
            throw new NotImplementedException();
        }

        public void Hand4Hit()
        {
            throw new NotImplementedException();
        }

        public void Field1Hit()
        {
            throw new NotImplementedException();
        }

        public void Field2Hit()
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

    class PlayerChooseState : IState
    {
        string m_name = "PlayerChoose";

        public override string ToString()
        {
            return m_name;
        }

        public void Field1Hit()
        {
            throw new NotImplementedException();
        }

        public void Field2Hit()
        {
            throw new NotImplementedException();
        }

        public void Hand1Hit()
        {
            throw new NotImplementedException();
        }

        public void Hand2Hit()
        {
            throw new NotImplementedException();
        }

        public void Hand3Hit()
        {
            throw new NotImplementedException();
        }

        public void Hand4Hit()
        {
            throw new NotImplementedException();
        }

        public void StateInit()
        {
            
        }



    }
}
