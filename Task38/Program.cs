// Задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(int[] array)     // заполнение массива случайными числами из диапазона [-100;100]
{
    Random rnd = new Random();
    int length = array.Length;
    int minNum = -100, maxNum = 101;
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minNum, maxNum);
    }
}

void CountDiffMaxMinArray(int[] array)
{
    int length = array.Length;
    int minNum = array[0];
    int maxNum = array[0];
    string arrayOutput = String.Empty;
    for (int i = 0; i < length; i++)
    {
        if (array[i] < minNum) minNum = array[i];
        if (array[i] > maxNum) maxNum = array[i];
        if(i == length - 1) arrayOutput += array[i];
        else arrayOutput += $"{array[i]} ";
    }
    int diffNum = maxNum - minNum;
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива [{arrayOutput}] -> {diffNum}");
}

Console.Write("Введите кол-во элементов массива: ");
int arrayNum = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[arrayNum];

FillArray(arr);
CountDiffMaxMinArray(arr);
