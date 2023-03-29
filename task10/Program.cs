Console.WriteLine("Введите трехзначное число: ");
bool i = true;
int secondDigit = -1;

while (i)
{
    int num = int.Parse(Console.ReadLine()!);
    {
    if (num > 99 && num < 1000)
    {
        int lastDigit = num % 10;
        int firstDigit = num / 100;
        secondDigit = (num - (100 * firstDigit + lastDigit)) / 10;
        i = false;
    }
    else
        Console.WriteLine("Введите трехзначное число: ");
    }
}

Console.WriteLine("Вторая цифра: " + secondDigit);

