//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] CreateArray(int size) //cоздание массива
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
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

int even = 0;
int ShowEvenNumbers(int[] array) //подсчёт количества чётных чисел в массиве
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            even++;
    }
    return even;
}

Console.Write("Введите размер массива: "); //введение пользователем размера массива 
int size = Convert.ToInt32(Console.ReadLine());
if (size <= 1)
{
    Console.WriteLine("Размер массива должен быть больше 1.");
    return;
}

int[] array = CreateArray(size);
Console.Write("Массив заполнен числами: ");
ShowArray(array);
Console.WriteLine($"Количество чётных чисел в массиве: {ShowEvenNumbers(array)}");