// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)     // заполнение массива случайными числами из диапазона [100;1000)
{
    Random rnd = new Random();
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
}

void PrintEvenCount(int[] array)    // выводит количество чётных чисел в массиве
{
    int length = array.Length;
    string output = String.Empty;
    int count = 0;                          // счетчик для подсчета четных элементов
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0) count++;     // увеличиваем счетчик, если элемент чётный
        if (i == length - 1) output += array[i];    // список элементов массива
        else output += $"{array[i]}, ";
    }
    Console.WriteLine($"Количество чётных чисел в массиве [{output}] -> {count}");
}

Console.Write("Введите кол-во чисел в массиве: ");
int arrayNum = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[arrayNum];

FillArray(arr);
PrintEvenCount(arr);
