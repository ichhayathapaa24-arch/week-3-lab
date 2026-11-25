
using System.Diagnostics.CodeAnalysis;

namespace OperatorsAndControlFlow
{
    class Program
    {
        static void Main()
        {
            // Task 1

            int points = 10;   // Initialize points to 10

            points += 5;       // Add 5 to points
            points *= 2;       // Multiply points by 2 
            Console.WriteLine($"Final points: {points}");

            // Check whether points is greater than or equal to 25
            Boolean atLeast25 = points >= 25;
            Console.WriteLine($"Atleast 25 points: {atLeast25}");

            // Post-increment: use current value first, then increase by 1
            int afterPost = points++;
            Console.WriteLine($"points++ returned {afterPost}; points is now {points}");

            // Pre-increment: increase by 1 first, then use the new value
            int afterPre = ++points;
            Console.WriteLine($"++points returned {afterPre}; points is now {points}");


            //  Task 2: 

            int marks = 86;      
            int attendance = 90;  

            string grade;
            if (marks >= 80)
            {
                grade = "A";     
            }
            else if (marks >= 65)
            {
                grade = "B";
            }
            else if (marks >= 50)
            {
                grade = "C";    
            }
            else
            {
                grade = "Fail";  
            }

            Boolean isEligible = marks >= 50 && attendance >= 75;

            Console.WriteLine($"Marks: {marks}, Attendance: {attendance}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Pass eligible: {isEligible}");

            Console.WriteLine();


            //  Task 3

            int choice = 2;  //test with 1, 3 and 9

            Console.WriteLine("Library Menu");
            Console.WriteLine("1. Borrow   2. Return   3. Renew");
            Console.WriteLine($"Selected choice: {choice}");

        
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected Borrow.");
                    break;

                case 2:
                    Console.WriteLine("You selected Return.");
                    break;

                case 3:
                    Console.WriteLine("You selected Renew.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");  // Runs for other values
                    break;
            }

            string? userName = null; // TODO 3: ?? displays "Guest"
            // TODO 4: ??= assigns "Guest" only when userName is null
            string displayName = userName ?? "Guest";
            Console.WriteLine($"Display name: {displayName}");

            userName ??= "Guest";
            Console.WriteLine($"userName after ??=: {userName}");

            Console.WriteLine();


            // Task 4
            int[] dailyAttendance = { 20, 22, 21, 24, 23 }; // TODO 1: Monday to Friday
            int total = 0;  

            Console.WriteLine("Daily attendance:");

            //print each attendance value and add it to total
            foreach (int present in dailyAttendance)
            {
                Console.WriteLine($"  {present}");
                total += present;
            }
            Console.WriteLine($"Total attendance: {total}");

            for (int i = 0; i < dailyAttendance.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: {dailyAttendance[i]}");
            }

            int countdown = 3;
            while (countdown >= 1)
            {
                Console.WriteLine(countdown);
                countdown--;  //decrease countdown by 1
            }

            bool runAgain = false;
            do
            {
                Console.WriteLine("Attendance recorded");
            }
            while (runAgain);  

            Console.WriteLine();


            //  Task 5

            int seatCount = 0;  //count total number of seats

            for (int row = 1; row <= 3; row++)
            {
               
                for (int seat = 1; seat <= 4; seat++)
                {
                    Console.WriteLine($"Row {row} - Seat {seat}");
                    seatCount++;  //increase seat count
                }
            }
            Console.WriteLine($"Total seats: {seatCount}");

            //loop through numbers from 1 to 10
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;  //skip number 5
                }

                if (i == 8)
                {
                    break;     //stop the loop at number 8
                }

                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine();


            //  Task 6

            //read first number from the user
            Console.Write("Enter the first integer: ");
            string firstInput = Console.ReadLine() ?? "";

            //read  second number from the user
            Console.Write("Enter the second integer: ");
            string secondInput = Console.ReadLine() ?? "";

            try
            {
                //convert input strings into integers
                int first = int.Parse(firstInput);
                int second = int.Parse(secondInput);
                int result = first / second;  //divide the first number by the second
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                //handle input that is not a valid integer
                Console.WriteLine("Error: please enter whole numbers only.");
            }
            catch (DivideByZeroException)
            {
                //handle division by zero
                Console.WriteLine("Error: cannot divide by zero.");
            }
            finally
            {
                Console.WriteLine("Calculation complete");
            }
        }
    }
}
