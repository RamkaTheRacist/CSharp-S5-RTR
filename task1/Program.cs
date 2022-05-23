//Выяснить являются ли три числа сторонами треугольника
// a+b>c и b+c>a и a+c>b
Console.WriteLine("First number?");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Second number?");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Third number?");
int number3 = int.Parse(Console.ReadLine());
if(number1 + number2 > number3 && number2 + number3 > number1 && number1 + number3 > number2) Console.WriteLine($"{number1} {number2} {number3} are sides of triangle");
else Console.WriteLine($"{number1} {number2} {number3} arent sides of triangle");