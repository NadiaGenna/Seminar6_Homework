// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
// От себя по-русски: (если k1 не равно k2, то прямые пересекаются в точке А (x; y) 
//и если b1 равно b2, то прямые пересекаются в точке (0; b), а если k1 равно k2, то прямые не пересекаются.)

Console.WriteLine("Введите значение точки b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение точки k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение точки b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение точки k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
CrossPoint(k1, b1, k2, b2);

void CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    if (k1 == k2) Console.Write("Заданные прямые не пересекаются.");
    else
        Console.Write($"Координаты точки пересечения заданных прямых: ({x}; {y})");
    if (b1 == b2)
    {
        Console.Write($"Координаты точки пересечения заданных прямых: ({0}; {b1})");
    }
}
