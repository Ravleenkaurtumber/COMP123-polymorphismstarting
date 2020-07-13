using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace COMP123_polymorphismstarting
{
    class Program
    {
        
            private static List<GameObject> gameObjects;
            static void Update()
            {
            foreach(GameObject gameObject in gameObjects)
            {
                gameObject.Update();
            }

            }
        static void Main(string[] args)
        {
            gameObjects = new List<GameObject>();
            float playerSpeed = 20.0f;//20 units
            Player player = new Player();
            gameObjects.Add(player);
            
            player.RaiseSheilds();
            player.transform.position = new Vector2D(100.0f,100.0f);
            Console.WriteLine(player.ToString());
            //static so no new keyword
            player.transform.position += Vector2D.Up()*playerSpeed;
            // player.transform.position+=Vector2D.Rught(); //if i have to do += will give me error so have to make thid happen
            Console.WriteLine(player.ToString());

            Enemy redEnemy = new Enemy("Red Enemy");
            redEnemy.transform.position = new Vector2D(225.0f, 200.0f);
            Console.WriteLine(redEnemy.ToString());
            gameObjects.Add(redEnemy);
            float distance = Vector2D.Distance(player.transform.position, redEnemy.transform.position);
            Console.WriteLine($"the distance between tha player and the red enemy is {distance}");

            player.Health-=redEnemy.FireBullet();
            Console.WriteLine(player.ToString());
            BossEnemy boss = new BossEnemy();
            boss.transform.position = Vector2D.Zero();
            Console.WriteLine(boss.ToString());
            gameObjects.Add(boss);
            float bossDistance = Vector2D.Distance(player.transform.position, boss.transform.position);
            Console.WriteLine($"the distance between tha player and the red enemy is {bossDistance}");
            player.Health -=boss.FireBullet();
            Console.WriteLine(player.ToString());
            Update();


            Console.ReadLine();
            
        }
    }
}
