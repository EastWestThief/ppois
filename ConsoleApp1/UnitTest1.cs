namespace TestPolynom
{
    [TestClass()]
    public class TestPolynomial
    {
        [TestMethod()]
        public void TestPrint()
        {
            double[] koff = { 1, 2, 3 };
            Polynomial polynomial = new Polynomial(koff);
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                polynomial.Print();
                string expected = "f(x) = 3x^2 + 2x + 1\r\n";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [TestMethod()]
        public void TestEvaluate()
        {
            double[] koff = { 1, 2, 3 };
            Polynomial polynomial = new Polynomial(koff);
            double x = 2;
            Assert.AreEqual(17, polynomial.Evaluate(x));

        }

        [TestMethod()]
        public void TestAddition()
        {
            double[] koff1 = { 1, 2, 3 };
            double[] koff2 = { 4, 5, 6 };
            Polynomial p1 = new Polynomial(koff1);
            Polynomial p2 = new Polynomial(koff2);
            Polynomial sum = p1 + p2;
            double[] koffSum = { 5, 7, 9 };
            Polynomial expected = new Polynomial(koffSum);
            Assert.AreEqual(expected, sum);
        }

        [TestMethod()]
        public void TestDifference()
        {
            double[] koff1 = { 1, 2, 3 };
            double[] koff2 = { 4, 5, 6 };
            Polynomial p1 = new Polynomial(koff1);
            Polynomial p2 = new Polynomial(koff2);
            Polynomial diff = p2 - p1;
            double[] koffDiff = { 3, 3, 3 };
            Polynomial expected = new Polynomial(koffDiff);
            Assert.AreEqual(expected, diff);
        }

        [TestMethod()]
        public void TestMultiplication()
        {
            double[] koff1 = { 1, 2, 3 };
            double[] koff2 = { 4, 5, 6 };
            Polynomial p1 = new Polynomial(koff1);
            Polynomial p2 = new Polynomial(koff2);
            Polynomial mul = p1 * p2;
            double[] koffMul = { 4, 13, 28, 27, 18 };
            Polynomial expected = new Polynomial(koffMul);
            Assert.AreEqual(expected, mul);
        }


    }
}