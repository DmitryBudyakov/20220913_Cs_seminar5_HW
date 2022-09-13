// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)     // заполнение массива случайными числами из диапазона [-100;101)
{
    Random rnd = new Random();
    int length = array.Length;
    int minNum = -10, maxNum = 11;
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minNum, maxNum);
    }
}

void PrintSumOddId(int[] array)    // выводит сумму элементов, стоящих на нечётных позициях
{
    int length = array.Length;
    string output = String.Empty;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0) sum += array[i];    // добавляем к суммме значение элемента, если он на нечётной позиции
        if (i == length - 1) output += array[i];
        else output += $"{array[i]}, ";
    }
    Console.WriteLine($"Сумма элементов на нечётных позициях в массиве [{output}] -> {sum}");
}


Console.Write("Введите кол-во элементов в массиве: ");
int arrayNum = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[arrayNum];

FillArray(arr);
PrintSumOddId(arr);
