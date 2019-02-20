using Microsoft.VisualStudio.TestTools.UnitTesting;
using area_and_the_circumference_of_a_circle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace area_and_the_circumference_of_a_circle.Tests
{
    [TestClass()]
    public class area_and_the_circumference_of_a_circleClassTests
    {
        area_and_the_circumference_of_a_circleClass objectUnderTest = new area_and_the_circumference_of_a_circleClass();

        [TestMethod()]
        public void SquareTest()
        {
            Assert.AreEqual(36, objectUnderTest.Square(-6));
            Assert.AreEqual(0, objectUnderTest.Square(0));
            Assert.AreEqual(4, objectUnderTest.Square(2));
            objectUnderTest.Square(6).ShouldBe(36);
        }

        [TestMethod()]
        public void CubeTest()
        {
            Assert.AreEqual(8, objectUnderTest.Cube(2));
            objectUnderTest.Cube(-2).ShouldBe(-8);
        }
    }
}
