// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int num = 0;
int rev = 0;
int sum = 0;
int t = 0;
Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());

if (num > 9999 && num < 100000)
{
for(t = num; num != 0; num = num / 10)
{
    rev = num % 10;
    sum = sum * 10 + rev;
}
if(t == sum)
Console.Write($"{t} является палиндромом");
else
Console.Write($"{t} не является палиндромом.");
} else
Console.Write("Введите пятизначное число!");