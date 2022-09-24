using FluentAssertions;
using Mars_Rover_Kata.Logic;

namespace Mars_Rover_Kata_Test
{
    public class MarsRoverKataTests
    {
        MarsRoverKata mrk;

        [SetUp]
        public void Setup()
        {
            mrk = new MarsRoverKata();
        }
        
        [Test]
        public void MarsRoverKata()
        {
            mrk.Plateau.Should().NotBeNull();
            mrk.CommandGenerator.Should().NotBeNull();
            mrk.MissionControl.Should().NotBeNull();
        }
    }
}