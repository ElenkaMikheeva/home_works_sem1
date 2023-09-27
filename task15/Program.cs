//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
{
    if (dayNum == 6 || dayNum == 7) 
    {
        Console.WriteLine("Этот день выходной.");
    }
    else if (dayNum < 1 || dayNum > 7) 
    {
        Console.WriteLine("Это не день недели.");
    }
    else Console.WriteLine("Этот день не выходной.");
}

