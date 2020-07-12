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
        public Transform Transform { get; set; }
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
        }
        //PRIVATE METHODS
        //PUBLIC METHODS

    }
}
