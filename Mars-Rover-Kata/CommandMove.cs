using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mars_Rover_Kata.Interface;

namespace Mars_Rover_Kata
{
    /// <summary>
    /// Command Move
    /// </summary>
    public class CommandMove : ICommand
    {
        public bool commandValidator(string instruction)
        {
            throw new NotImplementedException();
        }

        public void execute(string instruction)
        {
            throw new NotImplementedException();
        }
    }
}