using Quick_Calc;

namespace Quick_Calc.Tests
{
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void AdditionTest()
        {
            int result = calc.Calculate(5, 3, "+");
            Assert.AreEqual(8, result);
        }

        [Test]
        public void SubtractionTest()
        {
            int result = calc.Calculate(10, 4, "-");
            Assert.AreEqual(6, result);
        }

        [Test]
        public void NegativeSubtractionTest()
        {
            int result = calc.Calculate(4, 10, "-");
            Assert.AreEqual(-6, result);
        }

        [Test]
        public void MultiplicationTest()
        {
            int result = calc.Calculate(7, 6, "×");
            Assert.AreEqual(42, result);
        }

        [Test]
        public void DivisionTest()
        {
            int result = calc.Calculate(20, 4, "÷");
            Assert.AreEqual(5, result);
        }

        [Test]
        public void DivisionByZeroThrows()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Calculate(10, 0, "÷"));
        }

        [Test]
        public void BigNumbersTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.Calculate(10000000, 10000000, "+"));
        }

        [Test]
        public void ClearResetsResult()
        {
            calc.Result = 123;
            calc.Clear();
            Assert.AreEqual(0, calc.Result);
        }
    }
}