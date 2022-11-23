// Задать новый массив строк состоящий из элементов, длинна которых <=3, из имеющегося.
//метод печати массива
void PrintArray(string[] array)
{
    foreach (string element in array)
    {
        Console.Write($"{element} ");
    }
    Console.WriteLine();
}
//метод копирования массива
string[] NewArray(string[] array, int length)
{
    string[] arr = new string[length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[j] = array[i];
            j++;
        }
    }
    return arr;
}

string[] array = new string[] { "hellow", "hi", "123", "sdfsdfsdf", "sdf", "uyuir", "12322", "321" };

Console.Write("Начальный массив: ");
PrintArray(array);
Console.WriteLine();
//узнаем количество элементов подходящих под задачу
int length = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) length++;
}

if (length > 0)
{
    Console.Write("новый массив: ");
    string[] arr = NewArray(array, length);
    PrintArray(arr);
}
else Console.WriteLine("Строки размером в 3 символа или меньше отсутствуют в заданном массиве");