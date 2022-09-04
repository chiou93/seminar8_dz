// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7


class Program
{
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("введите количество строк m: ");
    int m= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество элементов массива в строке n: ");
    int n= Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    Random myRandom = new Random();
    Console.WriteLine(" ");
    for (int i=0; i<m; i++)
    {
      for(int j=0; j<n; j++)
      {
        array[i, j] = myRandom.Next(0, 10+n);
        Console.Write("{0}\t", array [i,j]);
      }
      Console.WriteLine(" ");
    }
    int result =1;
    int temp1=0, temp2=0;
    for(int i=0; i<m; i++)
    {
      for(int j=0; j<n; j++)
      {
        if(i==0)
        {
          temp2+= array[i,j];
          temp1=temp2;
        }
        else{ temp2+= array[i,j];}
      }
      if(temp1>temp2)
      {
        result=i+1;
        temp1=temp2;
        temp2=0;
      }
      temp2=0;
    }
  }
}



// Console.WriteLine("введите размер массива");
// int massVol = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[massVol, massVol];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int minsum = Int32.MaxValue;
// int indexLine = 0;

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         sum = sum + numbers[i, j];        
//     }
//     if (sum < minsum)
//     {
//         minsum = sum;
//         indexLine++;
//     }
// }

// Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }