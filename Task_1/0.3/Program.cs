// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Ввести число");

string num = Console.ReadLine();
int a = int.Parse(num);

int b = a % 2;

if(b == 0)
{
    Console.WriteLine("Да"); 
}
else
{
    Console.WriteLine("Нет");
}