//Задача 13: Напишите метод, который выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Main()
{
    int secondnumber;
    Console.Write("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 99)
    {
        secondnumber = (number % 1000) / 100;
        Console.Write("Третья цифра трёхзначного числа = ");
        Console.WriteLine(secondnumber);
    }

    else
    {
        Console.Write("Третьей цифры нет");
    }
}

Main();