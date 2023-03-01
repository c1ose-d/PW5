namespace TestProject {
    [TestClass]
    public class NegativeUnitTest {
        [TestMethod]
        public void AdditionTestMethod() {
            string first = "a", second = "b", equal = "ab";
            double sum;
            sum = Operations.Addition(first, second);

            Assert.AreEqual(equal, sum.ToString());
        }

        [TestMethod]
        public void SubtractionTestMethod() {
            int first = int.MinValue;
            double second = double.NaN, equal = int.MinValue, difference;
            difference = Operations.Subtraction(first, second);

            Assert.AreEqual(equal, difference);
        }

        [TestMethod]
        public void MultiplicationTestMethod() {
            int first = int.MaxValue;
            double second = int.MaxValue, equal = 4.61168601 * Pow(10, 18), product;
            product = Operations.Multiplication(first, second);

            Assert.AreEqual(equal, product);
        }

        [TestMethod]
        public void DivisionTestMethod() {
            int first = 4;
            double second = 0, equal = double.PositiveInfinity, fraction;
            fraction = Operations.Division(first, second);

            Assert.AreEqual(equal, fraction);
        }

        [TestMethod]
        public void ExponentiationTestMethod() {
            int first = 2;
            double second = 3.5, equal = 8, power;
            power = Operations.Exponentiation(first, second);

            Assert.AreEqual(equal, power);
        }
    }
}