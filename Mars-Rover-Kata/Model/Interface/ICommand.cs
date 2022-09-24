using Mars_Rover_Kata.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mars_Rover_Kata.Model.Abstract;

namespace Mars_Rover_Kata.Model.Interface
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
        public void Execute(MissionControl mc, Plateau p, string[] instruction);
    }
}