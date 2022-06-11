

int n = 8;

Numbers(n);

void Numbers(int last)
{
    if (last == 0)
    {
        return;
    }
    Console.Write($"{last} ");
    Numbers(last - 1); 
}
