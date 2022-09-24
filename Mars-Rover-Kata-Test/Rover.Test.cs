using FluentAssertions;
using Mars_Rover_Kata.Model;
using Mars_Rover_Kata.Model.Abstract;

namespace Mars_Rover_Kata_Test
{
    public class RoverTests
    {
        Rover r;
        Tools t1;
        Tools t2;
        Objects o1;
        Objects o2;
        
        [SetUp]
        public void Setup()
        {
            this.r = new Rover("R1",10);
            this.t1 = new RobotArm("t1", 7);
            this.t2 = new Camera("t2", 3);
            this.o1 = new Rock("o1", 6);
            this.o2 = new Rock("o2", 1);
        }

        [Test]
        public void RoverConstructorTest()
        {
            r.Name.Should().Be("R1");
            r.MaxWeightAllowed.Should().Be(10);
            r.Tools.Should().NotBeNull();
            r.Objects.Should().NotBeNull();
        }
        
        [Test]
        public void RoverAddToolTest()
        {
            r.addTool(t1).Should().BeTrue();
            r.addTool(t2).Should().BeTrue();
            r.addTool(t2).Should().BeFalse();
        }

        [Test]
        public void RoverAddObjectsTest()
        {
            r.addObject(o1).Should().BeTrue();
            r.addObject(o2).Should().BeTrue();
            r.addObject(o2).Should().BeTrue();
            r.addObject(o1).Should().BeFalse();
        }

        [Test]
        public void RoverAddObjectsAndToolsTest()
        {
            r.addObject(o1).Should().BeTrue();
            r.addObject(o2).Should().BeTrue();
            r.addTool(t2).Should().BeTrue();
            r.addTool(t1).Should().BeFalse();
        }
    }
}