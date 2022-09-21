using FluentAssertions;
using Mars_Rover_Kata;
namespace Mars_Rover_Kata_Test
{
    public class CartesianCoordinatesTests
    {
        CartesianCoordinates cc;
        [SetUp]
        public void Setup()
        {
            cc = new CartesianCoordinates(5,5);
        }

        [Test]
        public void CartesianCoordinates()
        {
            cc.X.Should().Be(5);
            cc.Y.Should().Be(5);
        }
        
        [Test]
        public void compareCoordinates()
        {
            cc.CompareCoordinates(new CartesianCoordinates(5,5)).Should().BeTrue();
            cc.CompareCoordinates(new CartesianCoordinates(4, 9)).Should().BeFalse();
            cc.CompareCoordinates(new CartesianCoordinates(0, 0)).Should().BeFalse();
        }
        [Test]
        public void addToX_Test()
        {
            cc.AddToX(+1);
            cc.X.Should().Be(6);
            cc.AddToX(-1);
            cc.X.Should().Be(5);
            cc.AddToX(0);
            cc.X.Should().Be(5);
            cc.AddToX(-1);
            cc.X.Should().Be(4);
        }
        [Test]
        public void addToY_Test()
        {
            cc.AddToY(+1);
            cc.Y.Should().Be(6);
            cc.AddToY(-1);
            cc.Y.Should().Be(5);
            cc.AddToY(0);
            cc.Y.Should().Be(5);
            cc.AddToY(-1);
            cc.Y.Should().Be(4);
        }
        [Test]
        public void setCardinalCoordinates()
        {
            cc.X = 10;
            cc.Y = 11;
            cc.CompareCoordinates(new CartesianCoordinates(10, 11)).Should().BeTrue();
            cc.CompareCoordinates(new CartesianCoordinates(5, 5)).Should().BeFalse();
            cc.CompareCoordinates(new CartesianCoordinates(0, 0)).Should().BeFalse();
        }
        [Test]
        public void toStringTest()
        {
            cc.ToString().Should().Be("[5,5]");
            cc.X = 10;
            cc.Y = 11;
            cc.ToString().Should().Be("[10,11]");
        }
    }
}