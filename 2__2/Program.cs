int Takenum1(int num)
{
    if (num % 10 > num / 10)
    {
        return num % 10;
    }
    else
        return num / 10;
}
int SecondNumber = new Random().Next(10, 100);
Console.WriteLine (SecondNumber);
Console.WriteLine (Takenum1(SecondNumber));
