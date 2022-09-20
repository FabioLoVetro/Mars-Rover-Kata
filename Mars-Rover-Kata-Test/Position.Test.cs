using FluentAssertions;
using Mars_Rover_Kata;
namespace Mars_Rover_Kata_Test
{
    public class PositionTests
    {
        Position p;
        [SetUp]
        public void Setup()
        {
            p = new Position(new CartesianCoordinates(7,10),"N");
        }

        [Test]
        public void PositionTest()
        {
            p.coordinate.x.Should().Be(7);
            p.coordinate.y.Should().Be(10);
            p.orientation.Should().Be("N");
        }
        [Test]
        public void computeNewPositionTest_LMMLMMRM_shouldBe_4_8_O()
        {
            p.computeNewPosition("LMMLMMRM");
            p.coordinate.x.Should().Be();
            p.coordinate.y.Should().Be();
            p.orientation.Should().Be("N");
        }
        [Test]
        public void computeNewPositionTest_RRMRMMMLMRMM_shouldBe_2_8_O()
        {
            p.computeNewPosition("RRMRMMMLMRMM");
            p.coordinate.x.Should().Be();
            p.coordinate.y.Should().Be();
            p.orientation.Should().Be("N");
        }
        [Test]
        public void computeNewPositionTest_LMLMLMLM_shouldBe_7_10_N()
        {
            p.computeNewPosition("LMLMLMLM");
            p.coordinate.x.Should().Be();
            p.coordinate.y.Should().Be();
            p.orientation.Should().Be("N");
        }
    }
}