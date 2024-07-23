using CalculatorLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1 for simple, 2 for scientific,3 for special");
        int c=Convert.ToInt32(Console.ReadLine());
        switch (c)
        {
            case 1:
                Console.WriteLine("1. add 2. subtract 3. multiply 4.divide");
                //Calculator  object

                break;
            case 2:
                Console.WriteLine("1. add 2. subtract 3. multiply 4.divide 5. Sin 6. cos 7. Tan");
                //ScientificCalculator obj
                break;
                case 3:
                Console.WriteLine("1. Sin 2. cos 3. Tan 4. Square 5.SquareRoot");
                //SpecialCalci
                break;
            
        }
    }
}