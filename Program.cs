using System.Runtime.ConstrainedExecution;

namespace Code_Academy_LINQ_20_30__Task_5._1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------Exercise 21---------------------------------------------------------------
            //List<string> MyList = new List<string>();
            //MyList.Add("m");
            //MyList.Add("n");
            //MyList.Add("o");
            //MyList.Add("p");
            //MyList.Add("q");


            //var res1 = from y in MyList
            //               select y;

            //foreach (var i in res1)
            //{
            //    Console.WriteLine(i);
            //}

            //MyList.RemoveRange(1, 3);

            //var res2 = from z in MyList
            //              select z;
            //Console.Write("\nResult: \n");
            //foreach (var j in res2)
            //{
            //    Console.WriteLine(j);
            //}

            //-----------------------------------------------------------------Exercise 22---------------------------------------------------------------
            //Console.WriteLine("Enter number");
            //int n = int.Parse(Console.ReadLine());
            //string[] arrayofstring = new string[n];

            //for(int i = 0; i<n; i++)
            //{
            //    Console.WriteLine("Enter strings: ");
            //    arrayofstring[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Enter index");
            //int m = int.Parse(Console.ReadLine());
            //IEnumerable<string> result = from i in arrayofstring
            //                             where i.Length >= m
            //                             orderby i
            //                             select i;
            //Console.Write("\nResult: \n", result);
            //foreach (string j in result)
            //    Console.WriteLine("Item: {0}", j);
            //-----------------------------------------------------------------Exercise 23---------------------------------------------------------------
            //int [] numset = { 1, 2, 3 ,4};

            //char[] charset = { 'X', 'Y', 'Z' };

            //var Task = from letterList in charset
            //           from numberlist in numset
            //           select new { letterList, numberlist };

            //Console.WriteLine("Result: ");

            //foreach(var i in Task)
            //{
            //    Console.WriteLine(i);
            //}

            //-----------------------------------------------------------------Exercise 24---------------------------------------------------------------
            //int[] numbers = { 1, 2, 3 };

            //char[] chars = { 'X', 'Y', 'Z' };

            //string[] strings = { "Green", "Orange", "Pink" };

            //var Task = from number in numbers
            //           from letter in chars
            //           from color in strings
            //           select new { letter, number, color };

            //Console.WriteLine("Result: ");
            //foreach (var i in Task)
            //{
            //    Console.WriteLine(i);
            //}
            //-----------------------------------------------------------------Exercise 25---------------------------------------------------------------
            
        }
    }
}