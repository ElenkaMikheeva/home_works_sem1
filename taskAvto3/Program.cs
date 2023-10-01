using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
    if (N < 1)
{
Console.WriteLine("Число должно быть больше или равно 1");
return;
}

for (int i = 1; i <= N; i++)
{
int cube = i * i * i;
Console.WriteLine(cube);
}    
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}
