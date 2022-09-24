using FluentAssertions;
using Mars_Rover_Kata.Logic;
using Mars_Rover_Kata.Model;

namespace Mars_Rover_Kata_Test
{
    public class MissionControlTests
    {
        MissionControl mc;
        Rover r1;
        Rover r2;

        [SetUp]
        public void Setup()
        {
            mc = new MissionControl();
            r1 = new Rover("R01", 10);
            r2 = new Rover("R02", 8);
            mc.addRover(r1, new Position(new CartesianCoordinates(4, 5), "N"));
            mc.addRover(r2, new Position(new CartesianCoordinates(0, 5), "E"));
        }

        [Test]
        public void MissionControl()
        {
            mc.Rovers.Should().NotBeNull();
        }

        [Test]
        public void RoversTest()
        {
            mc.Rovers.Should().HaveCount(2);
            mc.Rovers.Keys.ElementAt(0).Should().Be(r1);
            mc.Rovers.Keys.ElementAt(1).Should().Be(r2);
        }
        [Test]
        public void ToStringTest()
        {
            mc.ToString().Should().Be("Rover:[Name:R01, Max Weight:10  ], Position:[Coordinates:[4,5], Orientation:[N]]\nRover:[Name:R02, Max Weight:8  ], Position:[Coordinates:[0,5], Orientation:[E]]\n");
        }
    }
}