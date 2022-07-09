namespace HackerRanks;
public static class PlusMinus
{
    public static void PlusMinusResolve(List<int> arr)
    {
        if (arr.Any(x => x < -100 && x > 100) || (arr.Count < 0 || arr.Count > 100))
            throw new Exception("Invalid input");

        decimal positiveValues = 0; 
        decimal negativeValues = 0;
        decimal zeroValues = 0;

        foreach (var item in arr)
        {
            if (item > 0)
                positiveValues++;
            else if(item < 0)
                negativeValues++;
            else
                zeroValues++;
        }

        positiveValues = positiveValues / arr.Count;
        negativeValues = negativeValues / arr.Count;
        zeroValues = zeroValues / arr.Count;

        Console.WriteLine($"{positiveValues}");
        Console.WriteLine($"{negativeValues}");
        Console.WriteLine($"{zeroValues}");

    }
}
