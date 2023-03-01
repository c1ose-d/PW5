namespace TestProject {
    [TestClass]
    public class PositiveUnitTest {
        [TestMethod]
        public void AdditionTestMethod() {
            int first = 1;
            double second = 1.5, equal = 2.5, sum;
            sum = Operations.Addition(first, second);

            Assert.AreEqual(equal, sum);
        }

        [TestMethod]
        public void SubtractionTestMethod() {
            int first = 3;
            double second = 1.5, equal = 1.5, difference;
            difference = Operations.Subtraction(first, second);

            Assert.AreEqual(equal, difference);
        }

        [TestMethod]
        public void MultiplicationTestMethod() {
            int first = 8;
            double second = 1.5, equal = 12, product;
            product = Operations.Multiplication(first, second);

            Assert.AreEqual(equal, product);
        }

        [TestMethod]
        public void DivisionTestMethod() {
            int first = 4;
            double second = 4, equal = 1, fraction;
            fraction = Operations.Division(first, second);

            Assert.AreEqual(equal, fraction);
        }

        [TestMethod]
        public void ExponentiationTestMethod() {
            int first = 2;
            double second = 3, equal = 8, power;
            power = Operations.Exponentiation(first, second);

            Assert.AreEqual(equal, power);
        }
    }
}