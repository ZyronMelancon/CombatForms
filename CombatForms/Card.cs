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
        int m_pnum;
        
        public string Type { get; set; }
        public int Power { get; set; }
        public int PlayerNum { get { return m_pnum; } set { m_pnum = value; } }
        public void GiveDamage(IDamageable other, string type, int amount)
        {
            other.TakeDamage(type, amount);
        }

        public Card(string type, int pwr, int pnum)
        {
            Type = type;
            Power = pwr;
            m_pnum = pnum;
            m_name = type + "\n" + pwr;
        }

        public Card()
        {
        }

        public override string ToString()
        {
            return m_name;
        }
    }
}
