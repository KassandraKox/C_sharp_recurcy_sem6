// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//Рекомендую учесть три возможных случая расположения двух прямых.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//Console.WriteLine("Введи координату b1");
double b1 = 2; //Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введи координату k1");
double k1 = 5; //Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введи координату b2");
double b2 = 2; //Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введи координату k2");
double k2 = 5; //Convert.ToInt32(Console.ReadLine());

double x;
double y;
x = (b2-b1) / (k1-k2);
y = (k1 * x + b1);

Console.WriteLine("(" + x + ";" + y + ")");