using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mars_Rover_Kata.Model.Interface;

namespace Mars_Rover_Kata.Model
{
    /// <summary>
    /// A Position represents the position of the Rover on the Plateau. A Position is composed with a coordinate and an orientation.
    /// </summary>
    public class Position
    {
        private ICoordinates coordinate;
        private string orientation;

        /// <param name="coordinates">The coordinates of the position</param>
        /// <param name="orientation">The orientation of the position</param>
        public Position(ICoordinates coordinates, string orientation)
        {
            this.coordinate = coordinates;
            this.orientation = orientation;
        }

        /// <summary>
        /// The coordinates of the position
        /// </summary>
        public ICoordinates Coordinate
        {
            get => this.coordinate;
            set => this.coordinate = value;
        }

        /// <summary>
        /// The orientation of the position
        /// </summary>
        public string Orientation
        {
            get => this.orientation;
            set => this.orientation = value;
        }

        /// <summary>
        /// Compute a new position after istruction of movement
        /// </summary>
        /// <param name="instruction">The instruction of movement</param>
        public void ComputeNewPosition(string instruction)
        {
            string newOrientation = this.Orientation;
            foreach (char s in instruction.ToUpper())
            {
                if (this.orientation == "N" && s == 'L') newOrientation = "O";
                if (this.orientation == "N" && s == 'R') newOrientation = "E";
                if (this.orientation == "E" && s == 'L') newOrientation = "N";
                if (this.orientation == "E" && s == 'R') newOrientation = "S";
                if (this.orientation == "S" && s == 'L') newOrientation = "E";
                if (this.orientation == "S" && s == 'R') newOrientation = "O";
                if (this.orientation == "O" && s == 'L') newOrientation = "S";
                if (this.orientation == "O" && s == 'R') newOrientation = "N";
                this.orientation = newOrientation;
                if (this.orientation == "N" && s == 'M') this.coordinate.AddToY(+1);
                if (this.orientation == "E" && s == 'M') this.coordinate.AddToX(+1);
                if (this.orientation == "S" && s == 'M') this.coordinate.AddToY(-1);
                if (this.orientation == "O" && s == 'M') this.coordinate.AddToX(-1);
            }
        }

        override
        public string ToString()
        {
            return $"Position:[{this.coordinate.ToString()}, Orientation:[{this.Orientation}]]";
        }
    }
}