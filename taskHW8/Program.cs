// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = N % 1;
temp = 0;


while(temp < N)
{
    temp = temp + 1;
    if(temp % 2 == 0)
    Console.Write($"{temp} ");
}
