namespace HackerRanks;

public static class AVeryBigSum
{
    public static long AVeryBigSumResolve(List<long> ar)
    {
        if (!ar.Any() || ar.Count < 1 || ar.Count > 10)
            throw new Exception("Invalid input");
        
        long sum = 0;
        for (int i = 0; i < ar.Count; i++)
        {
            if (ar[i] < 0 || ar[i] > Math.Pow(10, 10))
                throw new Exception();

            sum += ar[i];
        }

        return sum;
    }
}
