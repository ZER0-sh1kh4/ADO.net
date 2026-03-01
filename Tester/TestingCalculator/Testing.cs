
using Age.Feature;

namespace TestingAge
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void Testing_even()
        {
            var age = new age();
            bool result = age.CheckAge(2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Testing_SumOfN()
        {
            var age = new age();
            int n = 5;

            int result = age.SumOf(n);

            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void Testing_ReverseString()
        {
            var age = new age();
            string input = "hello";

            string result = age.ReverseString(input);

            Assert.AreEqual("olleh", result);
        }
    }
}
