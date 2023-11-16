// Задача_01, Автотест
using System;

public class Answer
{
    public static void PrintMatrix(int[,] matrix)
    {
// Введите свое решение ниже
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}" + "\t");
        }
        Console.WriteLine();
    }

    }
    


    public static void SortRowsDescending(int[,] matrix)
    {
// Введите свое решение ниже
   {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}

    
    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,] {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                if (elements.Length != matrix.GetLength(1))
                {
                    Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
                    return;
                }
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        SortRowsDescending(matrix);

        Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
        PrintMatrix(matrix);
    }
}
// // Задача_01
// int Prompt(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int[,] CreateArray(int m, int n)
// {
//   int[,] array = new int[m, n];
//   return array;
// }

// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// int[,] FillArrayRandom(int[,] coll)
// {
//   for (int i = 0; i < coll.GetLength(0); i++)
//   {
//     for (int j = 0; j < coll.GetLength(1); j++)
//     {
//       coll[i, j] = new Random().Next(1, 10);
//     }
//   }
//   return coll;
// }

// int[,] SortLines(int[,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1) - 1; j++)
//     {
//       for (int k = 0; k < matr.GetLength(1) - 1; k++)
//       {
//         if (matr[i, k] < matr[i, k + 1])
//         {
//           (matr[i, k], matr[i, k + 1]) = (matr[i, k + 1], matr[i, k]);
//         }
//       }
//     }
//   }
//   return matr;
// }

// int[,] matr = CreateArray(Prompt("Введите количество строк: "), Prompt("Введите количество столбцов: "));
// matr = FillArrayRandom(matr);
// System.Console.WriteLine("Исходная матрица:");
// PrintArray(matr);
// Console.WriteLine();
// System.Console.WriteLine("Матрица с упорядоченными по убыванию строками:");
// PrintArray(SortLines(matr));