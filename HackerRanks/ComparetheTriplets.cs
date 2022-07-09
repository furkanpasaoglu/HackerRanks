namespace HackerRanks;

public static class ComparetheTriplets
{
    public static List<int> CompareTriplets(List<int> a, List<int> b)
    {
        if (a.Any(x=>x< 0 || x > 100) || b.Any(x=> x < 0 || x > 100) || a.Count < 1 || (!b.Any() || b.Count < 1))
            throw new Exception("Invalid input");
        
        int aliceScore = 0;
        int bobScore = 0;
        
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
                aliceScore++;
            else if (a[i] < b[i])
                bobScore++;
        }

        return new List<int>() { { aliceScore }, { bobScore } };
    }
}
