Console.WriteLine("Введите число: ");
bool i = true;

while (i)
{
    int num = int.Parse(Console.ReadLine()!); 
    {
    if (num == 6 || num == 7)
    {
        Console.WriteLine($"День {num} является выходным");
        i = false; //не ищет следующий такой же элемент
    }
    else if (num <= 5 && num >= 1)
    {   Console.WriteLine($"{num} - это будний день");
        i = false;
    }
    else
        Console.WriteLine($"{num} - не является днем недели, введите число еще раз");
    }

}