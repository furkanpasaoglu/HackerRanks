namespace HackerRanks;
public static class SimpleArraySum
{
    public static int SimpleArraySumResolve(List<int> ar)
    {
        if (ar.Any(x => x > 1000 || x < 0) || (ar.Count > 1000 || ar.Count < 0))
            throw new Exception("Number greater than 1000 and Number Less than 0");

        var sum = ar.Sum();

        return sum;
    }
}
