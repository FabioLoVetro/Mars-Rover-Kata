using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mars_Rover_Kata.Logic;
using Mars_Rover_Kata.Model.Interface;
using Mars_Rover_Kata.Model.Abstract;

namespace Mars_Rover_Kata.Command
{
    /// <summary>
    /// Command Pick Up
    /// </summary>
    public class PickUp : ICommand
    {

        public void Execute(MissionControl mc, Plateau p, string[] instruction)
        {
            throw new NotImplementedException();
        }
    }
}