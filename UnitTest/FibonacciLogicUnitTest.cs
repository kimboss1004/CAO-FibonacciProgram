using Fib;
using System.Numerics;

namespace UnitTest;

public class FibonacciLogicTests
{
    // test the base case, where user input is 0
    [Fact]
    public void Fibonacci_Input0Returns_1_1_2()
    {
        var num = new BigInteger(0);
        var result = FibonacciLogic.NextThreeFibonacci(num);

        var expectedResultA = new BigInteger(1);
        var expectedResultB = new BigInteger(1);
        var expectedResultC = new BigInteger(2);

        Assert.Equal(expectedResultA, result[0]);
        Assert.Equal(expectedResultB, result[1]);
        Assert.Equal(expectedResultC, result[2]);
    }

    // test user input 1. realistically this should have 2 different output sequences.
    [Fact]
    public void Fibonacci_Input1Returns_2_3_5()
    {
        var num = new BigInteger(1);
        var result = FibonacciLogic.NextThreeFibonacci(num);

        var expectedResultA = new BigInteger(1);
        var expectedResultB = new BigInteger(2);
        var expectedResultC = new BigInteger(3);

        Assert.Equal(expectedResultA, result[0]);
        Assert.Equal(expectedResultB, result[1]);
        Assert.Equal(expectedResultC, result[2]);
    }

    // test numbers that are not Fibonacci numbers
    [Fact]
    public void Fibonacci_IncorrectFibNumbersReturns_nothing()
    {
        var num = new BigInteger(7);
        // the sum of all these array lenghts should be 0 because non Fib numbers do not return any next sequence of Fib numbers
        int a = 0;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(4)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(6)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(7)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(9)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(10)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(11)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(12)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(14)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(15)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(16)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(17)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(18)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(19)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(20)).Length;

        Assert.Equal(0, a);
    }

    // test numbers that are Fibonacci numbers
    [Fact]
    public void BonusFibonacci_CorrectFibNumbersReturns_Sequence()
    {
        var num = new BigInteger(7);
        // the sum of all these array lenghts should be 27. each array length contains 3 elements, and there are 9 arrays.
        int a = 0;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(5)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(8)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(13)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(21)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(34)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(55)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(89)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(144)).Length;
        a += FibonacciLogic.NextThreeFibonacci(new BigInteger(233)).Length;

        Assert.Equal(27, a);
    }

    // test input 2 for the next 3 Fibonacci numbers
    [Fact]
    public void Fibonacci_2_HasCorrectSequence()
    {   
        var result = FibonacciLogic.NextThreeFibonacci(BigInteger.Parse("2"));
        Assert.NotEmpty(result);

        // Check next 3 fibonacci numbers as correct
        Assert.Equal(BigInteger.Parse("3"), result[0]);
        Assert.Equal(BigInteger.Parse("5"), result[1]);
        Assert.Equal(BigInteger.Parse("8"), result[2]);
    }

    // test input 233 for the next 3 Fibonacci numbers
    [Fact]
    public void BonusFibonacci_233_HasCorrectSequence()
    {   
        var result = FibonacciLogic.NextThreeFibonacci(BigInteger.Parse("233"));
        Assert.NotEmpty(result);

        // Check next 3 fibonacci numbers as correct
        Assert.Equal(BigInteger.Parse("377"), result[0]);
        Assert.Equal(BigInteger.Parse("610"), result[1]);
        Assert.Equal(BigInteger.Parse("987"), result[2]);
    }

    // test huge non-Fibonacci Integer
    [Fact]
    public void BonusFibonacci_LargeInteger_NonFibonacci()
    {   
        var result = FibonacciLogic.NextThreeFibonacci(BigInteger.Parse("34234234234234234234234233453453453453454234"));
        Assert.Empty(result);
    }

    // test huge Fibonacci number for the next 3 sequences. Tests the parser and the BigInteger type.
    [Fact]
    public void BonusFibonacci_LargeInteger_CorrectFibonacci()
    {   
        var result = FibonacciLogic.NextThreeFibonacci(BigInteger.Parse("1864069667454273644225850958407065116260306867075373"));
        Assert.NotEmpty(result);

        // Check next 3 fibonacci numbers as correct
        Assert.Equal(BigInteger.Parse("3016128079338728432528443992613633888712980904400501"), result[0]);
        Assert.Equal(BigInteger.Parse("4880197746793002076754294951020699004973287771475874"), result[1]);
        Assert.Equal(BigInteger.Parse("7896325826131730509282738943634332893686268675876375"), result[2]);
        Console.WriteLine(result[0]);
    }
}