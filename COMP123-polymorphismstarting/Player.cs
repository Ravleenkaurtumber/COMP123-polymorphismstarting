using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_polymorphismstarting
{
    class Player:GameObject
    {
        //PRIVATE INSTANCE VARIABLES
        private bool m_shieldsRaised;
        private float m_shieldslevel;
        //PUBLIC PROPERTIES
        public bool ShieldsRaised {
            get
            {
                return m_shieldsRaised;
            }

            set 
            {
                m_shieldsRaised = value;
            }
        }
        public override float Health
        { 
            get
            {
                return m_health;
            }
            set
            {
                /* if (ShieldsRaised)
                 {
                     m_health = value - 10.0f;
                 }
                 else
                 {
                     m_health = value;
                 }*/
                //m_health = (ShieldsRaised) ? value + ShieldLevel : value;
                if(ShieldsRaised)
                {
                    m_health = value+ShieldLevel;
                    Console.WriteLine($"players shield absorbed {ShieldLevel}damage");
                }
                else
                {
                    m_health = value;
                }
            }   
        }
        public float ShieldLevel 
        {
            get
            {
                return m_shieldslevel;
            }
            set
            {
                m_shieldslevel = value;
            }
        }
        //CONSTRUCTOR
        public Player()
           : base("Player")
        {
            
        }
        //PRIVATE METHODS
       /* private void m_initialize()
        {
            m_shieldslevel = 10.0f;
        }*/
        //PUBLIC METHODS
        public void RaiseSheilds()
        {
            Console.WriteLine("Raising Shields");
            ShieldsRaised = true;
            
        }
        public void LowerSheilds()
        {
            Console.WriteLine("Lowering Shields");
            ShieldsRaised = false;

        }
        //public methods overridden
        public override void Update()
        {

        }
        public override void Start()
        {
            Console.WriteLine($"{GetType()}start method");
            m_shieldslevel = 10.0f;
        }
        public override void Reset()
        {
            
        }
    }
}
