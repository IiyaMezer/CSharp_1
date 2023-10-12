namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

            Console.WriteLine("Исходный массив:");
            PrintArray(a);
            Console.WriteLine("Отсортированный массив:");
            PrintArray(Sort2DimArray(a));
        }

        private static int[,] Sort2DimArray(int[,] arr)
        {
            int[,] sortedArray = new int[arr.GetLength(0), arr.GetLength(1)];
            int[] temp = new int[arr.GetLength(0) * arr.GetLength(1)];
            int counter = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    temp[counter] = arr[i, j];
                    counter++;
                }
            }

            BubbleSort(temp);
            counter = 0;

            for (int i = 0; i < sortedArray.GetLength(0); i++)
            {
                {
                    for (int j = 0; j < sortedArray.GetLength(1); j++)
                    {
                        sortedArray[i, j] = temp[counter++];
                    }
                }
            }

            return sortedArray;
        }

        private static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        array[j] += array[j + 1];
                        array[j + 1] = array[j] - array[j + 1];
                        array[j] -= array[j + 1];
                    }
                }
        }

    }
}
