// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Enter a value: ");
long Value = Convert.ToInt64(Console.ReadLine());
for (int i = 1; i <= Value; i++)
{
    double CubicValue = Math.Pow(i, 3);
    Console.Write($"{CubicValue}, ");
}