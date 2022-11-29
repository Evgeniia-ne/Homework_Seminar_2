//Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.Clear();
int number =  int.Parse(Console.ReadLine());
Console.WriteLine("Введите трехзначное число: ");

int second = number/10 % 10;
Console.Write($"{number} -> {second}");