using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mars_Rover_Kata.Model.Abstract;

namespace Mars_Rover_Kata.Model
{
    /// <summary>
    /// The class represent a Rover. A Rover can bring tools and objects with weight not excessive to the max weight allowed.
    /// </summary>
    public class Rover
    {
        private string name;
        private int max_weight_allowed;
        LinkedList<Tools> tools;
        LinkedList<Objects> objects;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the rover</param>
        public Rover(string name, int maxWeightAllowed)
        {
            this.name = name;
            this.max_weight_allowed = maxWeightAllowed;
            this.tools = new LinkedList<Tools>();
            this.objects = new LinkedList<Objects>();
        }

        /// <summary>
        /// The name of the rover
        /// </summary>
        public string Name
        {
            get { return this.name; }
            private set { this.name = value;}
        }

        /// <summary>
        /// The tools of the rover
        /// </summary>
        public LinkedList<Tools> Tools
        {
            get => this.tools;
            private set => this.tools = value;
        }
        /// <summary>
        /// The objects of the rover
        /// </summary>
        public LinkedList<Objects> Objects
        {
            get => this.objects;
            private set => this.objects = value;
        }

        /// <summary>
        /// The maximum weight allowed to be carried
        /// </summary>
        public int MaxWeightAllowed
        {
            get => this.max_weight_allowed;
            private set => this.max_weight_allowed = value;
        }

        /// <summary>
        /// Add a tool to the rover
        /// </summary>
        /// <param name="tools">The tool to add</param>
        public bool addTool(Tools tool)
        {
            bool added = false;
            int weight = 0;
            foreach(Tools t in this.Tools)
                weight += t.Weight;
            foreach (Objects o in this.Objects)
                weight += o.Weight;
            if (tool.Weight <= (this.MaxWeightAllowed - weight))
            {
                this.Tools.AddLast(tool);
                added = true;
            }
            return added;
        }

        /// <summary>
        /// Remove a tool from the rover
        /// </summary>
        /// <param name="tool">The tool to remove</param>
        public void removeTool(Tools tool)
        {
            this.Tools.Remove(tool);
        }

        /// <summary>
        /// Add an object to the rover
        /// </summary>
        /// <param name="objects">The object to collect</param>
        public bool addObject(Objects objects)
        {
            bool added = false;
            int weight = 0;
            foreach (Objects o in this.Objects)
                weight += o.Weight;
            foreach (Tools t in this.Tools)
                weight += t.Weight;
            if (objects.Weight <= (this.MaxWeightAllowed - weight))
            {
                this.objects.AddLast(objects);
                added = true;
            }
            return added;
        }

        /// <summary>
        /// Remove an object from the rover
        /// </summary>
        public void removeObject(Objects objects)
        {
            this.objects.Remove(objects);
        }
        /// <summary>
        /// Return a description of the rover
        /// </summary>
        /// <returns></returns>
        override
        public string ToString()
        {
            string tools = "";
            string objects = "";
            foreach (Tools t in this.tools)
                tools += $"{t.ToString} ";
            foreach (Objects o in this.objects)
                objects += $"{o.ToString} ";
            return $"Rover:[Name:{this.Name}, Max Weight:{this.MaxWeightAllowed}, Tools:{tools}, Objects:{objects}]";
        }
    }
}