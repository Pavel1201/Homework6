Console.WriteLine("Введите числа! ");
string numbers = Console.ReadLine()!;
string[] SplitedNumbers = numbers.Split(' ');
int[] ParseNumbers = new int[SplitedNumbers.Length];
int count = 0;

for (int i = 0; i < SplitedNumbers.Length; i++)
{
    ParseNumbers[i] = int.Parse(SplitedNumbers[i]);
    if(ParseNumbers[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"{count} - количество положительных чисел");