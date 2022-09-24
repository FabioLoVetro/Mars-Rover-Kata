using FluentAssertions;
using Mars_Rover_Kata.Model;
using Mars_Rover_Kata.Model.Abstract;

namespace Mars_Rover_Kata_Test
{
    public class RettangulaPlateauTests
    {
        RettangularPlateau p;
        Objects rock1;
        Objects rock2;
        Tools robotArm;
        Tools camera;

        [SetUp]
        public void Setup()
        {
            p = new RettangularPlateau(new CartesianCoordinates(10,10));
            rock1 = new Rock("Quarzo", 5);
            rock2 = new Rock("Green Rock", 2);
            robotArm = new RobotArm("RA1", 2);
            camera = new Camera("CA1", 1);
            p.addObject(rock1, new CartesianCoordinates(7, 2));
            p.addObject(rock2, new CartesianCoordinates(2, 7));
            p.addTool(robotArm, new CartesianCoordinates(6, 3));
            p.addTool(camera, new CartesianCoordinates(9, 1));
        }
        
        [Test]
        public void RettangularPlateau()
        {
            p.Objects.Should().NotBeNull();
            p.Tools.Should().NotBeNull();
            p.Size.X.Should().Be(10);
            p.Size.Y.Should().Be(10);
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