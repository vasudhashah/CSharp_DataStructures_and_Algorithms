/* Shell Sort - 
 * Selects an element and compare element after a gap
 * Similar to insertion sort
 * Insert selected element from the gap at its proper position
*/

class Program
{
    public void ShellSort(int[] A, int n)
    {
        int gap = n / 2;
        while (gap > 0)
        {
            int i = gap;
            while (i < n)
            {
                int temp = A[i];
                int j = i - gap;
                while (j >= 0 && A[j] > temp)
                {
                    A[j + gap] = A[j];
                    j = j - gap;
                }
                A[j + gap] = temp;
                i = i + 1;
            }
            gap = gap / 2;
        }
        //Time Complexity - O(n log(n))
        //not complusion to divide gap by 2 but normally we prefer to use 2
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
        p.ShellSort(A, A.Length);
        p.Display(A, A.Length);
        Console.ReadKey();
    }
}