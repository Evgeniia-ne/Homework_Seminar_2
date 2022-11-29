Console.Clear();
Console.WriteLine("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
if (number == 6) Console.WriteLine ($"{number} -> да");
if (number == 7) Console.WriteLine ($"{number} -> да");
else Console.WriteLine ($"{number} -> нет");