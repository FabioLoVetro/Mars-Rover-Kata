using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mars_Rover_Kata.Model.Abstract;

namespace Mars_Rover_Kata.Model
{
    /// <summary>
    /// A special camera allow to make photo with different filters.
    /// </summary>
    public class Camera : Tools
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_weight"></param>
        public Camera(string _name, int _weight) : base(_name, _weight)
        {
        }

        /// <summary>
        /// A filter for the camera
        /// </summary>
        public string filter
        {
            get => this.filter;
            set => this.filter = value;
        }
    }
}