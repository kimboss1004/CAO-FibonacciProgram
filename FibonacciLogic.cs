using System;
using System.Numerics;
 
namespace Fib;

// Class Summary: contains the solution/method logic for the Fibonacci problem. Also serves as the class we use our Unit Tests on
public class FibonacciLogic {

  // Determines if input is Fibonacci
  // Yes -> returns the next 3 Fibonacci numbers
  // No -> returns empty array
  // (we use BigInteger to cover cases in which the user inputs Integers that are too big for standard int type.)
  public static BigInteger[] NextThreeFibonacci(BigInteger targetNum) {
    var a = new BigInteger(0);
    var b = new BigInteger(1);

    // base case: user input is 0 (first number in fibonacci sequence)
    if (targetNum == 0) {
      return [new BigInteger(1), new BigInteger(1), new BigInteger(2)];
    }

    // Bonus problem warn: edge case
    if (targetNum == 1) {
      Console.WriteLine("The Fibonacci sequence contains the number 1 exactly two different times " +
      "(0, 1, 1, 2 ...). Thus there are 2 possibilities for the next 3 numbers if user inputs `1` (1,2,3) or (2,3,5)");
    }

    // iterate through Fibonacci sequnce till we find or pass the user's input number
    while (b < targetNum) {
      var temp = b;
      b = BigInteger.Add(a, b); // add previous two fibonacci numbers to get the next
      a = temp;
    }
    
    // return next 3 fibonacci numbers if user input was a fibonacci number
    if (b.Equals(targetNum)) {
      var c = BigInteger.Add(a, b);
      var d = BigInteger.Add(b, c);
      var e = BigInteger.Add(c, d);
      return [c, d, e];
    }

    // return empty array if users input was not a fibonacci number
    return [];
  }

}
