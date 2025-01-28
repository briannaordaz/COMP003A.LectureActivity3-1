// Author: Brianna Ordaz
// Course COMP003A
// Faculty: Jonathan Cruz
// Purpose: Demonstrate selection statements in C#


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
        
        //prompt for the day
        Console.Write("Enter the day of the week: ");
        string day = Console.ReadLine();
        
        /* Condition 1: Monday
           Condition 2: Friday
           Condition 3: Sunday
           Default: Just another day */

        // the switch statement will help respond based on the day 
        switch (day.ToLower())
        {
            // if the day is "monday" it'll display "Start of the work week"
            case "monday":
                Console.WriteLine("Start of the work week.");
                break;
            //if the day is "friday" it'll display "Almost the weekend!"
            case "friday":
                Console.WriteLine("Almost the weekend!");
                break;
            //if the day is "sunday" it'll display "Relax, it's sunday"
            case "sunday": 
                Console.WriteLine("Relax, it's Sunday.");
                break;
            /*if the day is any other day except the three mentioned above
             then the output would just be "Just another day." */
            default:
                Console.WriteLine("Just another day.");
                break;
        }
    }
    
    
    
}