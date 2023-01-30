/* Вывод кубов до введённого числа

Console.Clear();
Console.WriteLine("Введите число:   ");
int num = Convert.ToInt32(Console.ReadLine());

for (int index = 1; index <= num; index++)
{
    Console.Write($"{index * index * index} ");
} */

/* Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве: */

/* Console.Clear();
Console.Write("Введите координату X1:  ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1:  ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1:  ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X2:  ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y2:  ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z2:  ");
int Z2 = Convert.ToInt32(Console.ReadLine());


double d = Math.Sqrt(Math.Pow(X1-X2, 2)+Math.Pow(Y1-Y2, 2)+Math.Pow(Z1-Z2, 2));

Console.WriteLine($"distance = {d:f3}");
 */

 /* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом: */
 
 Console.Write("Введите пятизначное число:   ");
 int WholeNum = Convert.ToInt32(Console.ReadLine());

while (WholeNum > 99999||WholeNum < 10000);
{
    Console.Write("Вы ввели не пятинзначое число, исправьте:  ");
    int WholeNum2 = Convert.ToInt32(Console.ReadLine());
    if (WholeNum2 >9999 && WholeNum2 < 100000)
    {
        WholeNum = WholeNum2;
    }
}
    if (WholeNum/10000 == WholeNum%10 && WholeNum/1000%10 == WholeNum/10%10)
    {
        Console.WriteLine($"Введённое число {WholeNum} является палиндромом");
    }

else 
    {
        Console.WriteLine("Введённое число не является палиндромом.   ");
    }