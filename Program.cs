// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] FillArray(int size)
{
    int[] mas = new int[size];

    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(100, 1000);
    }
    return mas;
}

void PrintArray(int[] mmm)
{
    for (int i = 0; i < mmm.Length; i++)
    {
        if (i != mmm.Length - 1) Console.Write($"{mmm[i]}, ");
        else Console.WriteLine($"{mmm[i]}");
    }
}

try
{
    System.Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] EvenNumb = FillArray(size);
    int count = 0;
    for (int i = 0; i < EvenNumb.Length; i++)
    {
        if (EvenNumb[i] % 2 == 0)
            count++;
    }
    PrintArray(EvenNumb);
    Console.WriteLine($"Количество четных чисел в массиве равно {count}");
}

catch
{
    Console.WriteLine("Надо было вводить целое число!");
}