/*2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.*/
Console.Write("Введите числа A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите числа B: ");
int numB = int.Parse(Console.ReadLine());
if (numA * numA == numB)
Console.WriteLine($"Число {numB} является квадратом {numA}");
else
Console.WriteLine($"Число {numB} не является квадратом {numA}");