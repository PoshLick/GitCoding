/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

Console.Clear();

Console.WriteLine("введи первое число:");
int Num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введи второе число:");
int Num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введи третье число:");
int Num3 = Convert.ToInt32(Console.ReadLine());

if (Num1 > Num2 && Num1 > Num3)
{
    
    Console.WriteLine($"Максимальное значение = {Num1} ");

}
else if (Num3 > Num2)
{
    Console.WriteLine($"Максимальное значение = {Num3} ");
}

else
{
    Console.WriteLine($"Максимальное значение = {Num2} ");
}