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


if (coefficientk1 == coefficientk2 && coefficientb1 == coefficientb2)
{
    Console.WriteLine("Прямые совпадают");
}
else if (coefficientk1 == coefficientk2 && coefficientb1!=coefficientb2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    x = (coefficientb2 - coefficientb1)/(coefficientk1 - coefficientk2);
    y = coefficientk1*x + coefficientb1;
    Console.WriteLine($" Точка пересечения ({x},{y})");
}

