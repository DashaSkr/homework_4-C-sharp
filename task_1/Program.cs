// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumDigits(int number)
{
    int intermedNumber = number;
    int sum = intermedNumber %10;
    for (int i = 1; i <= intermedNumber; i++ )
    {
        intermedNumber = intermedNumber / 10;
        sum = sum + intermedNumber %10;
    }
    return sum;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int numb = EnterData("Введите число: ");
Console.WriteLine($"{numb} -> {SumDigits(numb)}");