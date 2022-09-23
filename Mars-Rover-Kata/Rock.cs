using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rover_Kata
{
    /// <summary>
    /// A Rock is an object that is possible find on the Plateau
    /// </summary>
    public class Rock : Objects
    {
        /// <param name="name">The name</param>
        /// <param name="weight">The weight</param>
        public Rock(string name, int weight) : base (name, weight)
        {
            
        }
    }
}