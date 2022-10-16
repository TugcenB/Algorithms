public class Program
{
    static void Main(string[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";


        // Declare second integer, double, and String variables.
        int i1 = Convert.ToInt32(Console.ReadLine());
        double d1 = Convert.ToDouble(Console.ReadLine());
        string s1 = Console.ReadLine();
        // Read and save an integer, double, and String to your variables.

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + i1);
        // Print the sum of the double variables on a new line.
        var sum = string.Format("{0:0.0}", d + d1);
        Console.WriteLine(sum);
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + s1);
        // The 's' variable above should be printed first.
    }
}