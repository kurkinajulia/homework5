//Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//нельзя использовать Math.Pow
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


int Method(int number, int exponent)
{
    int result = 1;
    for (int i = 0; i < exponent; i++)
    {
        result = result * number;
    }
    return result;
}
Console.Write("Введите число A: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int exponent = Convert.ToInt32(Console.ReadLine());
int res = Method(number, exponent);
Console.WriteLine(res);