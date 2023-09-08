//Calls to methods that return max value among all the parameters
using System.Text;

Console.WriteLine("Max values:");
Console.WriteLine(MinMaxing.MaxInt(2, 4));
Console.WriteLine(MinMaxing.MaxInt(2, 4, 5));
Console.WriteLine(MinMaxing.MaxInt(2, 8, 5));
Console.WriteLine(MinMaxing.MaxInt(2, 8, 5, 11));
Console.WriteLine(MinMaxing.MaxInt(2, 8, 5, 11, 10, 15, 17, 21, 31, 2, 10));
Console.WriteLine("\n");
//Calls to methods that return min value among all the parameters
Console.WriteLine("Min values:");
Console.WriteLine(MinMaxing.MinInt(2, 4));
Console.WriteLine(MinMaxing.MinInt(4, 1, 3));
Console.WriteLine(MinMaxing.MinInt(9, 7, 3));
Console.WriteLine(MinMaxing.MinInt(11, 4, 12, 2));
Console.WriteLine(MinMaxing.MinInt(21, 8, 5, 11, 10, 15, 17, 21, 31, 4, 10));
Console.WriteLine("\n");

//Calls to methods that sum up numbers and return either true or false based on the result
int sumForOdd;
bool trysum1 = TrySumIfOdd(2, 4, out sumForOdd);
Console.WriteLine($"The value of the call to TrySumIfOdd method is {trysum1}, because the sum is {sumForOdd}");
bool trysum2 = TrySumIfOdd(5, 10, out sumForOdd);
Console.WriteLine($"The value of the call to TrySumIfOdd method is {trysum2}, because the sum is {sumForOdd}");
bool trysum3 = TrySumIfOdd(21, 8, out sumForOdd);
Console.WriteLine($"The value of the call to TrySumIfOdd method is {trysum3}, because the sum is {sumForOdd}");
Console.WriteLine("\n");

//Calls to methods that repeat a given string n times 
Console.WriteLine(Repeat("Hello", 5));
Console.WriteLine(Repeat("Bye", 3));


bool TrySumIfOdd(int x1, int x2, out int sumResult)
{
    sumResult = x1 + x2;
    return (x1 + x2)%2 == 1;
}

string Repeat(string x, int n)
{
    if (n <= 0)
        return string.Empty;

    StringBuilder result = new StringBuilder();
    for (int i = 0; i < n; i++)
    {
        result.Append(x);
    }
    return result.ToString();
}


 static class MinMaxing
{
    public static int MaxInt(int x1, int x2)
    {
        if (x1 > x2)
            return x1;
        else return x2;
    }
    public static int MaxInt(int x1, int x2, int x3)
    {
        if (x1 > x2 && x1 > x3) return x1;
        else if (x2 > x3) return x2;
        else return x3;
    } 
    public static int MaxInt(int x1, int x2, int x3, int x4)
    {
        /*Варіант 1 (рагульний, так краще не робити): if (x1 > x2 && x1 > x3 && x1 > x4) return x1;
        else if (x2 > x3 && x2 > x4) return x2;
        else if (x3 > x4) return x3;
        else return x4; 
        Варіант 2 (сьогодні Олексій підказав, хз, як сам не додумався, але він збс):
        return Math.Max(Math.Max(x1, x2), Math.Max(x3, x4);*/
        int[] arr = { x1, x2, x3, x4 };
        return arr.Max();
    }  
    public static int MaxInt(params int[] x)
    {
        return x.Max();
    } 

    public static int MinInt(int x1, int x2)
    {
        if (x1 < x2)
            return x1;
        else return x2;
    }
    public static int MinInt(int x1, int x2, int x3)
    {
        if (x1 < x2 && x1 < x3) return x1;
        else if (x2 < x3) return x2;
        else return x3;
    } public static int MinInt(int x1, int x2, int x3, int x4)
    {
        if (x1 < x2 && x1 < x3 && x1 < x4) return x1;
        else if (x2 < x3 && x2 < x4) return x2;
        else if (x3 < x4) return x3;
        else return x4;
    }
    public static int MinInt(params int[] x)
    {
        return x.Min();
    }

}




