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
    /// Command Pick Up
    /// </summary>
    public class PickUp : ICommand
    {
        /// <summary>
        /// Pick up a tool or an Object from the plateau
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
                    foreach (Objects o in p.Objects.Keys)
                    {
                        if (o.Name == instruction[2])
                        {
                            r.addObject(o);
                            obj = o;
                        }
                    }
                    foreach (Tools t in p.Tools.Keys)
                    {
                        if (t.Name == instruction[2])
                        {
                            r.addTool(t);
                            tl = t;
                        }
                    }
                    if(obj != null) p.removeObject(obj);
                    if(tl != null) p.removeTool(tl);
                }
            }
        }
    }
}