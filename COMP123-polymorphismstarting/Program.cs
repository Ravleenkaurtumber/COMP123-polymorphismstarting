using System;
using System.Dynamic;

namespace COMP123_polymorphismstarting
{
    class Program
    {
        static void Main(string[] args)
        {
            float playerSpeed = 20.0f;//20 units
            Player player = new Player();
          
            
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
            float distance = Vector2D.Distance(player.transform.position, redEnemy.transform.position);
            Console.WriteLine($"the distance between tha player and the red enemy is {distance}");

            player.Health-=redEnemy.FireBullet();
            Console.WriteLine(player.ToString());
            BossEnemy boss = new BossEnemy();
            boss.transform.position = Vector2D.Zero();
            Console.WriteLine(boss.ToString());

            float bossDistance = Vector2D.Distance(player.transform.position, boss.transform.position);
            Console.WriteLine($"the distance between tha player and the red enemy is {bossDistance}");
            player.Health -=boss.FireBullet();
            Console.WriteLine(player.ToString());



            Console.ReadLine();
            
        }
    }
}
