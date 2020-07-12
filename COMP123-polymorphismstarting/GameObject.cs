using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_polymorphismstarting
{
    class GameObject
    {
        // PRIVTE INSTANCE MEMBERS
        private  string m_name;
        private float m_health;
        //PUBLIC PROPERTIES
        public Transform transform { get; set; }
        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }
        public  float Health
        {
            get
            {
                return m_health;
            }
            set
            {
                m_health = value;
            }
        }
        //CONSTRUCTOR(s)
        /// <summary>
        /// this constructors require a name  for the gameobject with optional health value
        /// by default all gameobject have ahealth value of 100.0;
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        public GameObject(string name,float health=100.0f)
        {
            Name = name;
            Health = health;
            m_initialize();
        }
        //PRIVATE METHODS
        private void  m_initialize()
        {
            transform = new Transform();
        }
        //PUBLIC METHODS
        public override string ToString()
        {
            string outputstring = "";
            outputstring += $"Name    :{Name}\n";
            outputstring += $"Health   :{Health}\n";
            outputstring += transform.ToString();
            return outputstring;
        }

    }
}
