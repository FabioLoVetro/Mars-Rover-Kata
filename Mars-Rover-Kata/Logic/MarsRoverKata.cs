using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Mars_Rover_Kata.Model;
using Mars_Rover_Kata.Model.Abstract;
using Mars_Rover_Kata.Model.Interface;

namespace Mars_Rover_Kata.Logic
{
    /// <summary>
    /// Instantiate and initialize the program.
    /// Manage the logic.
    /// </summary>
    public class MarsRoverKata
    {
        private Plateau _plateau;
        private CommandGenerator _commandGenerator;
        private MissionControl _missionControl;

        /// <summary>
        /// Constructor
        /// </summary>
        public MarsRoverKata()
        {
            this.CommandGenerator = new CommandGenerator();
            this.MissionControl = new MissionControl();
            Rover r1 = new Rover("R01", 10);
            Rover r2 = new Rover("R02", 8);
            Objects rock1 = new Rock("Quarzo", 5);
            Objects rock2 = new Rock("GreenRock", 2);
            Tools robotArm = new RobotArm("RobotArm", 2);
            Tools camera = new Camera("Camera", 1);
            this.MissionControl.addRover(r1, new Position(new CartesianCoordinates(0, 0), "N"));
            this.MissionControl.addRover(r2, new Position(new CartesianCoordinates(0, 0), "E"));
            r1.addObject(rock1);
            r2.addObject(rock2);
            r1.addTool(robotArm);
            r2.addTool(camera);
            this.Start();
        }

        /// <summary>
        /// Mission control
        /// </summary>

        public MissionControl MissionControl
        {
            get { return this._missionControl; }
            private set { this._missionControl = value; }
        }


        /// <summary>
        /// The Plateau
        /// </summary>
        public Plateau Plateau
        {
            get { return this._plateau; }
            private set { this._plateau = value; }
        }
        /// <summary>
        /// CommandGenerator
        /// </summary>
        public CommandGenerator CommandGenerator
        {
            get { return this._commandGenerator; }
            private set { this._commandGenerator = value; }
        }

        /// <summary>
        /// Initialize the program
        /// </summary>
        public void Start()
        {
            bool end = false;
            string input;
            Console.WriteLine("Type the size of the Plateau [Example 10 10]\n");
            string size = Console.ReadLine();
            this.Plateau = new RettangularPlateau(new CartesianCoordinates(int.Parse(size.Split(' ')[0]), int.Parse(size.Split(' ')[1])));
            Console.WriteLine("\nWelcome on Mars\n");
            Console.WriteLine("Have a look at the situation\n");
            while (!end)
            {
                Console.WriteLine(this.MissionControl.ToString());
                Console.WriteLine(this.Plateau.ToString());
                Console.WriteLine("Type an instruction:");
                input = Console.ReadLine();
                Console.WriteLine();
                if (input == "end")
                {
                    end = true;
                }
                else
                {
                    if (!CommandGenerator.Execute(this.MissionControl, this.Plateau,input))
                    {
                        Console.WriteLine("Error: Instruction not valid\nTry again!\n");
                    }
                }
            }
        }
    }
}