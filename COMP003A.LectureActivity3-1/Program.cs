namespace COMP003A.LectureActivity3_1;

 class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Selection Statements Demo!");
        
        Console.Write("Enter the current hour (0-23): ");
        int hour = int.Parse(Console.ReadLine());


        if (hour >= 5 && hour <= 11)
        {
            Console.WriteLine("Good Morning!");
        }
    }
}