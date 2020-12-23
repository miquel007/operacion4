using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escrive un numero");
            string Ntrap = Console.ReadLine();
            int num1 = Convert.ToInt32(Ntrap);

            double op1 = num1 + 77;
            double op2 = op1 - 3;
            double op3 = op2 * 2;

            Console.WriteLine("Variable N = " + num1);
            Console.WriteLine("{0} + 77 = {1}", num1,op1);
            Console.WriteLine("{0} - 3 = {1}",op1,op2);
            Console.WriteLine("{0} * 2 = {1}",op2,op3);


        }
    }
}
