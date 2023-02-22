//Задача 20: Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,10
//A (7,-5); B (1,-1) -> 7,21

//AB = √(xb - xa)2 + (yb - ya)2

Console.WriteLine("Введите значение х для точки a");
double xa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение y для точки a");
double ya = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение х для точки b");
double xb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение y для точки b");
double yb = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt(Math.Pow (xb - xa, 2) + Math.Pow (yb - ya, 2));

Console.Write(c);