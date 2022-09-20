double coefficient(string number)
{
    Console.WriteLine($"Введите коэффициент {number}");
    double coefficient = double.Parse(Console.ReadLine()!);
    return coefficient;
}
double x = 0;
double y = 0;
double coefficientk1 = coefficient("k1");
double coefficientb1 = coefficient("b1");
double coefficientk2 = coefficient("k2");
double coefficientb2 = coefficient("b2");
Console.WriteLine($"Вы ввели прямые: ");
Console.WriteLine($"{coefficientk1}x + {coefficientb1} ");
Console.WriteLine($"{coefficientk2}x + {coefficientb2} ");

void crossingStraightLines(double k1, double b1, double k2, double b2)
{
if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2 && b1!=b2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    x = (b2 - b1)/(k1 - k2);
    y = k1*x + b1;
    Console.WriteLine($" Точка пересечения ({x},{y})");
}
}

crossingStraightLines(coefficientk1, coefficientb1, coefficientk2, coefficientb2);
