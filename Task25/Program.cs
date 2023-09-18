// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Stepen(int A, int B)
{
    int Step = 1;
    while (B != 0) {
        Step = Step * A;
        B--;
    }
return Step;
}

int res = Stepen(4,5);
Console.WriteLine(res);
