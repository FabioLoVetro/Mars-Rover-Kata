using FluentAssertions;
using Mars_Rover_Kata.Command;
using Mars_Rover_Kata.Logic;
using Mars_Rover_Kata.Model;
using Mars_Rover_Kata.Model.Abstract;

namespace Mars_Rover_Kata_Test
{
    public class CommandGeneratorTests
    {
        CommandGenerator cg;
        MissionControl mc;
        Plateau p;
        string instruction;
        Rover r1;
        Rover r2;

        [SetUp]
        public void Setup()
        {
            cg = new CommandGenerator();
            mc = new MissionControl();
            p = new RettangularPlateau(new CartesianCoordinates(10, 10));
            instruction = "R01 Move LM";
            r1 = new Rover("R01", 10);
            r2 = new Rover("R02", 8);
            mc.addRover(r1, new Position(new CartesianCoordinates(4, 5), "N"));
            mc.addRover(r2, new Position(new CartesianCoordinates(0, 5), "E"));
        }

        [Test]
        public void CommandAnalyzerTest()
        {
            cg.CommandAnalyzer(mc, p, instruction).Should().BeTrue();
            cg.FirstParameter.Should().Be("R01");
            cg.Command.Should().Be("Move");
            cg.SecondParameter.Should().Be("LM");
        }

        [Test]
        public void CommandAnalyzer_instruction_R03_Move_LM()
        {
            cg.CommandAnalyzer(mc, p, "R03 Move LM").Should().BeFalse();
        }

        [Test]
        public void CommandAnalyzer_instruction_R01_Mo_LM()
        {
            cg.CommandAnalyzer(mc, p, "R01 Mo LM").Should().BeFalse();
        }
    }
}