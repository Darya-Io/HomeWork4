// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt(string msg)
{
    System.Console.Write($"{msg} : ");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int[] CreateArray(int x)
{
    int[] array = new int[x];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.WriteLine($"{array[j]}");
    }

    Console.Write($"{array}");
}
int x = Prompt("Size array");
int[] array = CreateArray(x);
ShowArray(array);



