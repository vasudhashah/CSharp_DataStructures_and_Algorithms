class Program
{
    public int BinarySearch(int[] A,int n, int key)
    {
        int L = 0;
        int R = n - 1;
        int M = 0;
        while(L<= R)
        {
            M = (L+R)/2;
            if(A[M] == key)
            {
                return M;
            }
            else if(key< A[M])
            {
                R = M - 1;
            }
            else if(key> A[M])
            {
                L = M + 1;
            }
        }
        return -1;
        //time complexity of Binary Search with Iteration Method is O(log n) 
    }
    public static void Main(string[] args)
    {
        Program p = new Program();
        int[] A = { 4, 11, 18, 30, 54 };
        int ans = p.BinarySearch(A, 5, 54);
        if (ans >= 0)
        {
            Console.WriteLine("It is found at index: " + ans);
        }
        else
        {
            Console.WriteLine("Not found");
        }
        Console.ReadKey();
    }
}