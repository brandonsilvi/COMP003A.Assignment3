using System;

namespace COMP003A.Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Academic & Personal Readiness Evaluator ===");
            
            //Behavior 1 time based readiness
            int currentYear = DateTime.Now.Year;
            Console.WriteLine("Current Year: " + currentYear);

            Console.Write("Enter your year of birth: ");
            int yearOfBirth = int.Parse(Console.ReadLine());

            int age = currentYear - yearOfBirth;
            Console.WriteLine("User Age: " + age);

            string ageCategory;
            if (age < 18)
            {
                ageCategory = "Minor";
            }
            else if (age >= 18 && age <= 64)
            {
                ageCategory = "Adult";
            }
            else
            {
                ageCategory = "Senior";
            }

            Console.WriteLine("Readiness Category: " + ageCategory);

            //Behavior 2 multi rules based readiness

            Console.Write("Do you have a valid ID? (yes/no): ");
            bool isValidID = Console.ReadLine().ToLower() == "yes";
            
            Console.Write("Have you completed orientation? (yes/no): ");
            bool completedOrientation = Console.ReadLine().ToLower() == "yes";

            string readinessCategory;
            //Mandatory rule
            if (ageCategory == "Adult" && isValidID)
            {
                //Optional rule
                if (completedOrientation)
                {
                    readinessCategory = "Ready";
                }
                else
                {
                    readinessCategory = "Conditionally Ready";
                }

            }
            else
            {
                readinessCategory = "Not Ready";
            }

            Console.WriteLine("Readiness Category: " + readinessCategory);


            //Behavior 3 guidance selection



        }
    }
}