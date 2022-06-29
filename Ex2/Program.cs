/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/
Console.Clear();
Console.Write("Введите X первой точки ");
double xa = double.Parse(Console.ReadLine());
Console.Write("Введите Y первой точки ");
double ya = double.Parse(Console.ReadLine());
Console.Write("Введите Z первой точки ");
double za = double.Parse(Console.ReadLine());
Console.Write("Введите X второй точки ");
double xb = double.Parse(Console.ReadLine());
Console.Write("Введите Y второй точки ");
double yb = double.Parse(Console.ReadLine());
Console.Write("Введите Z второй точки ");
double zb = double.Parse(Console.ReadLine());
double res = (Math.Pow((xb-xa),2)) + (Math.Pow((yb-ya),2)) + (Math.Pow((zb-za),2));
double dist = Math.Sqrt(res);
System.Console.WriteLine("Расстояние между точками - " + dist);
