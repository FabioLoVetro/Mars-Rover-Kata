using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mars_Rover_Kata.Logic;
using Mars_Rover_Kata.Model.Interface;
using Mars_Rover_Kata.Model.Abstract;
using Mars_Rover_Kata.Model;

namespace Mars_Rover_Kata.Command
{
    /// <summary>
    /// Command DropOff
    /// </summary>
    public class DropOff : ICommand
    {
        /// <summary>
        /// Drop off a tool or an Object from the rover
        /// </summary>
        /// <param name="mc"></param>
        /// <param name="p"></param>
        /// <param name="instruction"></param>
        public void Execute(MissionControl mc, Plateau p, string[] instruction)
        {
            Tools tl = null;
            Objects obj = null;

            foreach (Rover r in mc.Rovers.Keys)
            {
                if (r.Name == instruction[0])
                {
                    foreach (Objects o in r.Objects)
                    {
                        if (o.Name == instruction[2])
                        {
                            p.addObject(o, new CartesianCoordinates(((CartesianCoordinates)mc.Rovers[r].Coordinate).X, ((CartesianCoordinates)mc.Rovers[r].Coordinate).Y));
                            obj = o;
                        }
                    }
                    foreach (Tools t in r.Tools)
                    {
                        if (t.Name == instruction[2])
                        {
                            p.addTool(t, new CartesianCoordinates(((CartesianCoordinates)mc.Rovers[r].Coordinate).X, ((CartesianCoordinates)mc.Rovers[r].Coordinate).Y));
                            tl = t;
                        }
                    }
                    if (obj != null) r.removeObject(obj);
                    if (tl != null) r.removeTool(tl);
                }
            }
        }
    }
}