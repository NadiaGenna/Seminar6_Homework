//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел:");
int М = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите эти числа через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for (int i = 0; i < arr.Length; i++)
    if (arr[i] > 0)
    {
        count++;
    }
Console.WriteLine($"Количество элементов больше 0 ->: {count}");