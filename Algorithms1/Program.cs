class Program
{
    static void Main(string[] args)
    {
        int x = 74;
        int y = 74 / 10;
        int z = x - y * 10;
        int a = z <= 5 ? 5 : 10;
        int b = (y * 10 + a - x) < 3 ? y * 10 + a : x;
        Console.WriteLine(a);
        Console.WriteLine(b);
        List<int> grades = new List<int>{73, 67, 38, 33};
        gradingStudents(grades);
    }
    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> gradesRound = new List<int>();
        foreach (var item in grades)
        {
            if (item<38)
            {
                gradesRound.Add(item);
            }
            else
            {
                int x = item;
                int y = x / 10;
                int z = x - y * 10;
                int a = z <= 5 ? 5 : 10;
                int b = (y * 10 + a - x) < 3 ? y * 10 + a : x;
                gradesRound.Add(b);
            }
        }
        return gradesRound;

    }
}