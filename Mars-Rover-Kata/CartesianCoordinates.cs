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
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// x coordinate
        /// </summary>
        public int x
        {
            get => this.x;
            set => this.x = value;
        }

        /// <summary>
        /// y coordinate
        /// </summary>
        public int y
        {
            get => this.y;
            set => this.y = value;
        }

        /// <summary>
        /// Compare two coordinates. return true if the coordinates are equal
        /// </summary>
        public bool compareCoordinates(ICoordinates coordinate)
        {
            CartesianCoordinates cc = (CartesianCoordinates)coordinate;
            return cc.x == this.x && cc.y == this.y;
        }
    }
}