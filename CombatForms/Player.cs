using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    class Player : IDamageable
    {
        //Stats
        private int m_hp;   //Health
        private int m_mana; //Mana
        private int m_spd;  //Speed
        private int m_def;  //Added defense
        private int m_atk;  //Added attack power

        public int HP { get { return m_hp; } set { m_hp = value; } }
        public int Mana { get { return m_mana; } set { m_mana = value; } }
        public int Speed { get { return m_spd; } set { m_spd = value; } }
        public int Defense { get { return m_def; } set { m_def = value; } }
        public int ExtraAttack { get { return m_atk; } set { m_atk = value; } }


        //Functions
        public void TakeDamage(int d)
        {
            HP = HP - (d - Defense);
        }

    }
}
