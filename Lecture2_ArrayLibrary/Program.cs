void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }

}

void PrintArray(int[] col)

{
    int count = col.Length;
    int positin = 0;

    while(positin < count)
    {
        Console.WriteLine(col[positin]);
        positin++;
    }
}

int indexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int [10];

FillArray(array);
array[4]=4;
array[6]=4;

PrintArray(array);

Console.WriteLine();

int pos = indexOf(array, 66);
Console.WriteLine($"Your positin = {pos}");


