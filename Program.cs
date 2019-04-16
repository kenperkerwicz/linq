using System;
using System.Linq;
using System.Collections.Generic;

namespace linqGroupBy
{
    public class SalesReportEntry
    {
        public string ReportNeighborhood { get; set; }
        public double ReportTotalSales { get; set; }
    }
    public class Kid {
        public string FullName {get; set;}
        public string Neighborhood {get; set;}
        public double Sales {get; set;}
    }
    public class Person
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public DateTime DOB {get; set;}
        public List<string> NickNames {get; set;}
    }
    internal class ReportEntry
    {
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public int NickNameCount { get; set; }

    }

    public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}
    class Program
    {
        static void Main(string[] args)
        {
            // List<Person> people = new List<Person>(){
            //     new Person(){
            //         FirstName = "Ed", LastName = "Reed", DOB = new DateTime(1970, 04, 10),
            //         NickNames = new List<string>(){
            //             "Ed", "Goose", "Beast"
            //         }
            //     },
            //     new Person(){
            //         FirstName = "Dwayne", LastName = "Johnson", DOB = new DateTime(1966, 10, 11),
            //         NickNames = new List<string>(){
            //             "The Rock"
            //         }
            //     },
            //     new Person(){
            //         FirstName = "Bob", LastName = "Smith", DOB = new DateTime(1944, 12, 25),
            //         NickNames = new List<string>(){
            //             "Robby", "Smitty", "Bud", "The Tiger"
            //         }
            //     },

            // };

            // //Use LINQ to generate a report a report that includes the pesron's name, their DOB and the number of nicknames they have
            // // For example: Bob Smith (12/25/44) has 4 Nickname(s)

            // List<ReportEntry> nickNameReport = people.Select(p =>
            //     new ReportEntry {
            //         FullName = $"{p.FirstName} {p.LastName}",
            //         DOB = p.DOB,
            //         NickNameCount = p.NickNames.Count
            //     }
            // ).ToList();

            // foreach (ReportEntry re in nickNameReport)
            // {
            //     Console.WriteLine($"{re.FullName} ({re.DOB.ToShortDateString()}) has {re.NickNameCount} Nickname(s)");
            // }



                /// Neighborhood ///


            // List<Kid> kids = new List<Kid>(){
            //     new Kid(){
            //         FullName = "Billy Smith", Neighborhood = "Nolensville", Sales = 67.16
            //     },
            //     new Kid(){
            //         FullName = "Jason Sync", Neighborhood = "North Nashville", Sales = 13.16
            //     },
            //     new Kid(){
            //         FullName = "Kyle Edwards", Neighborhood = "Nolensville", Sales = 117.10
            //     },
            //     new Kid(){
            //         FullName = "Avery Barkley", Neighborhood = "The Nations", Sales = 97.16
            //     },
            //     new Kid(){
            //         FullName = "Audrey Ellington", Neighborhood = "Nolensville", Sales = 57.18
            //     },
            //     new Kid(){
            //         FullName = "Juanita Voss", Neighborhood = "North Nashville", Sales = 147.12
            //     },
            //     new Kid(){
            //         FullName = "Scott Avett", Neighborhood = "North Nashville", Sales = 56.11
            //     }
            // };

            //  List<SalesReportEntry> salesReport = (from kid in kids
            //  //dealing with kids list
            //     group kid by kid.Neighborhood into neighborhoodGroup
            // //now dealing with neighborhoodGroup list
            //     select new SalesReportEntry {
            //         ReportNeighborhood = neighborhoodGroup.Key,
            //         ReportTotalSales = neighborhoodGroup.Sum(kidObj => kidObj.Sales)
            //     }).OrderByDescending(sr => sr.ReportTotalSales).ToList();

            // foreach(SalesReportEntry entry in salesReport)
            // {
            //     Console.WriteLine($"{entry.ReportNeighborhood}, {entry.ReportTotalSales}");
            // }




                //LINQ FRUITS //

// List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

// IEnumerable<string> LFruits = fruits.Where(f => f[0] == 'L');

// foreach (var item in LFruits)
// {
//  Console.WriteLine(item);
// }




// Which of the following numbers are multiples of 4 or 6


            // DONT FORGET ToList() METHOD ///




// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };

//  IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0 ).ToList();


// foreach (var item in fourSixMultiples)
// {
//  Console.WriteLine(item);
// }




                    // NAMES //



// Order these student names alphabetically, in descending order (Z to A)
// List<string> names = new List<string>()
// {
//     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
//     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
//     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
//     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
//     "Francisco", "Tre"
// };

// List<string> descend = names.OrderByDescending(sr => sr).ToList();


//  foreach (var item in descend)
// {
//  Console.WriteLine(item);
// }




// AGGREGATE OPERATORS //

// Output how many numbers are in this list
// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };


// //  List<int> qty = numbers.Count().ToList();


//    Console.WriteLine(numbers.Count());



        //HOW MUCH MONEY HAVE WE MADE //

// List<double> purchases = new List<double>()
// {
//     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
// };

//     Console.WriteLine(purchases.Sum());



                // MAX METHOD //


// List<double> prices = new List<double>()
// {
//     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
// };

//  Console.WriteLine(prices.Max());



                        //


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


// // Build a collection of these numbers sorted in ascending order
// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };



        }
    }
}