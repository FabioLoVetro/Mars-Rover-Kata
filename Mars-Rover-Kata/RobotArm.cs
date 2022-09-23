using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rover_Kata
{
    /// <summary>
    /// A robot arm allow to pick up or leave object from the rover
    /// </summary>
    public class RobotArm : Tools
    {
        private string name;
        private int weight;

        /// <param name="name">The name</param>
        /// <param name="weight">The weight</param>
        public RobotArm(string name, int weight): base (name, weight)
        {
        }
    }
}