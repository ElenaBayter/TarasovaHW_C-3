// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Write a number N: ");
int N = int.Parse(Console.ReadLine());

int a = N / 10000 % 10;
int b = N % 10;
int c = N / 1000 % 10;
int d = N / 10 % 10;

if ((a == b) && (c == d))
{
    Console.WriteLine("Your number is polindrome");
}
else
{
    Console.WriteLine("Sorry, your number is NOT polindrome");
}