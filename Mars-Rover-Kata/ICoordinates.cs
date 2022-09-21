using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rover_Kata
{
    /// <summary>
    /// Interface Coordinates
    /// </summary>
    public interface ICoordinates
    {
        /// <summary>
        /// Compare two coordinates. Return true if the coordinates are equal
        /// </summary>
        /// <param name="coordinate">The coordinate to compare</param>
        public bool CompareCoordinates(ICoordinates coordinate);
        /// <summary>
        /// Add the value to the x axe of the coordinate
        /// </summary>
        public void AddToX(int value);
        /// <summary>
        /// Add the value to the y axe of the coordinate
        /// </summary>
        public void AddToY(int value);
        /// <summary>
        /// Return a description of the coordates as a string
        /// </summary>
        public string ToString();
    }
}