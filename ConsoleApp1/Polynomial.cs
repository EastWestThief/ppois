public class Polynomial
{
    private double[] coefficients;

    public Polynomial(double[] coefficients)
    {
        this.coefficients = coefficients;
    }

    public void Print()
    {
        Console.Write("f(x) = ");
        for (int i = coefficients.Length - 1; i >= 0; i--)
        {

            if (i == 0 & coefficients[i] != 0 & coefficients[i] > 0)
            {
                Console.Write(" + " + coefficients[i]);
            }
            else if (i == 0 & coefficients[i] != 0 & coefficients[i] < 0)
            {
                Console.Write(" - " + coefficients[i]);
            }
            else if (i == coefficients.Length - 1)
            {
                Console.Write(coefficients[i] + "x^" + i);
            }
            else if (i == 1 & coefficients[i] > 0)
            {
                Console.Write(" + " + coefficients[i] + "x");
            }
            else if (i == 1 & coefficients[i] < 0)
            {
                Console.Write(" - " + -1 * coefficients[i] + "x");
            }
            else if (coefficients[i] > 0)
            {
                Console.Write(" + " + coefficients[i] + "x^" + i);
            }
            else if (coefficients[i] < 0)
            {
                Console.Write(" - " + (-1 * coefficients[i]) + "x^" + i);
            }

            else if (coefficients[i] == 0)
            {
                Console.Write(" ");
            }

        }
        Console.WriteLine();
    }


    public double Evaluate(double x)
    {
        double result = 0;
        for (int i = 0; i < coefficients.Length; i++)
        {
            result += coefficients[i] * Math.Pow(x, i);
        }
        return result;
    }
    public double[] getCoefficients()
    {
        return coefficients;
    }

    public static Polynomial operator +(Polynomial p1, Polynomial p2)
    {
        double a = 0, b = 0;
        int length = Math.Max(p1.coefficients.Length, p2.coefficients.Length);
        double[] coefficients = new double[length];
        for (int i = 0; i < length; i++)
        {
            if (i < p1.coefficients.Length)
            {
                a = p1.coefficients[i];
            }
            else
            {
                a = 0;
            }
            if (i < p2.coefficients.Length)
            {
                b = p2.coefficients[i];
            }
            else
            {
                b = 0;
            }
            coefficients[i] = a + b;
        }
        return new Polynomial(coefficients);
    }

    public static Polynomial operator -(Polynomial p1, Polynomial p2)
    {
        int length = Math.Max(p1.coefficients.Length, p2.coefficients.Length);
        double[] coefficients = new double[length];
        for (int i = 0; i < length; i++)
        {
            double a = (i < p1.coefficients.Length) ? p1.coefficients[i] : 0;
            double b = (i < p2.coefficients.Length) ? p2.coefficients[i] : 0;
            coefficients[i] = a - b;
        }
        return new Polynomial(coefficients);
    }

    public static Polynomial operator *(Polynomial p1, Polynomial p2)
    {
        int length = p1.coefficients.Length + p2.coefficients.Length - 1;
        double[] coefficients = new double[length];
        for (int i = 0; i < p1.coefficients.Length; i++)
        {
            for (int j = 0; j < p2.coefficients.Length; j++)
            {
                coefficients[i + j] += p1.coefficients[i] * p2.coefficients[j];
            }
        }
        return new Polynomial(coefficients);
    }


    public static Polynomial operator /(Polynomial dividend, Polynomial divisor)
    {
        if (dividend.coefficients.Length < divisor.coefficients.Length)
        {
            return new Polynomial(new double[] { 0 });
        }

        double[] quotient = new double[dividend.coefficients.Length - divisor.coefficients.Length + 1];
        double[] remainder = (double[])dividend.coefficients.Clone();

        for (int i = quotient.Length - 1; i >= 0; i--)
        {
            quotient[i] = remainder[i + divisor.coefficients.Length - 1] / divisor.coefficients[divisor.coefficients.Length - 1];

            for (int j = i + divisor.coefficients.Length - 2; j >= i; j--)
            {
                remainder[j] -= quotient[i] * divisor.coefficients[j - i];
            }
        }

        return new Polynomial(quotient);
    }


}


