using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Mars_Rover_Kata.Logic;
using Mars_Rover_Kata.Model;
using Mars_Rover_Kata.Model.Interface;
using Mars_Rover_Kata.Model.Abstract;

namespace Mars_Rover_Kata.Command
{
    /// <summary>
    /// Command Move
    /// </summary>
    public class Move : ICommand
    {
        public void Execute(MissionControl mc, Plateau p, string[] instruction)
        {
            foreach (Rover r in mc.Rovers.Keys)
            {
                if (r.Name == instruction[0])
                {
                    mc.Rovers[r].ComputeNewPosition(instruction[2]);
                }
            }
        }
    }
}