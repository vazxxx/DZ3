Console.WriteLine("Введите 5-ое число");
int number = int.Parse(Console.ReadLine()!);

int number = Math.Abs(number);
if (10000 <= number && number <= 99999)
{
    int digit1 = number / 10000;
    int digit2 = number / 1000 % 10;
    int digit4 = number / 10 % 10;
    int digit5 = number % 10;

    if (digit1 == digit5 && digit2 == digit4)
    {
        Console.WriteLine("Число является полиндромом");
    }
else
    {
        Console.WriteLine("Number is a palindrom");
    }
}
else
{
    Console.WriteLine("Number is not a palindrom");
}