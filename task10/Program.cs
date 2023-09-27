//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string strNumb = Convert.ToString(threeDigitNumber);
Console.WriteLine("Вторая цифра этого числа: "+strNumb[1]);
