// teach me Enumerable in C#
using System;
using System.Collections.Generic;
using System.Linq;
class Enumerable
{
    static void learnEnumerable()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        IEnumerable<int> enumerableNumbers = numbers;
        // Using Where to filter even numbers
        var evenNumbers = enumerableNumbers.Where(n => n % 2 == 0);
        
        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        // Using Select to project each number to its square
        var squaredNumbers = enumerableNumbers.Select(n => n * n);

        Console.WriteLine("Squared Numbers:");
        foreach (var num in squaredNumbers)
        {
            Console.WriteLine(num);
        }

        // Using Aggregate to compute the sum of all numbers
        var sum = enumerableNumbers.Aggregate((total, n) => total + n);
        Console.WriteLine($"Sum of Numbers: {sum}");
    }

    // static void Main(string[] args)
    // {
    //     learnEnumerable();
    // }
}