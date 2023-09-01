using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterGrade_Console
{
    internal class letterGradeConsole
    {
        static void Main(string[] args)
        {
            // declaring variable and const
            const decimal AgradeMAX = 4.0m;

            const decimal Bgrade = 3.2m;
            const decimal Cgrade = 2.5m;
            const decimal Dgrade = 1.0m;
            const decimal FgradeMIN = 0.0m;


            decimal numGrade = 0.0m;

            string resultLetter = "";

            //get the user gpa input
            Console.Write("Enter GPA: ");
            numGrade = Convert.ToDecimal(Console.ReadLine());

            bool go = true;

            while (numGrade < 0 || numGrade > 4)
            {
                Console.WriteLine("GPA OUT OF RANGE < 0 or > 4");
                Console.Write("Enter GPA: ");
                numGrade = Convert.ToDecimal(Console.ReadLine());
               
            }


            while (numGrade > 0 || numGrade < 4)
            {

             
                

                // if number grade is > 3.2 = A grade 
                if ((numGrade > Bgrade) && (numGrade <= AgradeMAX))
            {
                resultLetter = "A";
            }

            // if number grade is > 2.5 = B grade 
            else if ((numGrade > Cgrade) && (numGrade <= Bgrade))
            {
                resultLetter = "B";
            }
            // if number grade is > 1.0 = C grade 
            else if ((numGrade > Dgrade) && (numGrade <= Cgrade))
            {
                resultLetter = "C";
            }
            // if number grade is < 1.0 = D grade 
            else if ((numGrade > FgradeMIN) && (numGrade <= Dgrade))
            {
                resultLetter = "D";
            }

            // if number grade is equal to 0 = A grade 
            else if ((numGrade == FgradeMIN))
            {
                resultLetter = "F";
            }

             // diplay result to the console
             Console.WriteLine("Your Letter Grade Is: " + resultLetter);
                Console.WriteLine();
                Console.Write("Enter GPA: ");
                numGrade = Convert.ToDecimal(Console.ReadLine());


            }
        }
    }
}
