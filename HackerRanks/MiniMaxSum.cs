namespace HackerRanks;

public static class MiniMaxSum
{
    public static void MiniMaxSumResolve(List<int> arr)
    {
        arr = new List<int> { 5, 5, 5, 5, 5 };

        if(!arr.Any() || arr.Count < 0 || arr.Count > Math.Pow(10, 9))
            throw new Exception("Invalid input");

        Int64 min = Int64.MaxValue, max = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            Int64 sum = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                if (j == i) continue;
                sum += arr[j];
            }

            if (sum < min) 
                min = sum;
            if (sum > max) 
                max = sum;
        }

        Console.WriteLine($"{min} {max} ");
    }
}
