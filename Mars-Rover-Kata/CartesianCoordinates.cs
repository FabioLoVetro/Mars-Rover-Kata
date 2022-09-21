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
        private int x;
        private int y;

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
        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        /// <summary>
        /// y coordinate
        /// </summary>
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        /// <summary>
        /// Add the value to the x axe of the coordinate
        /// </summary>
        public void AddToX(int value)
        {
            this.x += value;
        }
        /// <summary>
        /// Add the value to the y axe of the coordinate
        /// </summary>
        public void AddToY(int value)
        {
            this.y += value;
        }

        /// <summary>
        /// Compare two coordinates. return true if the coordinates are equal
        /// </summary>
        public bool CompareCoordinates(ICoordinates coordinate)
        {
            CartesianCoordinates cc = (CartesianCoordinates)coordinate;
            return cc.x == this.x && cc.y == this.y;
        }

        /// <summary>
        /// Return a description of the coordates as a string
        /// </summary>
        override
        public string ToString()
        {
            return $"[{this.x},{this.y}]";
        }
    }
}