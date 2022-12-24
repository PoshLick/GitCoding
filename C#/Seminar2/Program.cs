// // Задача 1 (Делал с лектором)

// Console.Clear();
// int a = 0;
// int b = 0;
// int number = new Random().Next(10,100);
// Console.WriteLine(number);
// a = number/10;
// b = number%10;
//     if (a>b) 
// { 
//     Console.WriteLine("Наибольшая цифра №1 - это " + a);
// }
// else
// {
//     Console.WriteLine("Наибольшая цифра №2 - это " + b);
// }


// Задача №2 (Сделал полностью сам, урааа))))

// Console.Clear();
// int a = 0;
// int b = 0;
// int number = new Random().Next(100,1000);
// Console.WriteLine(number);
// a = number/100;
// Console.WriteLine(a);
// b = number%10;
// Console.WriteLine(b);


// Задача №3 (ЕБ###ТЬ, СНОВА САМ СДЕЛАЛ, МУХАХАХАХА)

// Console.Clear();
// Console.WriteLine("Введите первое число: ");
// double a = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите первое число: ");
// double b = Convert.ToInt32 (Console.ReadLine());
// if (b%a==0) Console.WriteLine("Второе число является кратным первому: " +b/a);
// else Console.WriteLine("Второе число не является кратным первому: " + b/a);



// Задачу №4 (ТОЖЕ СДЕЛАЛ САМОСТОЯТЕЛЬНО, ФИИИГАААААА)
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = -1;
// if (a % 23==0) b = a; 
// if (b%7==0) Console.WriteLine("Число " + b + " кратное 23 и 7 одновременно ");
// else Console.WriteLine("Число " + a +  " не кратно одновременно 23 и 7 одновременно ");


// Задача №5 (ТОЖЕ СДЕЛАЛ САМ, АЛИЛУЙЯ)

// Console.Clear();
// Console.WriteLine("Введите число 1 : ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2 : ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (b * b == a) Console.WriteLine("Число " + a + " является квадратом числа " + b);
// else if (a * a == b) Console.WriteLine("Число " + b + " является квадратом числа " + a);
// else Console.WriteLine("Число  " + a + " НЕ является квадратом числа " + b + ", а число " + b + " НЕ является квадратом числа " + a);