Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
bool i = true;

while (i)
{
    if (num > 99 && num < 1000)
    {
        int thirthDigit = num % 10;
        Console.WriteLine("Третья цифра: " + thirthDigit);
        i = false;
    }
    else if (num >= 1000)
        num = num / 10;
    else if (num <= 99)
    {
        Console.WriteLine("Третьей цифры нет.");
        i = false;
    }
}