using FluentAssertions;
using Mars_Rover_Kata;
namespace Mars_Rover_Kata_Test
{
    public class RettangulaPlateauTests
    {
        RettangularPlateau p;
        Rover r1;
        Rover r2;
        Objects rock1;
        Objects rock2;
        Tools robotArm;
        Tools camera;

        [SetUp]
        public void Setup()
        {
            p = new RettangularPlateau(new CartesianCoordinates(10,10));
            r1 = new Rover("R01", 10);
            r2 = new Rover("R02", 8);
            rock1 = new Rock("Quarzo", 5);
            rock2 = new Rock("Green Rock", 2);
            robotArm = new RobotArm("RA1", 2);
            camera = new Camera("CA1", 1);
            p.addRover(r1, new Position(new CartesianCoordinates(4, 5), "N"));
            p.addRover(r2, new Position(new CartesianCoordinates(0, 5), "E"));
            p.addObject(rock1, new CartesianCoordinates(7, 2));
            p.addObject(rock2, new CartesianCoordinates(2, 7));
            p.addTool(robotArm, new CartesianCoordinates(6, 3));
            p.addTool(camera, new CartesianCoordinates(9, 1));
        }
        
        [Test]
        public void RettangularPlateau()
        {
            p.Objects.Should().NotBeNull();
            p.Rovers.Should().NotBeNull();
            p.Tools.Should().NotBeNull();
            p.Size.X.Should().Be(10);
            p.Size.Y.Should().Be(10);
        }

        [Test]
        public void RoversTest()
        {
            p.Rovers.Count.Should().Be(2);
            p.Rovers.ContainsKey(r1).Should().BeTrue();
            p.Rovers.ContainsKey(r2).Should().BeTrue();
        }

        [Test]
        public void ToolsTest()
        {
            p.Tools.Count.Should().Be(2);
            p.Tools.ContainsKey(robotArm).Should().BeTrue();
            p.Tools.ContainsKey(camera).Should().BeTrue();
        }

        [Test]
        public void ObjectsTest()
        {
            p.Objects.Count.Should().Be(2);
            p.Objects.ContainsKey(rock1).Should().BeTrue();
            p.Objects.ContainsKey(rock2).Should().BeTrue();
        }
    }
}