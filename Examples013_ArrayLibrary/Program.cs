int[] array = new int[10]; // new int[10] обозначает что мы создаём новый массив в котором будет десять элементов
                           // место этой строчки кода не важно, она может стоять как перед методами void, так и после них
                           // это зависит от того возращает ли нам что то метод или нет, команда(return)
void FillArray(int[] collection)  // void метод - это метод который ничего не возращает, т.е. используется без команды return
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int cout = collection.Length;
    int index = 0;
    int position = -1; // мини хитрасть если ввести на проверку позицию(в строке 49) больше чем есть в массиве, 
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


FillArray(array);  // вызываем методы написаные выше Заполнение массива и Вывод(печать) данных 
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4); // но что если ввели большую позицию, чем есть в массиве 
Console.Write(pos);
