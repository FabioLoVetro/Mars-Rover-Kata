using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Mars_Rover_Kata.Model.Abstract;

namespace Mars_Rover_Kata.Model
{
    /// <summary>
    /// A robot arm allow to pick up or leave object from the rover
    /// </summary>
    public class RobotArm : Tools
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_weight"></param>
        public RobotArm(string _name, int _weight) : base(_name, _weight)
        {
        }
    }
}