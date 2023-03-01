//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int Prompt(string messageTerminal)
{
    Console.Write(messageTerminal);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

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

int size = Prompt("Введите размер массива: "); //введение пользователем размера массива 
if (size <= 1)
{
    Console.WriteLine("Размер массива должен быть больше 1.");
    return;
}

Console.Write("Массив заполнен числами: ");
int[] array = CreateArray(size);
ShowArray(array);
ShowEvenNumbers(array);
Console.WriteLine($"Количество чётных чисел в массиве: {even}");