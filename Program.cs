using System;
using static System.Console;
namespace TesteCalculadora
{
    class Program
    {
        static int option = 0, exit = -999;
        static int n1 = 0, n2 = 0, res = 0;
        static void Main(string[] args)
        {

            Console.WriteLine("Calculator using Methods and Switch");
            Introduction();


            do
                switch (option)
                {
                    case 1:
                        Adicao();
                        Introduction();
                        break;
                    case 2:
                        Subtraction();
                        Introduction();
                        break;
                    case 3:
                        Multiplication();
                        Introduction();
                        break;
                    case -999:
                        WriteLine("EXIT -  Thank you !");
                        break;
                    default:
                        break;
                }
            while (option != exit);
            {
                WriteLine("EXIT -  Thank you !");
            }

        }
        static void Adicao()
        {
            int n1 = 0, n2 = 0, res = 0;
            Write("Insert first number:  ");
            n1 = int.Parse(ReadLine());
            Write("Insert second number:  ");
            n2 = int.Parse(ReadLine());
            res = n1 + n2;
            WriteLine($"The Sum of {n1} and {n2}  is:  {res} ");
        } //end 
        static void Introduction()
        {
            WriteLine("Select an option:");
            WriteLine("\n1 - Addition");
            WriteLine("2 - Subtraction");
            WriteLine("3 - Multiply");
            WriteLine("-999 - Exit");

            option = int.Parse(ReadLine());
        } //end intro method
        static void Subtraction()
        {
            Write("Insert first number:  ");
            n1 = int.Parse(ReadLine());
            Write("Insert second number:  ");
            n2 = int.Parse(ReadLine());
            res = n1 - n2;
            WriteLine($"The result of {n1} - {n2}  is:  {res} ");
        } // end of Subtraction method

        static void Multiplication()
        {
            Write("Insert first number:  ");
            n1 = int.Parse(ReadLine());
            Write("Insert second number:  ");
            n2 = int.Parse(ReadLine());
            res = n1 * n2;
            WriteLine($"The result of {n1} * {n2}  is:  {res} ");

        }
    }
}
