Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

void PrintNumbers(int start)
{
    if (start < 1) return; 
    Console.Write($"{start} ");
    if (start == 1) return;
    PrintNumbers(start - 1);
}

PrintNumbers(N);


Console.WriteLine("Введите M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine());

int SumOfInterval(int firstNum, int secondNum)
{

    int sum = 0;
    if (firstNum == secondNum) return secondNum;
    sum = firstNum + SumOfInterval(firstNum + 1, secondNum);
    Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
    return sum;
}

Console.WriteLine(SumOfInterval(m, n));


Console.WriteLine("Введите M");
int mA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N");
int nA = int.Parse(Console.ReadLine());

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.WriteLine(Ackermann(mA, nA));