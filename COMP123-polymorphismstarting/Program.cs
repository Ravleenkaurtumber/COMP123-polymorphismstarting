using System;

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
            Console.ReadLine();
        }
    }
}
