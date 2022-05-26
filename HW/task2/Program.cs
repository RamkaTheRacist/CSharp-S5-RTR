string[] Division(string text)
{
string result = String.Empty;
int size = text.Length;
int s = 0;
string[] array = new string[5];
    for(int j = 0; j < 5; j++)
    {
        array[j] = result;
        result = String.Empty;

    while(s < size)
    {
        for(int i = s; i < size; i++)   
        {
        if(text[i] == '(') continue;
        if(text[i] == ')') continue;
        if(text[i] == ' ') break;
        else {s++; result = result + $"{text[i]}";}
        }
    s++;
    break;
    }

    }
    return array;
}
string RemoveSymbols(string text)
{
string result = String.Empty;
int any = text.Length;
    for(int i = 0; i < any; i++)   
    {
        if(text[i] == '(') continue;
        if(text[i] == ')') continue;
        if(text[i] == ',') continue;
        if(text[i] == ' ') continue;
        else result = result + $"{text[i]}";
    }
    return result;
}
string FromStrArrToStr(string[] text)
{
    string text1 = string.Empty;
    for(int i = 0; i < text.Length; i++)
    {text1 = text1 + $"{text[i]} ";}
    return text1;
}
double[] FromStrToDoubArr(string text, double[] DoubArray)
{
    int count = 1;
    for(int c = 0; c < DoubArray.Length; c++)
    {
    string any = string.Empty;
    for(int i = count; i < text.Length; i++)
    {
    if(text[i] == ',') 
    {
    i++;
    count = i;

    break;
    }
    else if(text[i] == ' ') 
    {
    i++;
    count = i;

    break;
    }
    else
    {
    any = any + $"{text[i]}";
    }
    }
    double.TryParse(any, out double tmp);
    DoubArray[c] = tmp;
    }
    return DoubArray;
}
void Scaling(double[] array, double k)
{
    Console.Write($"Scaling in {k} times; New coordinates:");
    for(int i = 0; i < array.Length; i = i + 2)
    Console.Write($"({array[i]*k},{array[i+1]*k})");
}
/*Написать программу масштабирования фигуры
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"*/

Console.WriteLine("Write coordinates x1,y1 x2,y2 x3,y3 x4,y4.");
string InputData = Console.ReadLine();
Console.WriteLine("Which scaling?");
double scal = double.Parse(Console.ReadLine());
string[] text = Division(InputData);
double[] array = new double[8];
string text1 = FromStrArrToStr(text);
array = FromStrToDoubArr(text1, array);
Scaling(array, scal);
