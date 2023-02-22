﻿int[] array = new int[10]; // new int[10] обозначает что мы создаём новый массив в котором будет десять элементов
                           // место этой строчки кода не важно, она может стоять как перед методами void, так и после них
                           // это зависит от того возращает ли нам что то метод или нет, команда(return)

void FillArray(int[] collection)  // void метод - это метод который ничего не возращает, т.е. используется без команды return
{
    int length = collection.Length; // переменная length присваивается значение длинны массива, а его длинна определяется в 1й строчке
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // заполняет массив рандомными числлами (слово Random отвечает за рандом, а слово Next за диапозон чисел)
        index++;                                      // Размер массива определяется с помощью кода в строчке 1
    }
}

void PrintArray(int[] col)     // То же самое что и в предыдущем метоже, только другое название переменных
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");  // Вывод значений массива поочерёдно
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int cout = collection.Length;
    int index = 0;
    int position = -1; // мини хитрасть если ввести на проверку позицию(в строке 49) больше чем есть в массиве, или её в массиве попросту не окажется
                      // то на выводе получим (-1) вместо нулевой позиции что покажет что данной позиции нет в данном массиве
    while (index < cout)
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

// Если хотите убрать магическое число ("4"-из строчки 54), то нужно вписате следующие команды
                                                         //Console.Write("Введите число ");
                                                        //int find = Convert.ToInt32(Console.ReadLine());
        // и тогда мы сами будем выбирать число которое хотим найти и узнать его индекс 

FillArray(array);  // вызываем методы написаные выше Заполнение массива и Вывод(печать) данных 
PrintArray(array); //array это имя массива(может быть и другим) из первой строчки
Console.WriteLine();

int pos = IndexOf(array, 4); // число 4(или любое другое) отсылает(связано) нас к переменной find
                             // но что если ввели большую позицию, чем есть в массиве , или данной позиции нет в массиве 
Console.Write(pos);