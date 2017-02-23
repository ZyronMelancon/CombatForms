using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZUtilities.FSM.Combat;

namespace ZUtilities.FSM
{
    class Card : IDamager
    {
        string m_name;
        string m_type;
        int m_pwr;
        int m_pnum;

        public int PlayerNum { get { return m_pnum; } set { m_pnum = value; } }
        public void GiveDamage(IDamageable other, string type, int amount)
        {
            other.TakeDamage(type, amount);
        }

        public Card(string type, int pwr, int pnum)
        {
            m_type = type;
            m_pwr = pwr;
            m_pnum = pnum;
            m_name = type + "\n" + pwr;
        }
    }
}
