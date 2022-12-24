/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

/*Задачи 1 - 4(4 не решена)*/

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) Console.WriteLine("Первое число больше второго: " + a);
else Console.WriteLine("Второе число больше первого: " + b);


Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c) Console.WriteLine("Первое число максимальное: ");
if (b > c && b > c) Console.WriteLine("Второе число максимальное: ");
if (c > a && c > b) Console.WriteLine("Третье число максимальное: " + c);



Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) Console.WriteLine("Введённое число чётное");
else Console.WriteLine("Введённое число нечётное");


Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = (a - a) + 1;
int index = 0;
int chet = 0;
while (index <= a) ;
{
    if (b % 2 == 0) ;
    {
        chet = b;
        Console.Write("Чётные числа: " + chet);
    }
    if (b < 0) ;
    {
        Console.WriteLine("Отрицательное число, введите положительное: ");
    }
    index++;
}