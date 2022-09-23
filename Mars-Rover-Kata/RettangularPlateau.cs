using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rover_Kata
{
    /// <summary>
    /// A Rectangular Plateau is a rectangular shaped Plateau
    /// </summary>
    public class RettangularPlateau : Plateau
    {
        private CartesianCoordinates _size;

        /// <param name="size">The size of the Plateau</param>
        public RettangularPlateau(CartesianCoordinates size) : base()
        {
            this._size = size;
        }

        /// <summary>
        /// The size of the Plateau
        /// </summary>
        public CartesianCoordinates Size
        {
            get { return this._size; }
            set { this._size = value; }
        }
    }
}