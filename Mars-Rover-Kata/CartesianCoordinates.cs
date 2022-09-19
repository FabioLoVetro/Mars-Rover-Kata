using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rover_Kata
{
    /// <summary>
    /// Cartesian Coordinates
    /// </summary>
    public class CartesianCoordinates : ICoordinates
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        public CartesianCoordinates(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// x coordinate
        /// </summary>
        public int x
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// y coordinate
        /// </summary>
        public int y
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Compare two coordinates. return true if the coordinates are equal
        /// </summary>
        public bool compareCoordinates(ICoordinates coordinate)
        {
            throw new NotImplementedException();
        }
    }
}