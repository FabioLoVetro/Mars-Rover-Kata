using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_Rover_Kata.Model;

namespace Mars_Rover_Kata.Logic
{
    public class MissionControl
    {
        private Dictionary<Rover, Position> _rovers;

        /// <summary>
        /// Constructon
        /// </summary>
        public MissionControl() {
            this._rovers = new Dictionary<Rover, Position>();
        }

        /// <summary>
        /// List of Rovers situated in the Plateau
        /// </summary>
        public Dictionary<Rover, Position> Rovers
        {
            get { return this._rovers; }
            set { this._rovers = value; }
        }

        /// <summary>
        /// Add a Rover to the Plateau at the given coordinates
        /// </summary>
        /// <param name="rover">The rover to add to the Plateau</param>
        /// <param name="coordinates">The coordinates for the rover to add</param>
        public void addRover(Rover rover, Position position)
        {
            this.Rovers.Add(rover, position);
        }

        /// <summary>
        /// Remove a Rover to the Plateau at the given coordinates
        /// </summary>
        /// <param name="rover">The rover to remove from the Plateau</param>
        /// <param name="coordinates">The coordinates for the rover to remove</param>
        public void removeRover(Rover rover)
        {
            this.Rovers.Remove(rover);
        }

        /// <summary>
        /// Return a description of the Mission control
        /// </summary>
        /// <returns></returns>
        override
        public string ToString()
        {
            string rovers = "";
            foreach (Rover r in this.Rovers.Keys)
            {
                rovers += $"{r.ToString()}, {this.Rovers[r].ToString()}\n";
            }
            return rovers;
        }
    }
}
