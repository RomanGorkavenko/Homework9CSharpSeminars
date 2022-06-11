int m = 4;
int n = 8;

System.Console.WriteLine(Summa(m, n));

int Summa(int firstNumber, int lastNumber)
{
    if (lastNumber >= firstNumber) return lastNumber + Summa(firstNumber, lastNumber - 1);
    return 0;  
}
