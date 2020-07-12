using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_polymorphismstarting
{
    class Enemy:GameObject
    {
        // PRIVATE INSTANCE VARIABLES
        //PUBLIC PROPERTIES
        //CONTRUCTOR
        public Enemy(string name)
            :base(name)
        {

        }
        //PRIVATE METHODS
        //PUBLIC METHODS
        public virtual void FireBullet()
        {
            Console.WriteLine("FiringBullet");
        }
    }
}
