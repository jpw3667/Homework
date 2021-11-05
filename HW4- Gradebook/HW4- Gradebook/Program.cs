using System;
/*Program: Gradebook
 * Author: Jason Weinberg
 * purpose- Create a grading program
 * modifications - 11/4 - Did the entire project but forgot to use classes. 11/5 - Edited the project to use an assignments class.
 * */
namespace HW4__Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAssignments = 0;
            double grade;
            int gradeIndex = 0;
            bool isValid = false;

            Console.WriteLine("Welcome to the gradebook. \n");

            Console.Write("How many assignments have you had? ");
            isValid = int.TryParse(Console.ReadLine().Trim(), out numAssignments);
            while (numAssignments < 1)
            {       
                    Console.Write("You did not give me a valid whole number. Please try again. ");
                isValid = int.TryParse(Console.ReadLine().Trim(), out numAssignments);
            }

            //Creates an array for every assignment as an object with its name and grade, with the length that the user inputted.
            assignment[] assignments = new assignment[numAssignments];

            //Gets the assignment name and grade, creates a new assignment with both for every slot in the assignments array.
            for (int i = 0; i < numAssignments; i++)
            {
                Console.WriteLine("");
                assignments[i] = new assignment(getAssignmentName(), getGrade(""));
            }


            gradeReport(assignments);

            Console.WriteLine("");
            Console.WriteLine("You now have a chance to replace a single one of your grades.");

            //Gets a user inputted integer for the index of the grade that they want to replace.
            Console.Write("What is the index of this grade?: ");
            isValid = int.TryParse(Console.ReadLine().Trim(), out gradeIndex);
            while (gradeIndex < 1 || gradeIndex > numAssignments)
            {
                Console.Write("Invalid index. Index must be a value between 1 and {0}. ",numAssignments);
                isValid = int.TryParse(Console.ReadLine().Trim(), out gradeIndex);
            }

            Console.WriteLine("");

            //Gets the new grade and replaces the old grade in the inputted index with it.
            grade = getGrade("new ");

            assignments[gradeIndex - 1].Grade = grade;

            gradeReport(assignments);

        }

        //Asks the user to input a string and checks if it's valid. It will keep asking for a string if its invalid, and return said string once it is valid.
        public static string getAssignmentName()
        {
            string name;

            Console.Write("Enter assignment name: ");
            name = Console.ReadLine().Trim();
            while (string.IsNullOrEmpty(name))
            {
                Console.Write("You did not input anything. Please input the name of an assignment: ");
                name = Console.ReadLine().Trim();
            }
            return name;
        }

        //Will ask the user to input a double for a grade and checks if its vald and between 0 and 100. It will keep asking for a double if it's invalid, and will return said double once it is valid.
        public static double getGrade(string usage)
        {
            bool isDouble;
            double grade = -1; 
            Console.Write("Enter {0}assignment grade: ", usage);
            isDouble = double.TryParse(Console.ReadLine().Trim(), out grade);
            if (!isDouble)
            {
                grade = -1;
            }
            while (grade < 0 || grade> 100)
            {
                Console.Write("You did not give me a valid grade. Please try again: ");
                isDouble = double.TryParse(Console.ReadLine().Trim(), out grade);
                if (!isDouble)
                {
                    grade = -1;
                }
            }
            return grade;

        }

        //Prints the assignment's index number, name, and grade for every assignment, then calculates the average grade and prints it.
        public static void gradeReport(assignment[] assignments)
        {
            double gradeTotal = 0;
            Console.WriteLine("");
            Console.WriteLine("Grade report:");

            for (int i = 0; i < assignments.Length; i++)
            {
                Console.WriteLine("  {0}. {1}: {2}", i+1, assignments[i].Name, assignments[i].Grade);
                gradeTotal += assignments[i].Grade;
            }
            Console.WriteLine("----------------------------");
            
            Console.WriteLine("Final Average: " + gradeTotal / assignments.Length);
        }
    }
}
