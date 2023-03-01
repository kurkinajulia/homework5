//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int GetArraySize() //ввод размера массива
{
    Console.Write("Введите размер вашего массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

void AddNumbersInArray(double[] array) //cоздание массива
{
    Random random = new Random();
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = Math.Round(random.NextDouble() * 100, 2);
    }
}

void ShowArray(double[] array) //показ массива
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"{array[index]} ");
    }
    Console.WriteLine();
}

double FindMaxMinDiff(double[] array) //нахождение разницы между максимальным и минимальным числом в массиве
{
    double FindMin(double[] array) //нахождение минимального числа в массиве
    {
        double min = array[0];
        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] < min) min = array[index];
        }
        return min;
    }

    double FindMax(double[] array) //нахождение максимального числа в массиве
    {
        double max = array[0];
        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] > max) max = array[index];
        }
        return max;
    }

    double diff = FindMax(array) - FindMin(array); //нахождение разницы
    return diff;
    };

double[] array = new double[GetArraySize()];
if (array.Length <= 1)
{
    Console.WriteLine("Размер массива должен быть больше 1.");
    return;
}

AddNumbersInArray(array);
ShowArray(array);

Console.WriteLine($"Разница между максимальным и минимальным числом в массиве: {FindMaxMinDiff(array)}"); //вывод разницы между максимальным и минимальным числом
