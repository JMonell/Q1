
namespace Q1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string a = "hejsan";
        int b = 4;
        decimal c = 3.40M;
        float d = 7.52f;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);

        decimal e = 3.67M;

        Console.WriteLine(e*10);

        // string inteerpolation is when you use a $ before a string to enter values more efficient

        int i = int.MaxValue;
        Console.WriteLine(i+1);
        // the value goes to the lowest possible

        // typcasting is when you switch the typ of a value from ex: string to int

        string s = "3";
        int s1 = Int32.Parse(s);
        Console.WriteLine(s1);

    }
}
