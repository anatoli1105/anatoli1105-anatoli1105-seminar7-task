//Задача 2. Напишите программу, которая найдёт 
 //точку пересечения двух прямых, заданных уравнениями
 //y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
   //задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Promt(string messege)
{
    Console.Write(messege);
    string strN = Console.ReadLine();
    double N =double.Parse(strN);
    return N;
}

double k1 = Promt("введите  k1 ->");
double k2 = Promt("введите  k2 ->");
double b1 = Promt("введите  b1 ->");
double b2 = Promt("введите  b2 ->");
double x = (b2 - b1)/(k1 - k2);
if(k1 == k2 &&  b1 != b2) Console.Write("линии паралельны");
if(k1 == k2 && b1 == b2) Console.Write("линии совпадают");

if(k1 != k2)
Console.Write($"точка пересечения двух прямых  ->( {k1 * x + b1} ,{k2 * x + b2})") ;