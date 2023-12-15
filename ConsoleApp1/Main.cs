double[] koff = { 2, -3, 4 };
double[] koff2 = { 5, 7, -2, 8 };

Polynomial p1 = new Polynomial(koff);
p1.Print();


Polynomial p2 = new Polynomial(koff2);
p2.Print();

Console.WriteLine(p1.Evaluate(5));


Polynomial test=(p2 / p1);
test.Print();



//Polynomial del = p2 / p1;
//del.Print();








