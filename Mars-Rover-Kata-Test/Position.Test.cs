using FluentAssertions;
using Mars_Rover_Kata.Model;
namespace Mars_Rover_Kata_Test
{
    public class PositionTests
    {
        Position p;
        [SetUp]
        public void Setup()
        {
            p = new Position(new CartesianCoordinates(7, 10), "N");
        }

        [Test]
        public void PositionTest()
        {
            ((CartesianCoordinates)p.Coordinate).X.Should().Be(7);
            ((CartesianCoordinates)p.Coordinate).Y.Should().Be(10);
            p.Orientation.Should().Be("N");
        }
        [Test]
        public void computeNewPositionTest_LMMLMMRM_shouldBe_4_8_O()
        {
            p.ComputeNewPosition("LMMLMMRM");
            ((CartesianCoordinates)p.Coordinate).X.Should().Be(4);
            ((CartesianCoordinates)p.Coordinate).Y.Should().Be(8);
            p.Orientation.Should().Be("O");
        }
        [Test]
        public void computeNewPositionTest_RRMRMMMLMRMM_shouldBe_2_8_O()
        {
            p.ComputeNewPosition("RRMRMMMLMRMM");
            ((CartesianCoordinates)p.Coordinate).X.Should().Be(2);
            ((CartesianCoordinates)p.Coordinate).Y.Should().Be(8);
            p.Orientation.Should().Be("O");
        }
        [Test]
        public void computeNewPositionTest_LMLMLMLM_shouldBe_7_10_N()
        {
            p.ComputeNewPosition("LMLMLMLM");
            ((CartesianCoordinates)p.Coordinate).X.Should().Be(7);
            ((CartesianCoordinates)p.Coordinate).Y.Should().Be(10);
            p.Orientation.Should().Be("N");
        }
    }
}