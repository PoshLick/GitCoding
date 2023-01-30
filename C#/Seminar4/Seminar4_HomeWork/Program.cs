/* Без цикла:

Console.Clear();
Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Math.Pow(A, B)}");



 С циклом:

Console.Clear();
Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
int i = 0;
int sum = 1;
while (i < B)
{
    sum = sum*A;
    i = i + 1;
}
Console.WriteLine(sum); */


/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
string num = Console.ReadLine();
int sum = 0;

for (int i = 0; i < num.Length; i++)
{
    sum = sum + Convert.ToInt32(Convert.ToString(num[i]));
}
Console.WriteLine(sum);
 */


/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 

int [] arr = new int [8];

void PrintArray(int [] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = new Random().Next(1,10);
        Console.Write($"{array [i] } ");
    }
}

PrintArray(arr); */