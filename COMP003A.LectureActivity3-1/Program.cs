namespace COMP003A.LectureActivity3_1;

 class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Selection Statements Demo!");
        
        Console.Write("Enter the current hour (0-23): ");
        int hour = int.Parse(Console.ReadLine());

        /* if statement: if the hour is greater than or equal to 5  
        and less than or equal to 11 then it'll display "Good Morning" */
        if (hour >= 5 && hour <= 11)
        {
            Console.WriteLine("Good Morning!");
        }
        
        /* else-if statement: if the hour is greater than or equal to 12 and
         less than or equal to 17 then it'll output "Good Afternoon" */
        else if (hour >= 12 && hour <= 17)
        {
            Console.WriteLine("Good Afternoon!");
        }
    
        
        /* else-if statement: If the hour is greater or equal to 18 and
         less than or equal to 20 then it'll output "Good Evening" */ 
        else if (hour >= 18 && hour <= 20)
        {
            Console.WriteLine("Good Evening!");
        }
        
        /* else statement: if the hour doesn't apply to any of the code above then
         it'll just output "Good Night!" */
        else
        {
            Console.WriteLine("Good Night!");
        }
    }
    
    
    
}