using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mars_Rover_Kata
{
    /// <summary>
    /// A Plateau rapresent a surface of Mars. A Plateau contains Rovers, Tools and Objects
    /// </summary>
    public abstract class Plateau
    {
        private Dictionary<Rover, Position> _rovers;
        private Dictionary<Tools, ICoordinates> _tools;
        private Dictionary<Objects, ICoordinates> _objects;

        /// <summary>
        /// Constructor
        /// </summary>
        public Plateau()
        {
            this._rovers = new Dictionary<Rover, Position>();
            this._tools = new Dictionary<Tools, ICoordinates>();
            this._objects = new Dictionary<Objects, ICoordinates>();
        }
        
        /// <summary>
        /// List of Rovers situated in the Plateau
        /// </summary>
        public Dictionary<Mars_Rover_Kata.Rover, Position> Rovers
        {
            get => this._rovers;
            set => this._rovers = value;
        }

        /// <summary>
        /// List of objects situated in the Plateau
        /// </summary>
        public Dictionary<Mars_Rover_Kata.Objects, Mars_Rover_Kata.ICoordinates> Objects
        {
            get => this._objects;
            set => this._objects = value;
        }

        /// <summary>
        /// List of Tools situated in the Plateau
        /// </summary>
        public Dictionary<Tools, ICoordinates> Tools
        {
            get => this._tools;
            set => this._tools = value;
        }

        /// <summary>
        /// Add an object to the Plateau at the given coordinates
        /// </summary>
        public void addObject(Objects objects, ICoordinates coordinates)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Remove an object to the Plateau at the given coordinates
        /// </summary>
        /// <param name="objects">The object to remove from the Plateau</param>
        /// <param name="coordinates">The coordates of the obect to remove</param>
        public void removeObject(Objects objects, ICoordinates coordinates)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Add a Rover to the Plateau at the given coordinates
        /// </summary>
        /// <param name="rover">The rover to add to the Plateau</param>
        /// <param name="coordinates">The coordinates for the rover to add</param>
        public void addRover(Rover rover, ICoordinates coordinates)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Remove a Rover to the Plateau at the given coordinates
        /// </summary>
        /// <param name="rover">The rover to remove from the Plateau</param>
        /// <param name="coordinates">The coordinates for the rover to remove</param>
        public void removeRover(Rover rover, ICoordinates coordinates)
        {
            throw new System.NotImplementedException();
        }

        /// <param name="tool">The tool to add</param>
        /// <param name="coordinates">The coordinates of the tool</param>
        public void addTool(Tools tool, ICoordinates coordinates)
        {
            throw new System.NotImplementedException();
        }

        /// <param name="tool">The tool to remove</param>
        /// <param name="coordinates">The coordinates of the tool</param>
        public void removeTool(string tool, string coordinates)
        {
            throw new System.NotImplementedException();
        }
    }
}
