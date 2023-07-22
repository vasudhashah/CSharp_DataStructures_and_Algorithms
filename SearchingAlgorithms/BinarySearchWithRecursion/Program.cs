//The Array must be sorted for BinarySearch
class Program
{
    public int BinarySearchRecursion(int[] A, int key, int L, int R)
    {
        if (L > R)
            return -1;
        else
        {
            int M = (L + R) / 2;
            if (A[M] == key)
                return M;
            else if (key < A[M])
                return BinarySearchRecursion(A, key, L, M - 1);
            else if (key > A[M])
                return BinarySearchRecursion(A, key, M + 1, R);
        }
        return -1;
        //Time Complexity for Binary Search with recursion is O(log n)
    }
    public static void Main(string[] args)
    {
        Program p = new Program();
        int[] A = { 4, 11, 18, 30, 54 };
        int ans = p.BinarySearchRecursion(A, 54,0,4);
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