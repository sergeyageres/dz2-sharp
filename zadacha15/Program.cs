//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

void MyMetod(int d)
{
    int day = d;

    if (d > 0 && d < 8)
    {
        if (d == 6 || d == 7)
        {
            Console.Write("Да, сегодня выходной");
        }
        else
        {
            Console.Write("Нет, сегодня не выходной");
        }
    }
    else
    {
        Console.Write("Неправильно ввели день недели!");
    }
}
Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
MyMetod(day);