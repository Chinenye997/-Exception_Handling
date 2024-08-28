using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
           
        
        {
            try
            {
                Console.Write("Enter a number:");
                int Num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number:");
                int Num2 = Convert.ToInt32(Console.ReadLine());
                /*Console.Write("Enter another number:");
                int Num3 = Convert.ToInt32(Console.ReadLine());*/


                Console.WriteLine(Num1 / Num2); //+ Num3);
            }
            //catch(Exception e) this 2nd
            catch(DivideByZeroException e)
            {
                // Console.WriteLine("Error"); // this first

                // if i want to know what was worry with the error i just do

                Console.WriteLine(e.Message);// With this i will know what is the error is.

            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
           

            Console.ReadLine();
        }
    }
}
