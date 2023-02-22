// Задача 18: Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти");
int usernumber = Convert.ToInt32(Console.ReadLine());

if (usernumber==1)
{
  Console.WriteLine("x < 0 и y > 0");
}
  else if(usernumber==2)
  {
  Console.WriteLine("x < 0 и y > 0");
  }
  else if(usernumber==3)
  {
  Console.WriteLine("x < 0 и y < 0");
  }
  else if(usernumber==4)
  {
  Console.WriteLine("x > 0 и y < 0");
  }
else
{
Console.WriteLine("Неверно введен номер четверти");
}