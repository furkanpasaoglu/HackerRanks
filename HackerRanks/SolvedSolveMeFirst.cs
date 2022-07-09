namespace HackerRanks;
public static class SolvedSolveMeFirst
{
    public static int SolveMeFirstResolve()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        if (a < 0 && b < 0)
            throw new Exception("Negative numbers not allowed");
        if (a > 1000 && b > 1000)
            throw new Exception("Numbers too big");

        int sum = a + b;
        return sum;
    }
}
