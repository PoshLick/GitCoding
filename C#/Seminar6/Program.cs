// Задача на переворот массива:

// int[] Array1 = CreateRandomArray(new Random().Next(5,10), 1, 20);
// ShowArray(Array1);
// ArrayInvertation(Array1);
// ShowArray(Array1);

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray /*  */= new int[N]; //Размерность массива - new int [размер массива]
//     for (int i = 0; i < N; i++) // i - индекс здесь является сразу и числом, до которого мы заполняем 
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void ArrayInvertation(int [] array)
// {
//     int clone = 0;
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         clone = array[i];
//         array[i] = array[array.Length-1-i];
//         array[array.Length-1-i] = clone;
//     }
// }

// Задача #40, проверка на существование треугольника:

//Задача #42, Программа, которая будет преобразовывать десятичное число в двоичное (Без массива):

// int N = new Random().Next(1,10000);
// Console.WriteLine($"Случайное число в диапазоне от 1 до 10.000 до преобразования в двоичный код: {N}");
// while (N >2)
// {
//     N = N/2;
//     Console.Write($" {N%2} ");
// }

// Задача 42: с Массивом (Не доделал);

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray /*  */= new int[N]; //Размерность массива - new int [размер массива]
//     for (int i = 0; i < N; i++) // i - индекс здесь является сразу и числом, до которого мы заполняем 
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void DualNumbers(int [] array)
// {
//     int i = 0;
//     for (i = 0; i <array.Length; i++)
//     while (array[i]>0)
//     {
//      array[i] = array[i]/2%2;   
//      Console.WriteLine(array[i]);
//     }
// }

// int[] Array1 = CreateRandomArray(new Random().Next(5,10), 1, 20);
// ShowArray(Array1);
// DualNumbers(Array1);
// ShowArray(Array1);

// Задача 44: Числа фибоначи

// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int fib1 = 0;
// int fib2 = 1;
// int fib3 = 0;
// for (int i = 0; i < N; i++)
// {

//     fib3 = fib1 + fib2;
//     fib1 = fib2;
//     fib2 = fib3;

//     Console.WriteLine(fib3);
// }



// Сколько чисел больше 0 ввёл пользователь:

int[] numbers = GetArrayFromString(Console.ReadLine());
Console.WriteLine($"Количество чисел больше 0 ->  {GetCountPositiveElements(numbers)}");

int[] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(',', StringSplitOptions.RemoveEmptyEntries);
    int [] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToInt32(numS[i]);
    }
    return result;
}

int GetCountPositiveElements(int [] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if(item>0) count ++;
    }
    return count;
}