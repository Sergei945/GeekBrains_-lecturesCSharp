// Вид 1 - Ничего не принимают и ничего не возвращают

// void Method1() 
// {
//     Console.WriteLine("Автор ...");
// } 
// Method1();

// // Вид 2 - что-то принимает, ничего не возвращает
// void Method2(string msg) 
// {
//     Console.WriteLine(msg);
// }
// Method2(msg:"text msg");



// // Вид 3 - ничего не принимают, что-то возвращают
// int Method3() 
// {
//     return DateTime.Now.Year;
// }

// Console.Write(Method3());



// Вид 4 - что-то принимают, что-то возвращают

// string Method4(int count, string text) {
//     int i = 0;
//     string result = String.Empty;

//     while(i < count) 
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string Method4(int count, string text) {
//     string result = String.Empty;

//     for (int i = 0; i < count; i++)
//     {
//         result += text;
//     }
//     return result;
// }
// string res = Method4(10, "z ");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// Дан текст. В тексте нужно все пробелы заменить чёрточками, 
// маленькие буквы "к" заменить большими "К", а большие "С" заменить на маленькие "с"

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом Согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty";
// //             012345
// // s[2] // r

// string Replace(string text, char oldValue, char newValue) 
// {
//     string result = String.Empty;
//     int length = text.Length;

//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) {
//             result += $"{newValue}";
//         } else {
//             result += $"{text[i]}";
//         }
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine();
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine();
// Console.WriteLine(newText);


// сортировка массивов

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array) 
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) 
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);