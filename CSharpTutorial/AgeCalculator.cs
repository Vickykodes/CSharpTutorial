using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public static class AgeCalculator
    {
        public static void Calculate()
        {
            try {
                DateTime today = DateTime.Now.Date;
                DateTime? birthDate = null;
                int currentAge;

                Console.WriteLine("Enter your birth date (eg: 12/28/2009)");
                Console.WriteLine("--------------------");
                string? enterBirthDate = Console.ReadLine();
                Console.WriteLine("--------------------");

                if (!DateTime.TryParse(enterBirthDate, out DateTime result))
                {
                    Console.WriteLine("Wrong date format"); 

                }
                else
                {
                    birthDate = result;
                    int proposedAge = today.Year - birthDate.Value.Year;

                    Console.WriteLine("Output:");
                    Console.WriteLine($"Todays date is {today}");
                    Console.WriteLine($"Proposed age is {proposedAge}");

                    if (birthDate == null)
                    {
                        Console.WriteLine("Birth date cannot be null"); //interpolation

                    }
                    if (today < birthDate.Value.AddYears(proposedAge)) //14 dec 2024
                    {
                        currentAge = --proposedAge;
                        Console.WriteLine($"Your current age is {currentAge}"); //interpolation
                    }
                    else
                    {
                        currentAge = proposedAge;
                        Console.WriteLine($"Your current age is {currentAge}"); //interpolation
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }


            
         }
    }
}
