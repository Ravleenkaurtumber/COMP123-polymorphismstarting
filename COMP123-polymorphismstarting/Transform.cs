using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace COMP123_polymorphismstarting
{
    class Transform
    {
        // PUBLIC INSTANCE VARIABLES
        public Vector2D position;
        public Vector2D rotation;
        public Vector2D scale;
        //CONTRUCTOR
        public Transform()
        {
            m_initialize();
        }
        //PRIVATE METHODS
        private void m_initialize()
        {
            position = new Vector2D();
            rotation = new Vector2D();
            scale = new Vector2D();
        }
        /// <summary>
        /// this methods format the transform to show each of its components(position,rotation and scale)in a string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputstring = "";
            outputstring+=$"Position:"+position.ToString()+"\n";
            outputstring+= $"Rotation:" + rotation.ToString() + "\n";
            outputstring += $"Scale   :" + scale.ToString() + "\n";

            return outputstring;
        }


    }
}
