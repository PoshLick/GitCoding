/* 

void PrintCoord(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка находится в первой четверти");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Точка находится во второй четверти");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Точка находится в третьей четверти");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Точка находится в четвёртой четверти");
    }
    else
    {
        Console.WriteLine("Четверть определить невозможно");
    }
}


Console.Clear();
Console.WriteLine("Введите координаты точки:   ");
int CoordX = Convert.ToInt32(Console.ReadLine());
int CoordY = Convert.ToInt32(Console.ReadLine());
PrintCoord(CoordX, CoordY);
PrintCoord(10, 214);
PrintCoord(55, -16); */

// Задача #18. Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (х и у).

/* Console.Clear();
Console.WriteLine("Введите номер четверти:   ");
int Quarter = Convert.ToInt32(Console.ReadLine());
if (Quarter == 1)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти:  50, 50");
}
else if (Quarter == 2)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти:  -50, 50");
}
else if (Quarter == 3)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти:  -50, -50");
}
else if (Quarter == 4)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти:  50, -50");
}
else 
{
    Console.WriteLine("Всего может быть 4 четверти:   ");
} */

//Задача #21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве. (Я не помню геометрию О_о)

//Задача #22. Напишите программу, которая прнимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Введите число:   ");
int num = Convert.ToInt32(Console.ReadLine());
int Quad = num*2;
int index = 0;
while (index < num)
{
Console.Write(Quad);
index++;
}