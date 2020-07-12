using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_polymorphismstarting
{
    class GameObject
    {
        // PRIVTE INSTANCE MEMBERS
        private  string m_name;
        //PUBLIC PROPERTIES
        public Transform transform { get; set; }
        public string Name
        {
            get
            {
                return this.m_name;
            }
            set
            {
                this.m_name = value;
            }
        }
        //CONSTRUCTOR(s)
        public GameObject(string name)
        {
            this.Name = name;
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
            outputstring = $"Name    :{Name}\n";
            outputstring = transform.ToString();
            return outputstring;
        }

    }
}
