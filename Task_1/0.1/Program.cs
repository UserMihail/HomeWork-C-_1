// Напишите программу которая принимет на вход
// три числа и выдает максимаьлное из этих чисел.

Console.WriteLine("Введите число");

int a = 44;
int b = 5;
int c = 78;

int max = a;

if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;

Console.Write("max= ");
Console.WriteLine(max);
