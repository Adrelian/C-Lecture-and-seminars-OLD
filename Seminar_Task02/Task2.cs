Console.WriteLine("Input first number");
int FirNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int SecNum = Convert.ToInt32(Console.ReadLine());

int Kvadrat = SecNum * SecNum;

if (Kvadrat == FirNum)
{
    Console.WriteLine($"{FirNum} is quad of {SecNum}");
}
else
{
    Console.WriteLine($"{FirNum} is not quad of {SecNum}");
}
