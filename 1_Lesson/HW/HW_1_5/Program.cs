// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Enter a three-digit number");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(num % 10);