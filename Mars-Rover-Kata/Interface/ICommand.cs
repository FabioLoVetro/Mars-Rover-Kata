using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rover_Kata.Interface
{
    /// <summary>
    /// Interface Command
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Execute the command
        /// </summary>
        /// <param name="instruction">The instruction to execute</param>
        public void execute(string instruction);
        /// <summary>
        /// Validate the instruction to execute
        /// </summary>
        public bool commandValidator(string instruction);
    }
}