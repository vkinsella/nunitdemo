using System;
using NUnit.Framework;
using NunitDemo;

namespace Example
{
    [TestFixture]
    public class PostageTest
    {
        static void Main()
        {

        }

        const double tol = 0.001;
        Postage p1;

        [SetUp] 
        public void Init()
        {
            p1 = new Postage();
        }


        [Test]
        public void Test1()
        {

            Assert.That(p1, Is.Not.Null, "Object not created");
        }


        [Test]
        public void TestPostageCalculation1()
        {

            double expectedResult = 5.0;
            double actualResult = p1.GetPostageCost(1, 1500);
            Assert.That(actualResult, Is.EqualTo(expectedResult), "Test of postage Failed for region 1 and weight 1500", tol);
        }

        [TestCase(3, 1000, ExpectedResult = 70)]
        [TestCase(4, 1000, ExpectedResult = 75)]
        [TestCase(0, 0, ExpectedResult = 0)]

        public double test3(int a, double b)
        {

            double actualResult = p1.GetPostageCost(a, b);
            return actualResult;

        }



    }

}
