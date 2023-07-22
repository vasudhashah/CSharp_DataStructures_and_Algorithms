//Selection Sort - Select the minimum element and place in appropriate position

class Program
{
    public void SelectionSort(int[] A, int n)
    {
        int position, temp;
        for(int i= 0; i < n-1; i++)
        {
            position = i;
            for(int j=i+1; j < n; j++)
            {
                if (A[j] < A[position])
                {
                    position = j;
                }
            }
            temp = A[i];
            A[i]=A[position];
            A[position]=temp;
        }
        //time complexity of Selection Sort is O(n^2)
        //It is an unstable algorithm
    }
    public void display(int[] A, int n)
    {
        for(int i = 0; i < n; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] agrs)
    {
        int[] A = { 5, 3, 8, 6, 9, 2 };
        Program p = new Program();
        Console.WriteLine("Original Array");
        p.display(A, A.Length);
        Console.WriteLine("Sorted Array");
        p.SelectionSort(A, A.Length);
        p.display(A, A.Length);
        Console.ReadKey();

    }
}