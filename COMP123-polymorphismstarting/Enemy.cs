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
        public virtual float FireBullet()
        {

            Console.WriteLine($"{Name} FiringBullet!");
            return 20.0f;
        }
        //must overridden(enemy derived directly from game object)
        public override void Update()
        {
            
        }
        public override void Start()
        {
            Console.WriteLine($"{GetType()}start method");
            Health = 50.0f;
        }
        
           
        
        public override void Reset()
        {
            
        }
    }
}
