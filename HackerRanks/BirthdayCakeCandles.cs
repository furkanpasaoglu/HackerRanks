namespace HackerRanks;

public static class BirthdayCakeCandles
{
    public static int BirthdayCakeCandlesResolve(List<int> candles)
    {
        if (candles.Any(x => x < 1 && x > Math.Pow(10, 7)) || (candles.Count < 1 && candles.Count > Math.Pow(10, 5)))
            throw new Exception("Invalid input");

        int tallest = 0;
        int tallestCount = 0;
        
        foreach (var candle in candles)
        {
            if(candle > tallest)
            {
                tallest = candle;
                tallestCount = 0;
            }

            if (candle == tallest)
                tallestCount++;
        }

        return tallestCount;
    }
}
