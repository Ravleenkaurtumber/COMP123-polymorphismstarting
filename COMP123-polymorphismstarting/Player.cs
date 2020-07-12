using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_polymorphismstarting
{
    class Player:GameObject
    {
        //PRIVATE INSTANCE VARIABLES
        //PUBLIC PROPERTIES
        //CONSTRUCTOR
        public Player()
           : base("Player")
        {

        }
        //PRIVATE METHODS
        //PUBLIC METHODS
        public void RaiseSheilds()
        {
            Console.WriteLine("Raising Shields");
        }
    }
}
