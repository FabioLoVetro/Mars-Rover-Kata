using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rover_Kata.Model.Abstract
{
    /// <summary>
    /// The class rappresent objects that is possible find on the Plateau
    /// </summary>
    public abstract class Objects
    {
        private string name;
        private int weight;

        /// <param name="name">The name of the object</param>
        /// <param name="weight">The weight of the object</param>
        public Objects(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        /// <summary>
        /// The name of the object
        /// </summary>
        public string Name
        {
            get => name;
            set => name = value;
        }

        /// <summary>
        /// The weight of the object
        /// </summary>
        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        override
        public string ToString()
        {
            return $"Object:[Name:{Name}, Weight:{Weight}]";
        }
    }
}