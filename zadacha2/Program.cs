//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.


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

int sum = 0;
int i = 0;
int SumOddPosition(int[] array) //суммирование элементов, стоящих на нечётных позициях
{
    while (i < array.Length)
    {
        sum = sum + array[i + 1];
        i += +2;
    }
    return sum;
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
SumOddPosition(array);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sum}");