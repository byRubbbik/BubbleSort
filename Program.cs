class BubbleSort
{
    static void Main()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Исходный массив:");
        PrintArray(arr);

        BubbleSortArray(arr);

        Console.WriteLine("\nОтсортированный массив:");
        PrintArray(arr);
    }

    static void BubbleSortArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Обмен элементов, если текущий больше следующего
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
