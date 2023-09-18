// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] NArray (int N)
{
    int[] A = new int[N];
    while (N > 0)
    {
        A[N-1] = new Random().Next(0,100);
        N = N - 1;
    }
    return A; 
}

int[] res = NArray(8);
var strres = string.Join(" ", res);
Console.WriteLine(strres);
