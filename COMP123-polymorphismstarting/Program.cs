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
            Vector2D vector1 = new Vector2D(0.0f, 3.0f);
            Vector2D vector2 = new Vector2D(4.0f, 0.0f);
            Console.WriteLine("value of vector1:"+vector1.ToString());
            Console.WriteLine("value of vector2:"+ vector2.ToString());
            float dot = Vector2D.Dot(vector1, vector2);//when static no new just say class
            Console.WriteLine( $"The dot product is:{dot}");
            float distance = Vector2D.Distance(vector1, vector2);
            Console.WriteLine($"the distance between vector1 and vector2 is{distance}");
            Console.ReadLine();
        }
    }
}
