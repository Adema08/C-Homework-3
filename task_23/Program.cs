// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Сделала возможность вводить возводимую степень
System.Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter a degree: ");
int degree = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Degrees: ");
for (int i = 1; i <= n; i++)
{
    System.Console.Write(Math.Pow(i, degree) + " ");
}