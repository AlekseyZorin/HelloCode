// Задача 1 Нахождение факториала с помощью рекурсии

// int Factorial(int n)
// {
//     // 1! == 1 и 0! == 1 (факториал 1 и 0 равны еденицы(1))
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// // Console.WriteLine(Factorial(3)); // 3! -> 1*2*3=6

// for (int i = 1; i < 40; i++) // вывод всех факториалов до 39(если хотим до 40 надо ставить <=)
// // сам счёт начинается с 1, т.е i = 1 , на 0 умножать нельзя
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}"); 
// }
// в следсвии чего в консоли будет выводится числа с минусов что связано с переполнением типа int

// одно из решений данной проблемы это перенозначить тип данных из int в double для возрашаемого результата
// double Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// for (int i = 1; i < 40; i++) 
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}"); 
// }


// Задача 2 числа фибоначи с помощью рекурсии
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// double Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"f{i}) = {Fibonacci(i)}");
// } 


