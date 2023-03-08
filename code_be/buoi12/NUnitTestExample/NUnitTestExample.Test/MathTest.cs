using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestExample.Test
{
    internal class MathTest
    {
        Math math;

        [SetUp] public void SetUp() { math = new Math(); }

        [Test]
        public void Max_FirstArgumentGreaterThan_ReturnFirstArgument()
        {
            Assert.AreEqual(3, math.Max(3, 2));
        }

        [Test]
        public void Max_SecondArgumentGreaterThan_ReturnSecondArgument()
        {
            Assert.AreEqual(4, math.Max(3, 4));
        }

        [Test]
        [TestCase(0, 2, 2)]
        [TestCase(3, 2, 3)]
        public void Max_WhenCalled_ReturnTheGreatest(int a, int b, int ex)
        {
            Assert.That(math.Max(a, b), Is.EqualTo(ex));
        }
    }
}
