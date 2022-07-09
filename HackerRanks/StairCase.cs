namespace HackerRanks;

public static class StairCase
{
    public static void StairCaseResolve(int n)
    {
        if (n < 0 || n > 100)
            throw new Exception("Invalid input");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));
        }
    }
}
