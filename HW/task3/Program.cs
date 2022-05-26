void FillArrayRandom(double[] array)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = new Random().Next(0, 1000);
        index++;
    }
}
void FillArray(double[] array)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = double.Parse(Console.ReadLine());
        index++;
    }
}
double[] CopyArray (double[] array1, double[] array2)
{
    double tmp = 0;
    for(int i = 0; i < array1.Length; i++)
    {
        tmp = array1[i];
        array2[i] = tmp;
    }
    return array2;
}
void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
}
//Написать программу копирования массива
Console.WriteLine("Which size of array?");
int choose = int.Parse(Console.ReadLine());
Console.WriteLine("Random array?");
string choose2 = Console.ReadLine();
double[] array1 = new double[choose];
double[] array2 = new double[array1.Length];
if(choose2.ToLower() == "random" || choose2.ToLower() == "yes" || choose2.ToLower() == "ye" || choose2.ToLower() == "yea" || choose2.ToLower() == "yeap")
{
FillArrayRandom(array1);
CopyArray(array1, array2);
}
else if(choose2.ToLower() == "no")
{
FillArray(array1);
CopyArray(array1, array2);
}
else Console.WriteLine("-_-");

Console.WriteLine("Show?");
string choose3 = Console.ReadLine();
if(choose3.ToLower() == "no") Console.WriteLine("Ok");
else if(choose2.ToLower() == "yes" || choose2.ToLower() == "ye" || choose2.ToLower() == "yea" || choose2.ToLower() == "yeap")
{
Console.Write("Your array:");
PrintArray(array1);
Console.WriteLine();
Console.Write("Copied array:");
PrintArray(array2);
}
else Console.WriteLine("????");