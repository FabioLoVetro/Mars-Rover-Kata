using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rover_Kata
{
    /// <summary>
    /// A Position represents the position of the Rover on the Plateau. A Position is composed with a coordinate and an orientation.
    /// </summary>
    public class Position
    {
        /// <param name="coordinates">The coordinates of the position</param>
        /// <param name="orientation">The orientation of the position</param>
        public Position(ICoordinates coordinates, string orientation)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// The coordinates of the position
        /// </summary>
        public ICoordinates coordinate
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// The orientation of the position
        /// </summary>
        public string orientation
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Compute a new position after istruction of movement
        /// </summary>
        /// <param name="instruction">The instruction of movement</param>
        public void computeNewPosition(string instruction)
        {
            throw new System.NotImplementedException();
        }
    }
}