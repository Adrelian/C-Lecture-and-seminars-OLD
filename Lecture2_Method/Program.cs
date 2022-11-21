int[] array = { 11, 1, 43, 42, 56, 16, 57, 38, 19, 38 };

int  n = array.Length;
int find = 38;

int index = 0;
 while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"Index = {index}");
        break;
    }
    index++;
}