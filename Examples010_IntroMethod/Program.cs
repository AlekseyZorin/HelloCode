// //Примитивный способ нахождения максимального числа:

// int a1 = 15;      // Можно сделать запись в такой форме
// int b1 = 21;      //int a1 = 15, b1 = 21, c1 = 39, a2 = 12, b2 = 23, c2 = 33, a3 = 13, b3 = 23, c3 = 33;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 33;

// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

// Console.WriteLine(max);

// Решение с помощью функции(метода):

int Max(int arg1, int arg2, int arg3)  // Создаём функцию Max(и т.к.она int, то и в скобках аргументы тоже будут int)
{                                      // Создаём внутреннюю переменную result где будет храниться
    int result = arg1;                 // значение первого максимального аргумента arg1
    if (arg2 > result) result = arg2;  // Затем создает несколько ветвений, которыми определяем 
    if (arg3 > result) result = arg3;  // максимальное значение среди всех arg
    return result;                     // И в конце наша функция возращает (return) result
}
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);      // Так же данный строчки кода можно записать следующим образом
int max3 = Max(a3, b3, c3);      // int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
int max = Max(max1, max2, max3);

Console.WriteLine(max);