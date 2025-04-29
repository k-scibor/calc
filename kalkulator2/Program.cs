using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator2
{
    internal class Program

    {

        static void Main(string[] args)

        {

            var calculator = new Calculator();



            double result = calculator.Add(2, 3);

            Console.WriteLine($"2 + 3 = {result}");

            double result2 = calculator.Substract(2, 7);

            Console.WriteLine($"2 - 7 = {result2}");

            double result3 = calculator.Multiply(5, 3);

            Console.WriteLine($"5 * 3 = {result3}");




            try

            {

                calculator.Divide(5, 0);

            }

            catch (DivideByZeroException)

            {

                Console.WriteLine("Błąd: dzielenie przez zero.");

            }



            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");

            Console.ReadKey();

        }

    }
}
