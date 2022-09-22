using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rover_Kata
{
    /// <summary>
    /// The class represent a Rover. A Rover can bring tools and objects with weight not excessive to the max weight allowed.
    /// </summary>
    public class Rover
    {
        private string name;
        private int max_weight_allowed;
        List<Tools> tools;
        List<Objects> objects;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the rover</param>
        public Rover(string name, int maxWeightAllowed)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// The name of the rover
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value;}
        }

        /// <summary>
        /// The tools of the rover
        /// </summary>
        public List<Tools> Tools
        {
            get => this.tools;
            set => this.tools = value;
        }
        /// <summary>
        /// The objects of the rover
        /// </summary>
        public List<Objects> Objects
        {
            get => this.objects;
            set => this.objects = value;
        }

        /// <summary>
        /// The maximum weight allowed to be carried
        /// </summary>
        private int MaxWeightAllowed
        {
            get => this.max_weight_allowed;
            set => this.max_weight_allowed = value;
        }

        /// <summary>
        /// Add a tool to the rover
        /// </summary>
        /// <param name="tools">The tool to add</param>
        public void addTool(Mars_Rover_Kata.Tools tool)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Remove a tool from the rover
        /// </summary>
        /// <param name="tool">The tool to remove</param>
        public void removeTool(Mars_Rover_Kata.Tools tool)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Add an object to the rover
        /// </summary>
        /// <param name="objects">The object to collect</param>
        public void addObject(Mars_Rover_Kata.Objects objects)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Remove an object from the rover
        /// </summary>
        public void removeObject(Objects objects)
        {
            throw new System.NotImplementedException();
        }
    }
}