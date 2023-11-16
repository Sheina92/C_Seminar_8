// Задача_01
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[,] CreateArray(int m, int n)
{
  int[,] array = new int[m, n];
  return array;
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}

int[,] FillArrayRandom(int[,] coll)
{
  for (int i = 0; i < coll.GetLength(0); i++)
  {
    for (int j = 0; j < coll.GetLength(1); j++)
    {
      coll[i, j] = new Random().Next(1, 10);
    }
  }
  return coll;
}

int[,] SortLines(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1) - 1; j++)
    {
      for (int k = 0; k < matr.GetLength(1) - 1; k++)
      {
        if (matr[i, k] < matr[i, k + 1])
        {
          (matr[i, k], matr[i, k + 1]) = (matr[i, k + 1], matr[i, k]);
        }
      }
    }
  }
  return matr;
}

int[,] matr = CreateArray(Prompt("Введите количество строк: "), Prompt("Введите количество столбцов: "));
matr = FillArrayRandom(matr);
System.Console.WriteLine("Исходная матрица:");
PrintArray(matr);
Console.WriteLine();
System.Console.WriteLine("Матрица с упорядоченными по убыванию строками:");
PrintArray(SortLines(matr));