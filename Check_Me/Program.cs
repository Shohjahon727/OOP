using System;
using System.Collections.Generic;
using System.Linq;


//        Console.Write("M (Qatoralar soni):");
//        int M = int.Parse(Console.ReadLine());
//        Console.Write("N (ustunlar soni): ");
//        int N = int.Parse(Console.ReadLine());
//        //a) ixtiyoriy sonlar bilan matritsani toldirish 
//        int[,] matrix = new int[M, N];
//        Random rand = new Random();

//        for (int i = 0; i < M; i++)
//        {
//            for (int j = 0; j < N; j++)
//            {
//                matrix[i, j] = rand.Next(1, 10); 
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }

//        // b) Matritsani saralash)
//        List<int> list = new List<int>();
//        for (int i = 0; i < M; i++)
//        {
//           for (int j = 0; j < N; j++)
//             {
//               list.Add(matrix[i, j]);
//            }
//        }

//        list.Sort();
//        Console.WriteLine("\nSaralangan matritsa:");
//        int index = 0;
//        for (int i = 0; i < M; i++)
//        {
//            for (int j = 0; j < N; j++)
//            {
//                matrix[i, j] = list[index++];
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }

//        // c) Matritsada toq elementlar summasini topish
//        int sum = 0;
//        for (int i = 0; i < M; i++)
//        {
//            for (int j = 0; j < N; j++)
//            {
//                if (matrix[i, j] % 2 != 0) // Agar son toq bo'lsa
//                {
//                    sum += matrix[i, j];
//                }
//            }
//        }
//        Console.WriteLine($"\nMatritsadagi toq elementlar yig'indisi: {sum}");





//// d) Matritsada takrorlangan elementlarning indekslarini chiqarish
//Dictionary<int, List<(int, int)>> elementIndices = new Dictionary<int, List<(int, int)>>();

//for (int i = 0; i < M; i++)
//{
//    for (int j = 0; j < N; j++)
//    {
//        int value = matrix[i, j];
//        if (!elementIndices.ContainsKey(value))
//        {
//            elementIndices[value] = new List<(int, int)>();
//        }
//        elementIndices[value].Add((i, j));
//    }
//}

//Console.WriteLine("\nTakrorlangan elementlar va ularning indekslari:");
//foreach (var y in elementIndices)
//{
//    if (y.Value.Count > 1)
//    {
//        Console.WriteLine($"Element {y.Key}:");
//        foreach (var x in y.Value)
//        {
//            Console.WriteLine($"  Indeks: ({x.Item1}, {x.Item2})");
//        }
//    }
//}









using System;
using System.Linq;

public class RandomMatrix
{
    private int[,] matrix;
    private int M;
    private int N;

    public RandomMatrix(int M, int N)
    {
        this.M = M;
        this.N = N;
        matrix = new int[M, N];
        GenerateMatrix();
    }

    private void GenerateMatrix()
    {
        Random rand = new Random();
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = rand.Next(1, 10); 
            }
        }
    }

    public void SortMatrix()
    {
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                for (int k = 0; k < M; k++)
                {
                    for (int l = 0; l < N; l++)
                    {
                        if (matrix[i, j] < matrix[k, l])
                        {
                            int temp = matrix[i, j];
                            matrix[i, j] = matrix[k, l];
                            matrix[k, l] = temp;
                        }
                    }
                }
            }
        }
    }


    public void DisplayMatrix()
    {
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qator sonini kiriting: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Ustun sonini kiriting: ");
        int N = int.Parse(Console.ReadLine());

        RandomMatrix matrix = new RandomMatrix(M, N); 

        Console.WriteLine("\nOriginal Matrix:");
        matrix.DisplayMatrix();

        matrix.SortMatrix(); 
        Console.WriteLine("\nSaralangan Matrix:");
        matrix.DisplayMatrix();
    }
}
