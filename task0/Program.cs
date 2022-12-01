// See https://aka.ms/new-console-template for more information
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine()!);
int res = number*number;
Console.WriteLine("квадрат числа " +number);
Console.WriteLine("будет " +res);