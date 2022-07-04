// // Вид 1, ничего не принимает и ничего не возвращает.
// // здесь мы можем написать авторство и вызывать его потом
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }

// // Вызываем метод , обязательно склбочки.
// Method1();






// Вид 2
// принимает аргумент, но не возвращает
// в этом примере мы принимаем аргумент строку
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // вызов метода , имя метода плюс содержание строки которое хотим рапечатать
// Method2("Текст сообщения");
// // msg - мы указываем какому аргументу мы что присваиваем
// Method2(msg: "Текст");


// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//     Console.WriteLine(msg);
//     i++;
//     }
// }
// Method21("Текст", 4);
// // можно явно указывать наименование аргумента, тогда можно не попорядку
// Method21(count: 4, msg: "Текст новый текст");



// вид 3 возвращают но не принимают
// обязательно указать тип данных которые мы ожидаем получить в этом примере int
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// // вызов метода
// int year = Method3();
// Console.WriteLine(year);




// Вид 4 принимают и возвращают
// string - мы возвращаем
// string Method4(int count, string text) 
// {
//     int i = 0;
//     string result = String.Empty;     //"" - означает пустая строка, но лучше так 
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }  
//     return result;
// }
// // Для начала нам надо создать переменную в которой у нас будет применяться метод, в данном случае строка string
// string res = Method4(10, "a");
// Console.WriteLine(res);


// дублируем метод 4 для того чтобы воспользоваться циклом for
// string Method4(int count, string text) 
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }     
//     return result;
// }
// // Для начала нам надо создать переменную в которой у нас будет применяться метод, в данном случае строка string
// string res = Method4(10, "a");
// Console.WriteLine(res);


// встроенные циклы
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();

// }




// Задача
// =======Работа с текстом
// Дан текст. В тексте нужно все пробелы заменит черточками,
// маленькие буквы "к" заменить большими "К"
// а большие "С" заменить маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";


// // string s = "qwerty"
// //             012345
// // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);

// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

// Console.WriteLine();

// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);


// Отсортировать массив методом выборки
// находим минимальный элемент в неотсортировонной части массива и ставим его вначало

int[] arr = { 1, 5, 7, 3, 2, 6, 7, 1, 1 };

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
            if (array[j] < array[minPosition]) minPosition = j;
        }


        int temprorary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temprorary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);