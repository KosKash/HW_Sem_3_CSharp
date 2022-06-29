/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Решение универсально для любых чисел*/
Console.Clear();
Console.Write("Введите число ");
string num = (Console.ReadLine());
char[] msn = num.ToCharArray();
int i = msn.Length - 1;
int j = 0;
int half = msn.Length / 2;
int ostdel = msn.Length % 2;
int count = 1;


if (ostdel == 0)
{
    while (half != count)
    {
        if (msn[j] == msn[i])
        {
            j = j + 1;
            i = i - 1;
            count++;
        }
        if (msn[j] != msn[i])
        {
            System.Console.WriteLine("Число " + num + " не является палиндромом");
            break; //Не знал как решить, при условии что "число не полиндром" в консоли спамило это сообщение, скоре всего это связано с циклом "while"
        }

    }
    if (count == half)
    {
        Console.WriteLine("Число " + num + " это палиндром");
    }
}
if (ostdel == 1)
{
    while (half != count)
    {
        if (msn[j] == msn[i])
        {
            j = j + 1;
            i = i - 1;
            count++;
        }
        if (msn[j] != msn[i])
        {
            System.Console.WriteLine("Число " + num + " не является палиндромом");
            break; //Не знал как решить, при условии что число не полиндром в консоли спамило это сообщение, скоре всего это связано с циклом "while"
        }

    }
    if (count == half)
    {
        Console.WriteLine("Число " + num + " это палиндром");
    }
}