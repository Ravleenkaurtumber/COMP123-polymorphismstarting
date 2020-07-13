using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace COMP123_polymorphismstarting
{
    class BossEnemy:Enemy
    {
        //PRIVATE INSTANCE VARIABLES
        //PUBLIC PROPERTIES

        //CONSTRUCTOR
        public BossEnemy()
            :base("Boss")
        {
            
        }
        //PUBLIC METHODS
        public override float FireBullet()
        {
            Console.WriteLine($"{Name}Firing FAT Bullet");
            return 40.0f;
        }
        //public overrides methods (may override)beacuse boss enemy derived indirectly from game object
        public override void Update()
        {

        }
        public override void Start()
        {
            Console.WriteLine($"{GetType()}start method");
            Health = 200.0f;
        }



        public override void Reset()
        {

        }
    }
}
