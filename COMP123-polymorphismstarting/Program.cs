using System;

namespace COMP123_polymorphismstarting
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy greenEnemy = new Enemy("green enemy");
            Enemy redEnemy = new Enemy("Red Enemy");
            BossEnemy bossEnemy = new BossEnemy();
            //GameObject player = new GameObject("Player");
            // player.transform.position = new Vector2D();
           //it will work beause the player is extended  from gameobject
            player.RaiseSheilds();
            player.transform.position = new Vector2D(100.0f,100.0f);
            Console.WriteLine(player.ToString());
            greenEnemy.FireBullent();
            greenEnemy.transform.position = new Vector2D(60.0f, 80.0f);
            Console.WriteLine(greenEnemy.ToString());
            redEnemy.FireBullent();
            redEnemy.transform.position = new Vector2D();
            Console.WriteLine(redEnemy.ToString());
           bossEnemy.FireBullet();
            bossEnemy.transform.position = new Vector2D(200.0f, 200.0f);
            
            Console.ReadLine();
        }
    }
}
