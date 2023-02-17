
// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = N % 2;


    if(temp % 2 == 0)
{
       Console.Write("{Четное} ");
}
    else 
{
    Console.Write("{не Четное} "); 
}
