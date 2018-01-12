using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshHolda = double.Parse(Console.ReadLine());
        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double price = double.Parse(Console.ReadLine());
            double diff = Proc(last, price);
            bool isSignificantDifference = difference(diff, threshHolda);
            string message = Get(price, last, diff, isSignificantDifference);
            Console.WriteLine(message);

            last = price;        
        }
    }

    private static string Get(double price, double last, double diff, bool etherTrueOrFalse)
    {
        string to = "";
        if (diff == 0)
        {
            to = string.Format("NO CHANGE: {0}", price);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, price, diff*100);
        }
        else if (etherTrueOrFalse && (diff > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, price, diff*100);
        }
        else if (etherTrueOrFalse && (diff < 0))
        {
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, price, diff*100);
        }
        return to;
    }
    private static bool difference(double granica, double isDiff)
    {
        if (Math.Abs(granica) >= isDiff)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static double Proc(double l, double c)
    {
        double r = (c - l) / l;
        return r;
    }
}
