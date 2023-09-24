// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int evenNum = 2;

if(num > 1)
{
    while(evenNum <= num)
    {
        Console.Write(evenNum + " ");
        evenNum = evenNum + 2;
    }
}
