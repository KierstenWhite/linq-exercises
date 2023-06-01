using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

// EXERCISE ONE: Find the words in the collection that start with the letter 'L'
// List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

// IEnumerable<string> LFruits = from fruit in fruits
// where fruit.StartsWith("L")
// select fruit;

// foreach (string f in LFruits)
// {
//     Console.WriteLine($"{f}");
// }

// EXERCISE TWO: Which of the following numbers are multiples of 4 or 6
// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };

// IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);

// foreach (int num in fourSixMultiples)
// {
//     Console.WriteLine($"{num}");
// }

// EXERCISE THREE: Order these student names alphabetically, in descending order (Z to A)
// List<string> names = new List<string>()
// {
//     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
//     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
//     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
//     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
//     "Francisco", "Tre"
// };

// List<string> descend = names.OrderByDescending(n => n).ToList();

// foreach (string name in descend) 
// {
//     Console.WriteLine(name);
// }

// // EXERCISE FOUR: Build a collection of these numbers sorted in ascending order
    // List<int> numbers = new List<int>()
    //     {
    //         15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
    //     };

    // List<int> AscendingOrderList = numbers.OrderBy(n => n).ToList();

    // foreach (int num in AscendingOrderList)
    // {
    //     Console.WriteLine(num);
    // }

// EXERCISE 5: Output how many numbers are in this list
// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };

// int HowManyNumbers = numbers.Count(); //only int at the beginning because you're not making a list, just want the an integer

// Console.WriteLine(HowManyNumbers);

// EXERCISE 6: How much money have we made?
// List<double> purchases = new List<double>()
// {
//     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
// };

// double totalProfit = purchases.Sum();
// double roundedProfit = Math.Round(totalProfit, 2);

// Console.WriteLine(roundedProfit);

// EXERCISE 7: What is our most expensive product?
// List<double> prices = new List<double>()
// {
//     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
// };

// Console.WriteLine(prices.Max());

//EXERCISE EIGHT
// List<int> wheresSquaredo = new List<int>()
// {
//     66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
// };

// bool isPerfectSquare(int numm) //Deciding whether or not the number is a perfect square
// {
//     int square = (int)Math.Sqrt(numm);
//     return square * square == numm;
// }

// List<int> storageList = new List<int>(); //Creating a new list to store the numbers in

// foreach (int number in wheresSquaredo) //Once we find a perfect square, stop adding numbers to the list
// {
//     if (isPerfectSquare(number))
//         break;

//         storageList.Add(number);
// }

// foreach (int number in storageList) //Print the storage list
// {
//     Console.Write(number + " ");
// }
/*
    Store each number in the following List until a perfect square
    is detected.

    Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 
    Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
*/

// EXERCISE NINE: Build a collection of customers who are millionaires
public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}

public class Bank
{
    public string Name { get; set;}
}

public class Millionaire {
   public string Name { get; set; }
   public string Bank { get; set; }
}

public class Program
{
    public static void Main() {
        List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

        List<Customer> millionaires = customers.Where(customer => customer.Balance >= 1000000).ToList();

        foreach (var millionaire in millionaires)
        {
            Console.WriteLine($"Name: {millionaire.Name}, Bank: {millionaire.Bank}, Balance: {millionaire.Balance}");
        }

        /*
            Given the same customer set, display how many millionaires per bank.
            Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

            Example Output:
            WF 2
            BOA 1
            FTB 1
            CITI 1
        */
 
        var millionaireBank = customers
                .Where(customer => customer.Balance >= 1000000)
                .GroupBy(m => m.Bank)
                .Select(group => new {Bank = group.Key, Count = group.Count()});

        foreach (var bank in millionaireBank)
        {
            Console.WriteLine($"{bank.Bank} {bank.Count}");
        }


    }
}