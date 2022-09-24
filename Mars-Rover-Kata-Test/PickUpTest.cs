using FluentAssertions;
using Mars_Rover_Kata.Command;
using Mars_Rover_Kata.Logic;
using Mars_Rover_Kata.Model;
using Mars_Rover_Kata.Model.Abstract;

namespace Mars_Rover_Kata_Test
{
    public class PickUpTests
    {
        CommandGenerator cg;
        MissionControl mc;
        Plateau p;
        string[] instruction;
        Rover r1;
        Rover r2;
        Tools camera;
        PickUp pu;

        [SetUp]
        public void Setup()
        {
            cg = new CommandGenerator();
            mc = new MissionControl();
            p = new RettangularPlateau(new CartesianCoordinates(10, 10));
            instruction = "R01 PickUp Camera".Split(' ');
            r1 = new Rover("R01", 10);
            r2 = new Rover("R02", 8);
            camera = new Camera("Camera", 5);
            p.addTool(camera, new CartesianCoordinates(4, 5));
            mc.addRover(r1, new Position(new CartesianCoordinates(4, 5), "N"));
            mc.addRover(r2, new Position(new CartesianCoordinates(0, 5), "E"));
            pu = new PickUp();
        }

        [Test]
        public void ExecutePickUp()
        {
            r1.Tools.Should().HaveCount(0);
            r1.Tools.Contains(camera).Should().BeFalse();
            p.Tools.Should().HaveCount(1);
            p.Tools.ContainsKey(camera).Should().BeTrue();
            pu.Execute(mc,p,instruction);
            r1.Tools.Should().HaveCount(1);
            r1.Tools.Contains(camera).Should().BeTrue();
            p.Tools.Should().HaveCount(0);
            p.Tools.ContainsKey(camera).Should().BeFalse();
        }
    }
}