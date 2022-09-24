using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_Rover_Kata.Model.Abstract;
using Mars_Rover_Kata.Model.Interface;

namespace Mars_Rover_Kata.Model.Abstract
{
    /// <summary>
    /// A Plateau rapresent a surface of Mars. A Plateau contains Rovers, Tools and Objects
    /// </summary>
    public abstract class Plateau
    {
        private Dictionary<Tools, ICoordinates> _tools;
        private Dictionary<Objects, ICoordinates> _objects;

        /// <summary>
        /// Constructor
        /// </summary>
        public Plateau()
        {
            this._tools = new Dictionary<Tools, ICoordinates>();
            this._objects = new Dictionary<Objects, ICoordinates>();
        }



        /// <summary>
        /// List of objects situated in the Plateau
        /// </summary>
        public Dictionary<Objects, ICoordinates> Objects
        {
            get { return this._objects; }
            set { this._objects = value; }
        }

        /// <summary>
        /// List of Tools situated in the Plateau
        /// </summary>
        public Dictionary<Tools, ICoordinates> Tools
        {
            get { return this._tools; }
            set { this._tools = value; }
        }

        /// <summary>
        /// Add an object to the Plateau at the given coordinates
        /// </summary>
        public void addObject(Objects objects, ICoordinates coordinates)
        {
            this.Objects.Add(objects, coordinates);
        }

        /// <summary>
        /// Remove an object to the Plateau at the given coordinates
        /// </summary>
        /// <param name="objects">The object to remove from the Plateau</param>
        /// <param name="coordinates">The coordates of the obect to remove</param>
        public void removeObject(Objects objects)
        {
            this.Objects.Remove(objects);
        }

        /// <param name="tool">The tool to add</param>
        /// <param name="coordinates">The coordinates of the tool</param>
        public void addTool(Tools tool, ICoordinates coordinates)
        {
            this.Tools.Add(tool, coordinates);
        }

        /// <param name="tool">The tool to remove</param>
        /// <param name="coordinates">The coordinates of the tool</param>
        public void removeTool(Tools tool)
        {
            this.Tools.Remove(tool);
        }
        /// <summary>
        /// Return a description of the plateau
        /// </summary>
        /// <returns></returns>
        override
        public string ToString()
        {
            string tools = "";
            string objects = "";

            foreach (Tools t in this.Tools.Keys)
            {
                tools += $"{t.ToString()}, {this.Tools[t].ToString()}\n";
            }
            foreach (Objects o in this.Objects.Keys)
            {
                objects += $"{o.ToString()}, {this.Objects[o].ToString()}\n";
            }
            return $"Plateau:\n{tools}\n{objects}";
        }
    }
}
