// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size, int min, int max)     // возвращает заполненный массива случайными числами из диапазона [min,max]
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

// void PrintArray(int[] array)    // выводит список элементов в консоль
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

string PrintArrayAsString(int[] array)  // возвращает строку с элементами массива
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

int CountSumElemOnOddId(int[] array)    // возвращает сумму элементов, стоящих на нечётных позициях
{
    int length = array.Length;
    string output = String.Empty;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0) sum += array[i];    // добавляем к суммме значение элемента, если он на нечётной позиции
    }
    return sum;
}

Console.Clear();
// вводим данные для создания массива
Console.Write("Введите кол-во элементов в массиве: ");
int arrayNums = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите min значение для генерации массива [например, -100]: ");
int arrayMin = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(arrayMin);

Console.Write("Введите max значение для генерации массива [например, 100]: ");
int arrayMax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(arrayMax);

// создаём массив
int[] arr = CreateArray(arrayNums, arrayMin, arrayMax);
// получаем строку с элементами массива
string initArrayOut = PrintArrayAsString(arr);

// получаем сумму элементов на нечётных позициях
int result = CountSumElemOnOddId(arr);

// вывод исходного массива и результата в консоль
Console.WriteLine($"Сумма элементов на нечётных позициях в массиве [{initArrayOut}] -> {result}");
