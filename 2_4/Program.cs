void GO(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine($"{num} Кратно");
    }
    else
    {
        Console.WriteLine($"{num} Не кратно");
    }
}
GO(161);