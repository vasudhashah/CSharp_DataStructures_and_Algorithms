/* Quick Sort - 
 * divide the collection of element into subsets or partition
 * Partition based on Pivot, where elements to left of pivot will be smaller to pivot n elements to right will be larger than pivot
 * recursively sort the partitions using quick sort
 * Divide and Conquer Approach 
 */

class Program
{
    public void quicksort(int[] A, int low, int high)
    {
        if (low < high)
        {
            int pi = partition(A, low, high);
            quicksort(A, low, pi - 1);
            quicksort(A, pi + 1, high);
        }
    }

    public int partition(int[] A, int low, int high)
    {
        int pivot = A[low];
        int i = low + 1;
        int j = high;
        do
        {
            while (i <= j && A[i] <= pivot)
                i = i + 1;
            while (i <= j && A[j] > pivot)
                j = j - 1;
            if (i <= j)
                swap(A, i, j);

        } while (i < j);
        swap(A, low, j);
        return j;
    }

    public void swap(int[] A, int i, int j)
    {
        int temp = A[i];
        A[i] = A[j];
        A[j] = temp;
    }
    public void Display(int[] A, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(A[i]);
        }
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        Program p = new Program();
        int[] A = { 3, 5, 8, 9, 6, 2 };
        Console.WriteLine("Original Array");
        p.Display(A, A.Length);
        Console.WriteLine("Sorted Array");
        p.quicksort(A,0,5);
        p.Display(A, A.Length);
        Console.ReadKey();
    }
}