using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rover_Kata
{
    /// <summary>
    /// A special camera allow to make photo with different filters.
    /// </summary>
    public class Camera : Tools
    {
        /// <param name="name">The name</param>
        /// <param name="weight">The weight</param>
        public Camera(string name, int weight): base (name, weight)
        {
        }

        /// <summary>
        /// A filter for the camera
        /// </summary>
        public string filter
        {
            get => default;
            set
            {
            }
        }
    }
}