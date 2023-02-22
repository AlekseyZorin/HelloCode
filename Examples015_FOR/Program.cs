// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++) // Цикл FOR заключает в себя иницилизация счётчика(i=count), далее идёт проверка условия(i<count),
//     {                             //  и в конце идёт инкремент(увелечение счётчика i++)
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(4, "Hello");
// Console.WriteLine(res);

// Задача 1: Вывод таблицы уможения с 2х

// for (int i = 2; i <= 10; i++) // обозначение количества столбцов 
// {
//     for (int j = 2; j <= 10; j++) // обозначения количесва строк внутри стобца
//     {
//         Console.WriteLine($"{i}*{j} = {i * j}");
//     }
//     Console.WriteLine(); // искуственный разрыв пустая сторока вывода
// }



// Задача 2: Редактирование текста 
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы "к" заменить большими "К", 
// а маленькие "а" заменить большими "А".

// string text = "- Я думаю, - сказал князь, улыбаясь, -что, "
//               + "ежели бы вас послали вместо нашего милого Винценгероде,"
//              + "вы бы взяли приступом согласие прусского короля. "
//              + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"  //  у нас есть какая то строка каждый её символ это какой то индекс(самый первый символ это 0)
//             012345  // наши индексы 
// s[3] - r           // чтобы "вытащить" определенный символ, придаём переменной s в квадратных скобках индекс этого символа, и тогда он присвоится данной переменной

// тип данных char - это тип хранит только один символ , в отличие от типа string который может хранить в себе целые слова 
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length; // вводим переменную length которой присваиваем значение text.Length(показывает количество символов в строке), в нашем примере qwerty это было бы 6
//     for(int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}"; // если текущий символ text[i] совпал == с тем символом который мы хотим заменить oldValue 
//                                                         //то в result мы кладём новое значение в виде строки + $"{newValue}" и всё это присваиваем переменной result
//         else result = result + $"{text[i]}"; // если совпадений не обнаруженно то в result добавляем текущий символ который и был изночально $"{text[i]}" и всё это присваиваем переменной result

//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|' ); // Replace заменяет символы в нашем тексту , в данном случае пробелы ' ' , чёрточками '|'
// Console.WriteLine(newText);
// Console.WriteLine(); // просто пустая строка для разделения разных этапов
// newText = Replace(newText, 'к', 'К'); // повторно заменяет но уже новые символы , и уже на отредактированном тексте
// Console.WriteLine(newText); 
// Console.WriteLine();
// newText = Replace(newText, 'а', 'А');
// Console.WriteLine(newText); 



// Задача 3: отсортировать массив от наименьшего к наибольшему

// int[] arr = { 5, 5, 4, 3, 2, 6, 7, 1, 4};  // задаем массив

// void PrintArray(int[] array)  // метод для вывода нашего массива
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array) // метод который упорядочивает наш массив
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         // если мы начинаем позицию поиска максимального от индекса i + 1 , где i меняется до максимального значения позиции нашего массива , то мы должны искуственно в строке 84, и тогда получится что ровно это i+1 даст общее количество элементов
//         for (int j = i + 1; j < array.Length; j++) // j = i + 1 -это следущая позиция по порядку, j < array.Length идём до последнего элемента массива
//         {   // ищем минимальный элемент
//             if (array[j] < array[minPosition]) minPosition = j; // смотрим текущий array[j] если он меньше того элемнта который мы сравниваем то сохроняем его
//         }


//         // для того чтобы поменять значение нашей минимальной позиции с той позицией которую мы только что нашли(т.е. передвинуть её на шаг вперёд)
//         int temporary = array[i];        // мы создаём переменную temporary и присваиваем ей нашу рабочию(нынешнию) позицию array[i], 
//         array[i] = array[minPosition];   // затем в нашу нынешнию позицию перезаписываем тем элементом который будет найден в процессе кода array[minPosition]  
//         array[minPosition] = temporary; // и затем переписываем данный элемент и присваиваем ему значение temporary 
//                                         // т.е. по сути меняем их местами 

//     }
// }

// PrintArray(arr); // сначало вызываем наш первоночальный массив на вывод

// SelectionSort(arr); // затем производим действия переспраделения массива
// PrintArray(arr); // затем заново вызываем но уже распределнный массив


// Задача 3: отсортировать массив от наибольшего к наименьшему

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 4 };

void PrintArray(int[] array)  // метод для вывода нашего массива
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array) // метод который упорядочивает наш массив
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i]; 
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

