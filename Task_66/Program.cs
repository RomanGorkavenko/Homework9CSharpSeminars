Console.WriteLine("Чтобы найти сумму натуральных чисел от M до N:");
Console.Write("Введите натуральное число M: ");
string m = Console.ReadLine();

Console.Write("Введите натуральное число N: ");
string n = Console.ReadLine();

var numberM = ExceptionHandling(m);
var numberN = ExceptionHandling(n);

if (numberM.exception && numberN.exception && numberM.number >= 0 && numberN.number >= 0)
{
    System.Console.WriteLine($"Сумма = {Summa(numberM.number, numberN.number)}");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"{m}, {n} -> Некорректный ввод!");
}

int Summa(int firstNumber, int lastNumber)
{
    if (lastNumber > firstNumber) return (lastNumber + 1) + Summa(firstNumber, lastNumber - 1);
    if (firstNumber > lastNumber) return (firstNumber + 1) + Summa(firstNumber - 1, lastNumber);
    return 0;  
}

(bool exception, int number) ExceptionHandling(string number)
{
    bool yesInt = int.TryParse(number, out int d);
    if (!yesInt)
    {
        return (false, d);
    }
    return (true, d);
}
