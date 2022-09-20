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
            cc.x.Should().Be(5);
            cc.y.Should().Be(5);
        }
        [Test]
        public void compareCoordinates()
        {
            cc.compareCoordinates(new CartesianCoordinates(5,5)).Should().BeTrue();
            cc.compareCoordinates(new CartesianCoordinates(4, 9)).Should().BeFalse();
            cc.compareCoordinates(new CartesianCoordinates(0, 0)).Should().BeFalse();
        }
        [Test]
        public void addToX_Test()
        {
            cc.addToX(+1);
            cc.x.Should().Be(6);
            cc.addToX(0);
            cc.x.Should().Be(5);
            cc.addToX(-1);
            cc.x.Should().Be(4);
        }
        [Test]
        public void addToY_Test()
        {
            cc.addToY(+1);
            cc.y.Should().Be(6);
            cc.addToY(0);
            cc.y.Should().Be(5);
            cc.addToY(-1);
            cc.y.Should().Be(4);
        }
        [Test]
        public void setCardinalCoordinates()
        {
            cc.x = 10;
            cc.y = 11;
            cc.compareCoordinates(new CartesianCoordinates(10, 11)).Should().BeTrue();
            cc.compareCoordinates(new CartesianCoordinates(5, 5)).Should().BeFalse();
            cc.compareCoordinates(new CartesianCoordinates(0, 0)).Should().BeFalse();
        }
    }
}