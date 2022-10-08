//Задача 10: Напишите метод, который принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void Main()
{
  int secondnumber;
    Console.Write("Введите 3-х значное число:");
    int number = Convert.ToInt32(Console.ReadLine());

  if (number < 1000 && number != 000)
  {
   secondnumber = ((number % 100)- (number % 10)) / 10;
   Console.Write("вторая цифра трёхзначного числа = ");
   Console.WriteLine(secondnumber);
  }
  else
  {
    Console.Write("неправильно ввели число");
  }
}

Main();