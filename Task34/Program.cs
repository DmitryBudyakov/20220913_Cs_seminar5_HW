// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size, int min, int max)     // заполнение массива случайными числами из диапазона [min,max]
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

// void PrintArray(int[] array)    // выводит список элементов в строку
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

int CountEvenElem(int[] array)    // возвращает количество чётных чисел в массиве
{
    int length = array.Length;
    int count = 0;                          // счетчик для подсчета четных элементов
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0) count++;     // увеличиваем счетчик, если элемент чётный
    }
    return count;
}

Console.Clear();
// ввод данных для создания массива
Console.Write("Введите кол-во 3-х значных чисел в массиве: ");
int arrayNums = Convert.ToInt32(Console.ReadLine());

// создание массива 3-х значных чисел
int[] arr = FillArray(arrayNums, 100, 999);
string initArrayOut = PrintArrayAsString(arr);

// считаем кол-во четных элементов в массиве
int evenNums = CountEvenElem(arr);

// выводим на консоль
Console.WriteLine($"Количество чётных чисел в массиве [{initArrayOut}] -> {evenNums}");
