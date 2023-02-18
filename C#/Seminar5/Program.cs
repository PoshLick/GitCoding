/* Создание и вывод массива: */

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

// int[] Array1 = CreateRandomArray(10, -10, 11);
// ShowArray(Array1);

// int positive = 0;
// int negative = 0;

// for (int i = 0; i < Array1.Length; i++)
// {
//     if (Array1[i] > 0)
//     {
//         positive += Array1[i];
//     }
//     else
//     {
//         negative += Array1[i];
//     }
// }

// Console.WriteLine($"Сумма позитивных чисел {positive} и сумма негативных чисел {negative}");


/* Задача 32: Замена элементов массива: положительные элементы замените на соответствующие отрицательные и наоборот. */

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

// void ReplaceArray(int[] ReplacedArray)
// {
//     for (int i=0; i<ReplacedArray.Length; i++)
//     {
//         if (ReplacedArray[i]>0)
//         {
//             ReplacedArray[i] = ReplacedArray[i]*(-1);
//         }
//         else 
//         {
//             ReplacedArray[i] = ReplacedArray[i]*(-1);
//         }
//     }
// }


// int[] Array1 = CreateRandomArray(10, -10, 10);
// ShowArray(Array1);
// ReplaceArray(Array1);
// ShowArray(Array1);

// Задача 33:  Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

// int[] Array1 = CreateRandomArray(10, -10, 10);
// ShowArray(Array1);

// Console.WriteLine("Введите число для поиска в массиве");
// int num = Convert.ToInt32(Console.ReadLine());

// int [] SrchForNum(int[] CreateRandomArray)
// {
//     for (int i=0; i < CreateRandomArray.Length; i++)
//     {
//         if (CreateRandomArray[i] == num)

//int sum += 1; sum здесь равно количеству итераций цикла, в которых найденное значение будет лежать в нужном диапазоне. Нужен вывод SUM.

//         Console.WriteLine($"Число {num} присутствует в массиве");
//         else if (CreateRandomArray[i] != num)
//         {
//             Console.WriteLine($"Число {num} отсутствует в массиве");
//         }
//     }
//     return CreateRandomArray;
// }



// SrchForNum(Array1);

/* Задача 35:  */

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

// void Diapazon(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//         sum += 1;
//     }
//     Console.WriteLine(sum);
// }

// int[] Array1 = CreateRandomArray(123, 0, 100);
// ShowArray(Array1);
// Diapazon(Array1);

// Задача 37 Не сделал сам, не понял, как сделать;

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

// void Multiplication(int [] array)
// {
//     for (int i=0; i <array.Length; i++)
//     {
        
//     }
// }



// int[] Array1 = CreateRandomArray(new Random().Next(1,10), 1, 10);
// ShowArray(Array1);


// Задача 37 из дискорда: 

// int[] GenerateArray(int length, int minNum, int maxNum)
// {
//     int[] arr = new int[length];
//     for (int i=0;i<arr.Length;i++)
//     {
//         arr[i] = new Random().Next(minNum, maxNum + 1);
//     }
//     return arr;
// }

// int[] CountProductOfArrayNumbers(int[] array)
// {
//     int resultLen = array.Length / 2;
//     if (array.Length %2 == 1)
//     {
//         resultLen++;
//     }
//     int[] result = new int[resultLen];
//     for (int i = 0;i<resultLen;i++)
//     {
//         if (array.Length %2 == 1 && i == resultLen-1)
//         {
//             result[i] = array[i];
//         }
//         else
//         {
//             result[i] = array[i] * array[array.Length - i -1];
//         }
//     }
//     return result;
// }

// int[] myArray = GenerateArray(5, -100, 100);
// Console.WriteLine($"Сгенерированный массив [{String.Join(", ", myArray)}]");
// Console.WriteLine($"Результирующий массив равен [{String.Join(", ", CountProductOfArrayNumbers(myArray))}]");



// Задача 34: 

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

// void EvenCount(int [] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] %2 == 0)
//         {
//             sum += 1;            
//         }
                    
//     }
//     Console.WriteLine($"Количество чётных чисел в массиве = {sum}");
    
// }

// int[] Array1 = CreateRandomArray(new Random().Next(5,10), 100, 999);
// ShowArray(Array1);
// EvenCount(Array1);

// Задача 36:

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

// void NumSum(int [] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i = i+2)
//     {
//         sum += array[i];           
//         Console.WriteLine($"{sum}");
//     }
//     Console.WriteLine($"Сумма чисел, стоящих на нечётной позиции = {sum}");
    
// }

// int[] Array1 = CreateRandomArray(new Random().Next(5,10), -10, 10);
// ShowArray(Array1);
// NumSum(Array1);

// Задача 38:

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray /*  */= new int[N]; //Размерность массива - new int [размер массива]
    for (int i = 0; i < N; i++) // i - индекс здесь является сразу и числом, до которого мы заполняем 
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void MaxMinDifference(int [] array)
{
    int max = 0;
    int min = 1000000000;
    for (int i = 0; i < array.Length; i++)
    {


        if (array[i] > max)
        {
           max = array[i];
        }

        else if (array[i] < min)
        {
            min = array [i];
        }


    }
        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine(max-min);

}

int[] Array1 = CreateRandomArray(new Random().Next(5,10), 1, 20);
ShowArray(Array1);
MaxMinDifference(Array1);

