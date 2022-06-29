// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

int FindSecondDigit(int num)

{
      int d = num / 10;
      while( d > 10)
      {
            d = d -10;
      }

        return d;
}

Console.Write("Введите трёхзначное число ->  ");
int n = Convert.ToInt32(Console.ReadLine());
int second = FindSecondDigit(n);
Console.WriteLine("Вторая цифра -> " + second); 

/*Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
*/