//Напишите программу, которая принимает на вход число (N) и выдаёт 
//таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

double ReadNumber(string usernumber)// делаю для закрепления информации
{
  Console.WriteLine(usernumber);
  double value = Convert.ToDouble(Console.ReadLine());
  return value;
}
double N = ReadNumber("Введите число N");
for (int i = 1; i <= N; i++)
{
    double qwadrat = Math.Pow(i, 3);
    Console.WriteLine(qwadrat);
}