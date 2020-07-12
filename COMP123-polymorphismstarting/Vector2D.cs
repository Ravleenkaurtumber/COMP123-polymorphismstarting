using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace COMP123_polymorphismstarting
{
    class  Vector2D
    {
        //public instance variables
        public float x;
        public float y;
        //constructor
        /// <summary>
        /// this constructor takes  x and y as optional parameter
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Vector2D(float x = 0.0f, float y = 0.0f)
        {
            this.x = x;
            this.y = y;
        }
            //PUBLIC OPERATOR OVERLOADS
             public static Vector2D operator +(Vector2D lhs ,Vector2D rhs)
        {
            float Xs = lhs.x + rhs.x;
            float Ys = lhs.y + rhs.y;
            return new Vector2D(Xs, Ys);

        }
        public static Vector2D operator -(Vector2D lhs, Vector2D rhs)
        {
            float Xs = lhs.x - rhs.x;
            float Ys = lhs.y - rhs.y;
            return new Vector2D(Xs, Ys);

        }
        public static Vector2D operator *(Vector2D lhs, Vector2D rhs)
        {
            float Xs = lhs.x * rhs.x;
            float Ys = lhs.y * rhs.y;
            return new Vector2D(Xs, Ys);

        }
        public static Vector2D operator *(Vector2D lhs, float rhs)
        {
            float Xs = lhs.x * rhs;
            float Ys = lhs.y * rhs;
            return new Vector2D(Xs, Ys);

        }
        public static Vector2D operator /(Vector2D lhs, Vector2D rhs)
        {
            float Xs = lhs.x / rhs.x;
            float Ys = lhs.y / rhs.y;
            return new Vector2D(Xs, Ys);

        }


        //public methods
        /// <summary>
        /// this method return the value of x and y component with the  format(x,y) as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputstring = $"({x},{y})";
            return outputstring;
        }
        //PUBLIC STATIC METHODS//NO NEED TO INITANIZZ
        public static Vector2D Zero()
        {
            return new Vector2D(0.0f, 0.0f);
        }
        public static Vector2D Up()
        {
            return new Vector2D(0.0f, 1.0f);
        }
        public static Vector2D Down()
        {
            return new Vector2D(0.0f, -1.0f);
        }
        public static Vector2D Right()
        {
            return new Vector2D(1.0f, 0.0f);
        }
        public static Vector2D Left()
        {
            return new Vector2D(-1.0f, 0.0f);
        }











    }
}
