using System.Numerics;
using Fib;

// Class Summary: Driver for the Fibonacci program. Gets User input and utilizes FibonacciLogic.cs to determine results 
class FibProgram  {  
      
    public static void Main(string[] args)  {  
        var targetNum = GetUserBigIntegerInput();

        // returns 3 Fibonacci numbers only if user input is a Fibonacci number
        // otherwise returns empty array
        var result = FibonacciLogic.NextThreeFibonacci(targetNum);

        if (result.Length != 0) {
            Console.WriteLine(targetNum + " is a Fibonacci number.");
            Console.WriteLine(result[0] + ", " + result[1] + ", " + result[2] + " are the next 3 Fibonacci numbers.");

        } else {
            Console.WriteLine(targetNum + " is not a Fibonacci number.");
        }
    }  


    // Gets user input and parses into BigInteger
    private static BigInteger GetUserBigIntegerInput() {
        // loop until succesfully retrieves/parses user input number
          while (true) {
            try {
                Console.WriteLine("Enter a number to check:");
                string? userInput = Console.ReadLine();
                return BigInteger.Parse(userInput ?? "");
            } catch (Exception) {
                Console.WriteLine("Unable to parse input. Try again!");
            }
          }
    }
}
