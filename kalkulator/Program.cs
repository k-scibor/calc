internal class Program

{

    static void Main(string[] args)

    {

        var calculator = new Calculator();



        double result = calculator.Add(2, 3);

        Console.WriteLine($"2 + 3 = {result}");



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

