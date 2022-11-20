Console.WriteLine("Input first number");
int Num = Convert.ToInt32(Console.ReadLine());

int Start = Num * (-1);

while (Start <= Num)
{
    Console.WriteLine(Start);
    Start = Start + 1;
}
