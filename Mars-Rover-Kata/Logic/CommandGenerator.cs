using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Mars_Rover_Kata.Model;
using Mars_Rover_Kata.Model.Abstract;
using Mars_Rover_Kata.Model.Interface;

namespace Mars_Rover_Kata.Logic
{
    public class CommandGenerator
    {
        private string[] _arrayInstruction;
        private string _firstParameter;
        private string _command;
        private string _secondParameter;
        private string _instruction;
        private ICommand _icommand;

        /// <summary>
        /// Constructor
        /// </summary>
        public CommandGenerator() { }

        /// <summary>
        /// instance a command from the instruction
        /// </summary>
        /// <param name="instruction"></param>
        public bool Execute(MissionControl mc, Plateau p, string instruction)
        {
            //Console.WriteLine($"Command: {_instruction}");
            if (!CommandAnalyzer(mc, p, instruction)) return false;
            _icommand = (ICommand)GetInstance($"Mars_Rover_Kata.Command.{_command}");
            _icommand.Execute(mc, p, _arrayInstruction);
            return true;
        }

        /// <summary>
        /// Create a instance of the object
        /// </summary>
        /// <param name="strFullyQualifiedName"></param>
        /// <returns></returns>
        public object GetInstance(string strFullyQualifiedName)
        {
            Type type = Type.GetType(strFullyQualifiedName);
            if (type != null)
                return Activator.CreateInstance(type);
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = asm.GetType(strFullyQualifiedName);
                if (type != null)
                    return Activator.CreateInstance(type);
            }
            return null;
        }

        /// <summary>
        /// Split the instruction
        /// </summary>
        /// <param name="instruction"></param>
        /// <returns></returns>
        public bool CommandAnalyzer(MissionControl mc, Plateau p, string instruction)
        {
            bool result = false;
            _instruction = instruction;
            _arrayInstruction = instruction.Split(' ');

            //length
            if (_arrayInstruction.Length != 3) return result;
            //set parameters
            _firstParameter = instruction.Split(' ')[0];
            _command = instruction.Split(' ')[1];
            _secondParameter = instruction.Split(' ')[2];

            //first parameter should be a rover
            foreach (Rover r in mc.Rovers.Keys)
                if (r.Name == _firstParameter) result = true;

            //second parameter should be a command
            if (Command != "Move" && Command != "PickUp" && Command != "DropOff") result = false;

            //third parameter should be a object/tool/instruction of moviment

            return result;
        }

        /// <summary>
        /// First parameter 
        /// </summary>
        public string FirstParameter
        { get { return _firstParameter; } }
        /// <summary>
        /// Command
        /// </summary>
        public string Command
        { get { return _command; } }
        /// <summary>
        /// Second paramenter
        /// </summary>
        public string SecondParameter
        { get { return _secondParameter; } }
    }
}
