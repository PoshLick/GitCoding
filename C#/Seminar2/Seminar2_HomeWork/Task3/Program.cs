// Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

Console.Write("Введите номер дня недели:     ");
int num = int.Parse(Console.ReadLine()?? "wares");

if (num < 1 || num > 7)
{
    Console.Write(" - Only 7 days in a week, moron");
}
else if (num > 5)
{
    Console.Write($" -  {week[num - 1]} it's a day off!");
}
else
{
    Console.Write($" -  {week[num - 1]} it's a week day...");
}