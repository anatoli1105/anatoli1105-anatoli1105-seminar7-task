//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.



Console.Write("введите количество элементов  ");
string QuantityElenent = Console.ReadLine();
int strQuantityElenent =int.Parse(QuantityElenent);
int [] array = new int[strQuantityElenent];
Console.WriteLine();
int Sum(int[] array)
{
    int count = 0;
    for(int i = 0;i < array.Length;i++)
    {
        Console.Write($"введите число {i + 1}  -> ");
        array[i] = int.Parse(Console.ReadLine());
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
Console.Write($"\nчисел больше 0   -> {Sum(array)}");
