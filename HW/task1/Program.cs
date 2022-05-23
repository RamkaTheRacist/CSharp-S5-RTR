//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("b1?");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("b2?");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("k1?");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("k2?");
double k2 = double.Parse(Console.ReadLine());
double x = (b1 - b2) / (k2 - k1);
double y = (k2 * b1 - k1 * b2) / (k2 - k1);
//double y = k1 * ((b1 - b2) / (k2 - k1)) + b1;

Console.WriteLine($"x = {x} and y = {y}");

