// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 2)
{
    System.Console.WriteLine("Число должно быть больше  1!");
    return;
}

for (int i = 2; i <= number; i+=2)
{
    System.Console.Write($"{i} ");
}
