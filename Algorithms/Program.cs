/*Background
    Linear search checks each element in the list until a match is found or until it reaches the end.

    Linear Search Function
        Consider the linear function as “LinearSearch(arr, value)”
        where arr is the array to search inside of
        where value is the element, we are searching for in array “arr.”

    Output
        Returns -1, if element not found
        Returns the index of an array element, where arr[index]= value

    Pseudo Code
        Set answer to -1
        For each index from index=1 to n (where n is the last index of arr)
        If arr[index] = value, then set the answer to the index value
        Return the value of the answer as output
*/

static int LinearSearch(int[] a, int x)
{
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] == x)
        {
            return i;
        }
    }
    return -1;
}


static void Main(string[] args)
{
    int[] arr = new int[] { 1, 4, 5, 7, 9, 22 };

    Console.WriteLine("Current rray Elements " + string.Join(" , ", arr));
    Console.WriteLine("Enter the element to be searched");
    int value = Convert.ToInt32(Console.ReadLine());
    var index = LinearSearch(arr, value);
    if (index != -1)
        Console.WriteLine($"Element {value} found at index {index}");
    else
        Console.WriteLine("Element not found");
}