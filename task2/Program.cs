// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string msg)
{
    System.Console.WriteLine($"{msg} : ");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}
int a = Prompt("Введите число ");
int SumDigit(int a)
{
    int sum = 0;
    while (a > 0)
    {
        a = a / 10;
        sum = sum + a % 10;
        sum++;
    }
    return sum;
}
Console.WriteLine($"Сумма в числе {a} - {SumDigit(a)}");
