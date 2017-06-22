using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD47Gabriel_Can_Vidal_Programming1_a3
{
    class petfight
    {
        public int m_Attack;
        public int m_Defense;
        public int m_HitPoints;
        public string m_petName;

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
                Console.WriteLine("Attack Success!");
                m_HitPoints -= AttackValue - m_Defense;

            
            }
            else
                    {
                Console.WriteLine("Attack Failed!");
            }

        }
        
        public void Potion()
        {
            m_HitPoints += 30;
            if (m_HitPoints >= 100)
            {
                Console.WriteLine("Wow you healed. Are you a coward?");
                m_HitPoints = 100;
            }
        }





    }
    }

