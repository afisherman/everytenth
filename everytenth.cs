for (int i = 1; i <= 200; i++) 
{
    int remainder = (i % 10);
    if (remainder == 0)
    {
        Console.WriteLine("Every 10th! : " + i);
    }
    else
    {
    Console.WriteLine("keep counting : " + i);
    };
};
