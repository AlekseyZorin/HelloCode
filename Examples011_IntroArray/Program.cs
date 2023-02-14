int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;                     
}
    //index = 0, 1, 2, 3, 4, 5, 6, 7, 8 (начинается с нуля, следовательно если в массиве 9 элементов 
int[] array ={11,21,31,41,15,61,17,18,19};  // индекс первого элемента будет равен 0,а последнего 8) 
//array[0] = 12;                             // меняет значение первого(нулевого индекса) массива на указанное
//Console.WriteLine(array[0]);              // Выводит число под указанном индексом массива 

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
    );

Console.WriteLine(result);