using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD47Gabriel_Can_Vidal_Programming1_a3
{
    class petfight
    {
        private int m_Attack;
        private int m_Defense;
        private int m_HitPoints;
        private string m_petName;

        public int Attack
        {
            get
            {
                return m_Attack;
            }

            set
            {
                m_Attack = value;
            }
        }

        public int Defense
        {
            get
            {
                return m_Defense;
            }

            set
            {
                m_Defense = value;
            }
        }

        public int HitPoints
        {
            get
            {
                return m_HitPoints;
            }

            set
            {
                m_HitPoints = value;
            }
        }

            // constructor

            public petfight(string Pokemon, int HitPoints, int Attack, int Defense)
        {
            m_HitPoints = HitPoints;
            m_Attack = Attack;
            m_Defense = Defense;
            m_petName = Pokemon;
        }

       


        public void attack(petfight OtherPet)
        {
            OtherPet.receiveattack(m_Attack); 
        }
            

        public void receiveattack(int AttackValue)
        {
            if (AttackValue > m_Defense)
            {
                m_HitPoints -= AttackValue - m_Defense;
            }

        }
        
        public void Potion(int HitPointsValue)
        {
            m_HitPoints += 30;
            if (m_HitPoints >= 100)
            {
                m_HitPoints = 100;
            }
        }





    }
    }
}
