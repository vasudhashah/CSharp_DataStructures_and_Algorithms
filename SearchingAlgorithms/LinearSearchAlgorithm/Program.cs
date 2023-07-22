class Program
{
    public int Linear_search(int[] A, int n, int key)
    {
        int index = 0;
        while(index < n)
        {
            if (A[index] == key)
            {
                return index;
            }
            index = index + 1;
        }
        return -1;
        //time complexity of linear search algorithm is O(n)
    }
    public static void Main(string[] args)
    {
        Program p = new Program();
        int[] A = { 84, 21, 47, 96, 15 };
        int ans = p.Linear_search(A, 5, 96);
        Console.WriteLine("It is found at index: "+ans);
        Console.ReadKey();
    }
}