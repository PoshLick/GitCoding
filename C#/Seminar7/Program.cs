// Сколько чисел больше 0 ввёл пользователь:

// int[] numbers = GetArrayFromString(Console.ReadLine());
// Console.WriteLine($"Количество чисел больше 0 ->  {GetCountPositiveElements(numbers)}");

// int[] GetArrayFromString(string stringArray)
// {
//     string[] numS = stringArray.Split(',', StringSplitOptions.RemoveEmptyEntries);
//     int [] result = new int[numS.Length];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = Convert.ToInt32(numS[i]);
//     }
//     return result;
// }

// int GetCountPositiveElements(int [] array)
// {
//     int count = 0;
//     foreach (int item in array)
//     {
//         if(item>0) count ++;
//     }
//     return count;
// }