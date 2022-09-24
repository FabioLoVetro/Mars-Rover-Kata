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
            this.Plateau = new RettangularPlateau(new CartesianCoordinates(10, 10));
            this.CommandGenerator = new CommandGenerator();
            this.MissionControl = new MissionControl();
            Rover r1 = new Rover("R01", 10);
            Rover r2 = new Rover("R02", 8);
            Objects rock1 = new Rock("Quarzo", 5);
            Objects rock2 = new Rock("Green Rock", 2);
            Tools robotArm = new RobotArm("Robot Arm 01", 2);
            Tools camera = new Camera("Camera 01", 1);
            this.MissionControl.addRover(r1, new Position(new CartesianCoordinates(4, 5), "N"));
            this.MissionControl.addRover(r2, new Position(new CartesianCoordinates(0, 5), "E"));
            this.Plateau.addObject(rock1, new CartesianCoordinates(7, 2));
            this.Plateau.addObject(rock2, new CartesianCoordinates(2, 7));
            this.Plateau.addTool(robotArm, new CartesianCoordinates(6, 3));
            this.Plateau.addTool(camera, new CartesianCoordinates(9, 1));
            this.Start();
        }

        /// <summary>
        /// Mission control
        /// </summary>

        public MissionControl MissionControl
        {
            get { return this._missionControl; }
            set { this._missionControl = value; }
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
            Console.WriteLine("Welcome on Mars\n");
            Console.WriteLine("Have a look at the situation\n");
            while (!end)
            {
                Console.WriteLine(this.MissionControl.ToString());
                Console.WriteLine(this.Plateau.ToString());
                Console.WriteLine("Type a command like [R01 Move LMLMMRM]");
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