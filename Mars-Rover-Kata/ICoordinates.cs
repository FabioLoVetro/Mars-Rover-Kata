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
        public bool compareCoordinates(ICoordinates coordinate);
        /// <summary>
        /// Add the value to the x axe of the coordinate
        /// </summary>
        public int addToX(int value);
        /// <summary>
        /// Add the value to the y axe of the coordinate
        /// </summary>
        public int addToY(int value);
    }
}