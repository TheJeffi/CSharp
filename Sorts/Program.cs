namespace Sorts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 10, 2, 7, 6, 8, 4, 9, 1 };
            int[,] array2 = { { 3, 1, 2, 4 }, { 7, 6, 5, 8 }, { 12, 10, 9, 11 }, { 13, 16, 14, 15 } };
            BubbleSort(array);
            BubbleSort(array2);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write($"{array2[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        private static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        private static int[,] BubbleSort(int[,] array)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(0); k++)
                    {
                        if (array[k, i] > array[k, j])
                        {
                            int temp = array[k, i];
                            array[k, i] = array[k, j];
                            array[k, j] = temp;
                        }
                    }
                }
            }
            return array;
        }
    }
}