using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbersProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = 1;
            double secondNum = 1;
            string yesOrNo = null;

            do
            {

                Console.WriteLine("Enter your first number:");
                firstNum = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Operation:");
                string operation = Console.ReadLine();
                Console.WriteLine("Enter your second number");
                secondNum = double.Parse(Console.ReadLine());
                //here put the string conversion to math
                double mathOutput = 1;

                if (operation == "+")
                {
                    mathOutput = firstNum + secondNum;
                    Console.WriteLine(firstNum + " + " + secondNum + " = " + mathOutput);
                }

                else if (operation == "-")
                {
                    mathOutput = firstNum - secondNum;
                    Console.WriteLine(firstNum + " - " + secondNum + " = " + mathOutput);
                }

                else if (operation == "*")
                {
                    mathOutput = firstNum * secondNum;
                    Console.WriteLine(firstNum + " * " + secondNum + " = " + mathOutput);
                }
                else if (operation == "/")
                {
                    mathOutput = firstNum / secondNum;
                    Console.WriteLine(firstNum + " / " + secondNum + " = " + mathOutput);
                }
                else
                {
                    Console.WriteLine("I can't understand. Let's Try Again");
                }

                


                Console.WriteLine("Do you want to do another calculation? (YES/NO)");
                yesOrNo = Console.ReadLine();
                yesOrNo = yesOrNo.ToUpper();
                

            }
            while (yesOrNo == "YES");

           

            Console.WriteLine("GOODBYE");
            Console.ReadKey();

        }
    }  
}
