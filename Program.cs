// See https://aka.ms/new-console-template for more information


//ASSIGNMENT 1.


//class Program
//{
//    static void Main()
//    {
//        LocalVariable();
//        ObjectAllocation();
//    }

//    static void LocalVariable()
//    {
//        int localVar = 10; // Stored in stack
//        Console.WriteLine($"Local Variable: {localVar} (Stored in Stack)");
//    }

//    static void ObjectAllocation()
//    {
//        string heapObject = new string("Hello, Heap!"); // Stored in heap
//        Console.WriteLine($"Heap Object: {heapObject} (Stored in Heap)");
//    }
//}

//ASSIGMENT 2


//class Program
//{
//    static void Main()
//    {
// Uncommenting the next line will cause a stack overflow
// CauseStackOverflow();

// Adding a base case
//        CauseStackOverflowWithBaseCase(5);
//    }

//    static void CauseStackOverflow()
//    {
//        CauseStackOverflow(); // No base case
//    }

//    static void CauseStackOverflowWithBaseCase(int count)
//    {
//        if (count == 0) return; // Base case
//        Console.WriteLine(count);
//        CauseStackOverflowWithBaseCase(count - 1);
//    }
//}

//ASSIGMENT 3

//{
//    static void Main()
//    {
//        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
//        Console.WriteLine("Unsorted array:");
//        PrintArray(arr);

//        BubbleSort(arr);

//        Console.WriteLine("Sorted array:");
//        PrintArray(arr);
//    }

//    static void BubbleSort(int[] arr)
//    {
//        int n = arr.Length;
//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = 0; j < n - i - 1; j++)
//            {
//                if (arr[j] > arr[j + 1])
//                {
//                    // Swap
//                    int temp = arr[j];
//                    arr[j] = arr[j + 1];
//                    arr[j + 1] = temp;
//                }
//            }
//        }
//    }

//    static void PrintArray(int[] arr)
//    {
//        foreach (int value in arr)
//        {
//            Console.Write(value + " ");
//        }
//        Console.WriteLine();
//    }

//ASSIGNMENT 5

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 1, 2, 3, 4, 5 };
//        int sum = CalculateSum(arr);
//        Console.WriteLine($"The sum of the elements in the array is: {sum}");
//    }

//    static int CalculateSum(int[] arr)
//    {
//        int sum = 0;
//        foreach (int value in arr)
//        {
//            sum += value;
//        }
//        return sum;
//    }
//}

//ASSIGNMENT 6


//class Program
//{
//    static void Main()
//    {
//        string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
//        ReplaceFruit(fruits, "Apple", "Orange");
//        PrintArray(fruits);
//    }

//    static void ReplaceFruit(string[] fruits, string oldFruit, string newFruit
