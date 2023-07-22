/* Insertion Sort - 
 * Selects one element at a time from the left of the collection
 * Insert the element at proper position
 * After insertion every element to its left needs to be sorted
 */

class Program
{
    public void InsertionSort(int[] A, int n)
    {
        int temp,position;
        for(int i = 1; i < n; i++)
        {
            position = i;
            for (int j=i-1;j>=0; j--)
            { 
                if (A[j] > A[position])
                {
                    temp = A[position];
                    A[position] = A[j];
                    A[j] = temp;
                    position = j;
                }
            }
        }
        //Insertion Sort - O(n^2)
        //It is stable algorithm
    }
    public void Display(int[] A, int n)
    {
        for(int i = 0; i < n; i++)
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
        p.InsertionSort(A, A.Length);
        p.Display(A, A.Length);
        Console.ReadKey();
    }
}