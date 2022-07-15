
void OneNum(int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine($"{num1}, {num2} -> Числа кратные");
    }
    else
    {
        Console.WriteLine($"{num1}, {num2} -> Не кратные, остаток {num1%num2}");
    }
}

OneNum(16, 4);
OneNum(41, 4);