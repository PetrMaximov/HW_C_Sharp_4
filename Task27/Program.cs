// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNum (int Num)
{
    int Sum = 0;
    Num = Math.Abs(Num);
    while (Num > 0)
    {
       int digit = Num % 10;
       Sum = Sum + digit;
       Num = Num / 10;
    }
    return Sum;
}

int res = SumNum (9012);
Console.WriteLine(res);
