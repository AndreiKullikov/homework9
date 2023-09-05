// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// int startNum=num;

// if(startNum>0)
// {
// Console.WriteLine(PrintNumbers(startNum,num));
// }
// else
// {
// Console.WriteLine("0");
// }
// string PrintNumbers(int start, int end)
// {
//     if(start==1)
//     {
//         return start.ToString();
//     }
   
//     return (start+ " "+ PrintNumbers(start-1,end));
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.WriteLine("Введите начальное число: ");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите конечное число: ");
// int num2 = int.Parse(Console.ReadLine());

// if (num1 < num2)
// {
//     Console.WriteLine(PrintNumbers(num1,num2));
// }
// else
// {
//     Console.WriteLine("Ввод некорректный!");
// }

// int PrintNumbers(int start, int end)
// {
//     if(start==end)
//     {
//         return start;
//     }
//     return (start+ PrintNumbers(start+1,end));
// }



//  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//  m = 2, n = 3 -> A(m,n) = 9
//  m = 3, n = 2 -> A(m,n) = 29
//  */
 
// Console.Write("Введите число M");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());

// Function(m,n);

// void Function(int m, int n)
// {
//     Console.Write(Function(m, n)); 
// }


// int Function(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Function(m - 1, 1);
//     }
//     else
//     {
//         return (Function(m - 1, Function(m, n - 1)));
//     }
// }