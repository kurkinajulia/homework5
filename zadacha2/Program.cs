//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] CreateArray(int size) //cоздание массива
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}
void ShowArray(int[] array) //показ массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int SumOddPosition(int[] array) //суммирование элементов, стоящих на нечётных позициях
{
    int sum = 0;
    int index = 1;
    if (array.Length == 1)
    {
        return array[0];
    }
    else
    {
        while (index < array.Length)
        {
            sum = sum + array[index];
            index = index + 2;
        }
    }
    return sum;
}
Console.WriteLine("Введите размер массива: "); //введение пользователем размера массива
int size = Convert.ToInt32(Console.ReadLine());
if (size <= 1)
{
    Console.WriteLine("Размер массива должен быть больше 1.");
    return;
}
int[] array = CreateArray(size);
Console.Write("Массив заполнен числами: ");
ShowArray(array);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {SumOddPosition(array)}");