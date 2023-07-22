/* Merge Sort - 
 * Divide the collection of elements into smaller subsets
 * Recursively sort the subsets
 * Combine or merge the result into a solution
 * Divide and Conquer approach
 */

class Program
{
    public void Mergesort(int[] A, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            Mergesort(A, left, mid);
            Mergesort(A, mid + 1, right);
            merge(A, left, mid, right);
        }
        //time complexity - O(n logn)
    }

    public void merge(int[] A, int left, int mid, int right)
    {
        int i = left;
        int j = mid + 1;
        int k = left;
        int[] B = new int[right + 1];
        while (i <= mid && j <= right)
        {
            if (A[i] < A[j])
            {
                B[k] = A[i];
                i = i + 1;
            }
            else
            {
                B[k] = A[j];
                j = j + 1;
            }
            k = k + 1;
        }
        while (i <= mid)
        {
            B[k] = A[i];
            i = i + 1;
            k = k + 1;
        }
        while (j <= right)
        {
            B[k] = A[j];
            j = j + 1;
            k = k + 1;
        }
        for (int x = left; x < right + 1; x++)
            A[x] = B[x];
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
        p.Mergesort(A, 0, A.Length-1);
        p.Display(A, A.Length);
        Console.ReadKey();
    }
}