﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZUtilities.FSM
{
    class Party
    {
        int m_curpla;
        List<Player> m_memb;

        public int CurrentPlayerNumber { get { return m_curpla; } }
        public Player CurrentPlayer { get { return Members[m_curpla]; } }
        public List<Player> Members { get { return m_memb; } set { m_memb = value; } }

        public void AddMember(Player a)
        {
            Members.Add(a);
            a.OnEndTurn += NextPlayer;
        }

        public void NextPlayer()
        {
            if (m_curpla < Members.Count() - 1)
                m_curpla++;
            else
                m_curpla = 0;
        }

        public Party()
        {
            m_curpla = 0;
        }
    }
}
