using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rover_Kata
{
    /// <summary>
    /// The class rappresent a tool for the rover
    /// </summary>
    public abstract class Tools
    {
        private string name;
        private int weight;

        /// <summary>
        /// The name of the tool
        /// </summary>
        private string Name
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// The weight of the tool
        /// </summary>
        public int Weight
        {
            get => default;
            set
            {
            }
        }
    }
}