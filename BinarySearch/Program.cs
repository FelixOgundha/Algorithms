using System;

class BinSearch
{
    static void Main()
    {
        int[] numArray = new int[] { 11, 22, 33, 44, 55, 66, 77 };

        SearchArray(numArray, 44);
        SearchArray(numArray, 99);

        string[] elements = { "apple", "banana", "car", "dog" };
        SearchArray(elements, "car");
        SearchArray(elements, "elephant");

    }

    public static void SearchArray(Array array, object value)
    {
        int numIndex = Array.BinarySearch(array, value);
        if (numIndex > 0)
        {
            Console.WriteLine("Item {0} is at index : {1}", value, numIndex);
        }
        else
        {
            Console.WriteLine("Item {0} is not present in the array", value);
        }

    }
}