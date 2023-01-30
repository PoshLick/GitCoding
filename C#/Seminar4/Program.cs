/* Console.Clear();
Console.WriteLine("Введите число:   ");

int chislo = Convert.ToInt32(Console.ReadLine());
int sum = 1;
for (int i = 1; i <= chislo; i++)
{
    sum = sum * i;
}
    Console.WriteLine($"{sum}");

 */

/*
Через функцию:
 int SUMMA (int chislo)
{
    int sum = 1;
    for (int i = 1; i <= Math.Abs(chislo); i++)
    {
        sum *= i;
    }
    return sum;
}

SUMMA (5);
Console.WriteLine(SUMMA(5)); */

/* void NumCount(int numb)
{
    int result = 0;
    while(numb>0)
    {
        numb = numb / 10;
        result++;
    }
    Console.WriteLine($"Количество чисел: {result}");
}

Console.WriteLine("Введите число");
NumCount(Convert.ToInt32(Console.ReadLine())); */