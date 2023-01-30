/* Методы бывают разные:
1. Ничего не принимает и ничего не возвращает
Пример:
 */

/* void */ /* так образовывается метод */ /* Method1() */
/* {
   Console.WriteLine("Автор: Тимофей *PoshLick* Поличук "); //тело метода
} */
/*  Method1(); */ //вызов метода */

/*  Метод 2: Ничего не возвращают, но могут принимать аргументы: */
/* void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2("Текст", 3); */
/* 
Метод 3: Что-то возвращает, но ничего не принимает; */
/* int Method3()
{
    return DateTime.Now.Hour;
}

int year = Method3();
Console.WriteLine(year);
 */

/*  Метод 4: Что-то принимают и что-то возвращают: */
/* string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
String res = Method4(10, "wasd");
Console.WriteLine(res); */

/* Пример цикла через "for";
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
 */

/* Обработка текста, замена символов в тексте:


string text = "к чему бы ещё докопаться, карл?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;

}

string newText = Replace(text, 'к', 'К');
Console.WriteLine();
Console.WriteLine(newText);
Console.WriteLine(); */

/* Сортировка массива: */
/* int[] arr = { 1, 5, 6, 7, 23, 54, 111, 7, 0, 0, 3, 4, 6, 7 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
Console.WriteLine("Неупорядоченный массив");
PrintArray(arr);
Console.WriteLine();
SelectionSort(arr);
Console.WriteLine("Упорядоченный массив");
PrintArray(arr); */

/* int[] Elements = new int[10];
int sum = 0;
int index = 0;
int current = 0;
int length = Elements.Length;

while (index < length)
{
    current = Random.Shared.Next(1, 30);
    Elements[index] = current;
    Console.WriteLine(Elements[index]);

    if (current >= 10 && current <= 99)
    {
        sum = sum + current;
    }
    index++;
}

Console.WriteLine(sum); */



