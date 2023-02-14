/*3. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.*/
Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine());
if (numA > numB) Console.WriteLine($"Число {numA} больше {numB}");
if (numA == numB)
Console.WriteLine($"Числа равны");
if (numA < numB) Console.WriteLine($"Число {numB} больше {numA}");