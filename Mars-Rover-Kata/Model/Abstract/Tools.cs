using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rover_Kata.Model.Abstract
{
    /// <summary>
    /// The class rappresent a tool for the rover
    /// </summary>
    public abstract class Tools
    {
        private string _name;
        private int _weight;

        /// <param name="name">The name of the tool</param>
        /// <param name="weight">The weight of the tool</param>
        public Tools(string name, int weight)
        {
            this._name = name;
            this._weight = weight;
        }

        /// <summary>
        /// The name of the tool
        /// </summary>
        public string Name
        {
            get => this._name;
            private set => this._name = value;
        }

        /// <summary>
        /// The weight of the tool
        /// </summary>
        public int Weight
        {
            get => this._weight;
            private set => this._weight = value;
        }

        override
        public string ToString()
        {
            return $"Tool:[Name:{this.Name}, Weight:{this.Weight}]";
        }
    }
}