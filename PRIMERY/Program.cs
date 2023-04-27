// int[] num = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 3, 7};
// int[,] nums = {{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 0, 3, 7}};


// for (int i = 0; i < nums.GetLength(0); i++)
// {
//    for (int j = 0; j < nums.GetLength(1); j++)
//    {
//       Console.Write($"{nums[i, j]} ");
//    }
//    Console.WriteLine();
// }

// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int Prompt(string message)
// {
//   Console.Write(message);
//   string ReadInput = Console.ReadLine();
//   int result = int.Parse(ReadInput);
//   return result;
// }

// int[] CreateArray(int Length, int minValue, int maxValue)
// {
//   int[] array = new int[Length];
//   Random random = new Random();
//   for (int i = 0; i < Length; i++)
//   {
//     array[i] = random.Next(minValue, maxValue + 1);
//   }
//   return array;
// }

// int[] ReverseArray(int[] rearray)
// {
//   int x = 0;
//   int i = 0;
//   while (i < rearray.Length / 2)
//   {
//     x = rearray[i];
//     rearray[i] = rearray[rearray.Length - 1 - i];
//     rearray[rearray.Length - 1 - i] = x;
//     i++;
//   }
//   return rearray;
// }

// void PrintArray(int[] array)
// {
//   Console.Write("[");
//   for (int i = 0; i < array.Length - 1; i++)
//   {
//     Console.Write($"{array[i]}, ");
//   }
//   Console.Write($"{array[array.Length - 1]}");
//   Console.WriteLine("]");
// }

// int length = Prompt("Enter length ");
// int min = Prompt("Enter minimal count ");
// int max = Prompt("Enter maximum ");
// int[] massive = CreateArray(length, min, max);
// PrintArray(massive);
// massive = ReverseArray(massive);
// PrintArray(massive);


// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
//  решение Делим десятичное число на 2 и записываем остаток от деления.
// Результат деления вновь делим на 2 и опять записываем остаток.
// Повторяем операцию до тех пор пока результат деления не будет равен нулю.
// Запишем полученные остатки в обратном порядке и получим искомое число.

// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// string dvoichnoeChislo = "";

// while ( x > 0)
// {
// if ( x%2 == 0)
//    {
//    dvoichnoeChislo ="0" + dvoichnoeChislo;
   
//    }
// else 
//    {
//    dvoichnoeChislo ="1" + dvoichnoeChislo;
//    };
//    x = x/2;
// };
// Console.WriteLine(dvoichnoeChislo);


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());

// int[] massiv = new int[x];
// massiv[0] = 0;
// massiv[1] = 1;
// for (int i = 2; i < x; i++)
// {
//     massiv[i] = massiv[i - 1] + massiv[i - 2];
// }
// foreach (int i in massiv)
//     Console.Write(i + "__");



// void PrintArray (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// void FillArray (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1, 10);
//         }
//     }
// }

// int [,] matrix = new int [3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);
//-----------------------------------------------------------------

// Factorial

// double Factorial (int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }
//--------------------------------------------------------------------

// Фибоначчи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// int Fibonacci( int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2); 
// }

// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"{i}! {Fibonacci(i)}");
// }