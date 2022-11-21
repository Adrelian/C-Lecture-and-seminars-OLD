// Плохой метод решения, стихийный

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 53;
// int b2 = 23;
// int c2 = 33;
// int a3 = 79;
// int b3 = 23;
// int c3 = 33;

// int max = a1;
// if (b1>max) max = b1;
// if (c1>max) max = c1;

// if (a2>max) max = a2;
// if (b2>max) max = b2;
// if (c2>max) max = c2;

// if (a3>max) max = a3;
// if (b3>max) max = b3;
// if (c3>max) max = c3;

// Console.WriteLine(max);

//Решение с помощью методов

int Max (int arg1, int arg2, int arg3)
{    
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int[] array = {946, 72, 63, 5, 639, 77, 81, 569, 1};

int max = Max
(
Max(array[0],
    array[1],
    array[2]),
Max(array[3],
    array[4],
    array[5]),
Max(array[6],
    array[7],
    array[8]));

Console.WriteLine(max);
