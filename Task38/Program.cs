// Задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArray(int size, int range)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * range, 2, MidpointRounding.ToZero);
    }
    return array;
}

// void PrintArray(double[] array)    // выводит список элементов в консоль
// {
//     int length = array.Length;
//     Console.Write("[");
//     for (int i = 0; i < length; i++)
//     {
//         if(i== length - 1) Console.Write(array[i]);
//         else Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine("]");
// }

string PrintArrayAsString(double[] array)  // возвращает строку с элементами массива
{
    int length = array.Length;
    string output = String.Empty;
    for (int i = 0; i < length; i++)
    {
        if (i == length - 1) output += array[i];
        else output += $"{array[i]}, ";
    }
    return output;
}

double CountDiffMaxMinArray(double[] array) // возвращает разницу между макс. и мин. значениями массива
{
    int length = array.Length;
    double minNum = array[0];
    double maxNum = array[0];
    string arrayOutput = String.Empty;
    for (int i = 0; i < length; i++)
    {
        if (array[i] < minNum) minNum = array[i];
        if (array[i] > maxNum) maxNum = array[i];
    }
    double diffNum = Math.Round(maxNum - minNum, 2, MidpointRounding.ToZero);
    return diffNum;
}

// данные для создания массива
Console.Write("Введите кол-во элементов массива: ");
int arrayNums = Convert.ToInt32(Console.ReadLine());

// результат создания массива
double[] arr = CreateArray(arrayNums, 10);  // массив в диапазоне [0.0,10.0]
string initArrayOut = PrintArrayAsString(arr);

// разница между макс. и мин. значениями в массиве
double diffMaxMin = CountDiffMaxMinArray(arr);

// вывод консоль
Console.WriteLine($"Разница между максимальным и минимальным элементами массива [{initArrayOut}] -> {diffMaxMin}");
