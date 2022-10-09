//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

void MyMetod()
{
    int day;

    if (day > 7 && day < 1)
    {
        Console.Write("Неправильно ввели день недели!");
    }

    if (day == 6 && day == 7)
    {
        Console.Write("Да, сегодня выходной");
    }

    else
    {
        Console.Write("Нет, сегодня не выходной");
    }

}
Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
MyMetod();