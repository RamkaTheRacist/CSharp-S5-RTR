//Показать числа Фибоначчи меньше заданного числа N
//F1 - F2 = FN
//0 1 1 2 3 ....
Console.WriteLine("Number?");
int number = int.Parse(Console.ReadLine());
int F1 = 0;
int F2 = 1;
int F = 1;
int count = 0;
if(number == 0) Console.Write("0");
else if(number == 1) Console.Write("1");
else
{
    while(count < number)   //F instead of count
    {
    Console.Write($"{F} ");
    F = F1 + F2;
    F1 = F2;
    F2 = F;
    count++;
    }
}
