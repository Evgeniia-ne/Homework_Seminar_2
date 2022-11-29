// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Clear();
Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

if (number<100)  Console.Write($"{number} -> третьей цифры нет");

else
{
    if (number > 999)
        while (number > 999) number = number/10;
     Console.Write($"Третья цифра числа: {number%10}");   
     }