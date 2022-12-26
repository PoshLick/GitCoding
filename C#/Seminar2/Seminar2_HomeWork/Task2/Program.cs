// Напишите программу, которая 
// выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a <= 100)
{
    Console.WriteLine("Третьей цифры нет и точка. ");
}
else
{
    while (a >= 999)
    {
        a = a / 10;
    }
    int b = (a % 10);
    Console.WriteLine("Третья цифра вашего числа - " + b);
}

