/* Bubble Sort - 
 * Compare the consecutive elements
 * If left element is greater than the right element, swap them
 * Continue till the end of the collections and perform several passes tp sort the elements
 */

class Program
{
    public void BubbleSort(int[] A, int n)
    {
        int temp;
      for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < ((n-i)-1); j++)
            {
                if (A[j] > A[j + 1])
                {
                    temp =A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = temp;
                }
            }
        }
      //Time Complexity - O(n^2)
      //It is stable algorithm

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
        p.BubbleSort(A, A.Length);
        p.Display(A, A.Length);
        Console.ReadKey();
    }
}