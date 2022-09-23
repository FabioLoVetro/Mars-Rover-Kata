using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rover_Kata
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
            get => this.name;
            set => this.name = value;
        }

        /// <summary>
        /// The weight of the object
        /// </summary>
        public int Weight
        {
            get => this.weight;
            set => this.weight = value;
        }
    }
}