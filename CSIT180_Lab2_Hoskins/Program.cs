using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIT180_Lab2_Hoskins
{
    class Program
    {
        static void Main(string[] args)
        {

            Program myProgram = new Program();
            myProgram.prompt();

            Console.ReadLine();
        }

        public void prompt()
        {
            string stuName = " ", className = " ";
            char continueLoop = ' ';
            double currCreditHours = 0.0, currIntGrade = 0.0, totalCreditHours = 0.0, totalIntGrade = 0.0, stuGPA = 0.0;
            char letterGrade = ' ';

            Console.Write("What is your name?: ");
            stuName = Console.ReadLine();
            
            do
            {
                //just making the console look a little cleaner by breaking up the classes
                Console.WriteLine("-----------------------------------------------------------------");
                Console.Write("What is the name of the class?: ");
                className = Console.ReadLine();

                Console.Write("How many credits is the class? ");
                currCreditHours = Convert.ToDouble(Console.ReadLine());

                Console.Write("What letter grade did you receive?: ");
                letterGrade = Convert.ToChar(Console.ReadLine());

                switch (letterGrade)
                {
                    case 'A':
                    case 'a':
                        currIntGrade = 4 * currCreditHours;
                        break;
                    case 'B':
                    case 'b':
                        currIntGrade = 3 * currCreditHours;
                        break;
                    case 'C':
                    case 'c':
                        currIntGrade = 2 * currCreditHours;
                        break;
                    case 'D':
                    case 'd':
                        currIntGrade = 1 * currCreditHours;
                        break;
                    case 'F':
                    case 'f':
                        currIntGrade = 0;
                        break;
                    default:
                        Console.WriteLine("Oh no! Looks like you did not enter a valid letter grade! :[ ");
                        Console.WriteLine("Please re-enter the class information");
                        break;                   
                }

                totalCreditHours += currCreditHours;
                totalIntGrade += currIntGrade;

                Console.Write("Do you have more classes to enter? (Y or N): ");
                continueLoop = Convert.ToChar(Console.ReadLine());
            } while (continueLoop == 'Y' || continueLoop == 'y');

            stuGPA = totalIntGrade / totalCreditHours;

            Console.WriteLine("Your GPA is: {0:F2}" , stuGPA);
        }

        public double calulateGPA(double theGrade, double theCreditHours)
        {
            double theGPA = 0.0;
            theGPA = theGrade / theCreditHours;
            return theGPA;
        }
    }
}
