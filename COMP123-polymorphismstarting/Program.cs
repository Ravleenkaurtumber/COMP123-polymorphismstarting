using System;

namespace COMP123_polymorphismstarting
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject player = new GameObject("Player");
            // player.transform.position = new Vector2D();
            Console.WriteLine(player.ToString());

            Console.ReadLine();
        }
    }
}
