//Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


int SumAllNumbers(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}
Console.Write("Введите число A: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = SumAllNumbers(number);
Console.WriteLine(res);