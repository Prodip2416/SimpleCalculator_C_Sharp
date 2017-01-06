using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static double result;
        static void Main(string[] args)
        {
            bool myBool = true;
            while(myBool)
            {
                myBool = MainMenu();
            }
     
        }
        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------Welcome-----------------------------------------");
            Console.WriteLine("   What you need???\n");
            Console.WriteLine("1) Addication : Press \"1\" ");
            Console.WriteLine("2) Subtraction : Press \"2\" ");
            Console.WriteLine("3) Multiplection : Press \"3\" ");
            Console.WriteLine("4) Divided : Press \"4\" ");
            Console.WriteLine("5) Exit : Press \"5\" ");


            string myResult = Console.ReadLine();

            if( myResult =="1")
            {
                Addiction();
                return true;
            }
            else if (myResult =="2")
            {
                Subtraction();
                return true;
            }
            else if (myResult == "3")
            {
                Multiplication();
                return true;
            }
            else if(myResult == "4")
            {
                Divided();
                return true;
            }
            else if (myResult == "5")
            {
                return false;
            }
            else
            {
                MainMenu();
                return true;
            }

        }

        static void Addiction()
        {
            Console.WriteLine("Please Enter 2 numbers.");

            Console.Write("1st Number : ");
            double myFirstNumber = int.Parse(Console.ReadLine());
            Console.Write("2st Number : ");
            double mySecondNumber = int.Parse(Console.ReadLine());

            result = myFirstNumber + mySecondNumber;

            Console.WriteLine("Result = " + result);
            Console.ReadLine();
        }
        static void Subtraction()
        {

            Console.WriteLine("Please Enter 2 numbers.");

            Console.Write("1st Number : ");
            double myFirstNumber = int.Parse(Console.ReadLine());
            Console.Write("2st Number : ");
            double mySecondNumber = int.Parse(Console.ReadLine());

            result = myFirstNumber - mySecondNumber;

            Console.WriteLine("Result = " + result);
            Console.ReadLine();
        }
        static void Multiplication()
        {
            Console.WriteLine("Please Enter 2 numbers.");

            Console.Write("1st Number : ");
            double myFirstNumber = int.Parse(Console.ReadLine());
            Console.Write("2st Number : ");
            double mySecondNumber = int.Parse(Console.ReadLine());

            result = myFirstNumber * mySecondNumber;

            Console.WriteLine("Result = " + result);
            Console.ReadLine();
        }
        static void Divided()
        {
            Console.WriteLine("Please Enter 2 numbers.");

            Console.Write("1st Number : ");
            double myFirstNumber = int.Parse(Console.ReadLine());
            Console.Write("2st Number : ");
            double mySecondNumber = int.Parse(Console.ReadLine());

            result = myFirstNumber / mySecondNumber;

            Console.WriteLine("Result = " + result);
            Console.ReadLine();
        }
    }
}
