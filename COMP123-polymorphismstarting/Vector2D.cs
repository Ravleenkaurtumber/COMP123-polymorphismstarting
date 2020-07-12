using System;
using System.Collections.Generic;
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
        public Vector2D(float x=0.0f,float y=0.0f)
        {
            this.x = x;
            this.y = y;
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
    }
}
