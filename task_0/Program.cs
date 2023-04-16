// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Exponentiate(int exp, int limit)
{   
    int entermedExp = exp;
    for (int i = 1; i < limit; i++)
    {
        entermedExp = entermedExp * exp;
    }
    return entermedExp;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int a = EnterData("Введите число А: ");
int b = EnterData("Введите число B: ");
Console.WriteLine($"{a}, {b} -> {Exponentiate(a, b)}");
