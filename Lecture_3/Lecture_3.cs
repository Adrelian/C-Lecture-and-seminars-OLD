// Метод Void

// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1();

//Метод 2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

//Метод 2.1

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method21(msg:"Текст", count: 4);
// Method21(count: 4, msg:"Текст");

// Метод 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// Console.WriteLine(Method3());

// Метод 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string  res = Method4(10, "text");
// Console.WriteLine(res);

// Цикл for, цикл со счётчиком.

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i< count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string  res = Method4(10, "text");
// Console.WriteLine(res);

//Задача 1. Вывод таблицы умножения на экран.

// for (int i = 2; i <= 10; i ++) // Таблица умножения начинается с 2
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// Задача 2. Заменить буквы - большие С заменить на маленькие с,
// Заменить маленькие к, на большие К.

string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде,"
+"вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] = r

// string Replays(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replays(text, ' ', '_');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replays(newText, 'к', 'К');
// Console.WriteLine(newText);

// Задача 3. Отсортировать массив от большего к меньшему.

int[] arr = {1, 4, 8, 3, 7, 9, 6, 98, 45, 3, 23, 8};

void printArray (int[] array)
{
    int count = array.Length;

    for (int i=0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i=0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j=i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        
        }
        int tempprary = array [i];
        array[i] = array[minPosition];
        array[minPosition] = tempprary;

    }
}

printArray(arr);
SelectionSort(arr);
printArray(arr);

// Задача 4. Упорядочивание в обратном порядке
