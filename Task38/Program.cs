// Задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(double[] array)
{
    Random rnd = new Random();
    int rndIndex = 10;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * rndIndex, 2, MidpointRounding.ToZero);
    }
}

void CountDiffMaxMinArray(double[] array)
{
    int length = array.Length;
    double minNum = array[0];
    double maxNum = array[0];
    string arrayOutput = String.Empty;
    for (int i = 0; i < length; i++)
    {
        if (array[i] < minNum) minNum = array[i];
        if (array[i] > maxNum) maxNum = array[i];
        if (i == length - 1) arrayOutput += array[i];
        else arrayOutput += $"{array[i]} ";
    }
    double diffNum = Math.Round(maxNum - minNum, 2, MidpointRounding.ToZero);
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива [{arrayOutput}] -> {diffNum}");
}

Console.Write("Введите кол-во элементов массива: ");
int arrayNum = Convert.ToInt32(Console.ReadLine());

double[] arr = new double[arrayNum];

FillArray(arr);
CountDiffMaxMinArray(arr);
