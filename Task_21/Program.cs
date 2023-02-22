// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//d=sqrt(x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2)

double ReadNumber(string usernumber)
{
  Console.WriteLine(usernumber);
  double value = Convert.ToDouble(Console.ReadLine());
  return value;
}
double xa = ReadNumber("Введите значениее для точки a");
double уa = ReadNumber("Введите значениее для точки a");
double za = ReadNumber("Введите значениее для точки a");
double xb = ReadNumber("Введите значениее для точки b");
double уb = ReadNumber("Введите значениее для точки b");
double zb = ReadNumber("Введите значениее для точки b");

double c = Math.Sqrt(Math.Pow (xb - xa, 2) + Math.Pow (уb - уa, 2) + Math.Pow (zb - za, 2));

Console.WriteLine($"{c:f2}");
