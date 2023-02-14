/*5. Напишите программу, которая принимает наи вход три числа и выдает максимальное из этих чисел.*/
Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine());
Console.Write("Введите число C: ");
int numC = int.Parse(Console.ReadLine());
int max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC;
Console.WriteLine($"Максимальное число из {numA} {numB} {numC} является {max}");