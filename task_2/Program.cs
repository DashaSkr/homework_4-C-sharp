// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



int [] FillArray(int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(99);
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int n = EnterData("Введите число: ");
int [] array = FillArray(n);
Console.WriteLine($"Массив из {n} элементов -> [{String.Join(", ",array)}]");