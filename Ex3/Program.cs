/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/
Console.Clear();
Console.Write("Введите число ");
double n = double.Parse(Console.ReadLine());
int ind = 0;
double num = 0;
while(n > ind - 1)
{
    num = Math.Pow(ind,3);
    Console.Write(num + " ");
    ind++;
}
