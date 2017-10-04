using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int favoriteNumber

            ////int[] favoriteNumbers = { 1, 2, 3, 4, 5, 6 };

            //// string[] studentName = { "Raz", "Monica", "Brian", "Ali", };

            ////Console.WriteLine(favoriteNumbers[0]);
            ////Console.WriteLine(studentName[2]);
            //string[] vactionplace = { "florida", "Bahams", "mugdishu", "china", "uk", "paris", "kenya", "mexico", "somali", "malta" };

            //Console.WriteLine(vactionplace[0]);
            //Console.WriteLine(vactionplace[9]);
            //int[] chilAge = { 12, 13, 14 };
            //Console.WriteLine(chilAge[1]);
            ////decimal[] gpaScore = { 2.5, 2.6, 3.2, 3.9, };

            //int[] numbers = new int[4];

            //numbers[0] = 43;
            //numbers[1] = 12;
            //Console.WriteLine("please enter a number");
            //numbers[2] = int.Parse(Console.ReadLine());
            //numbers[3] = int.Parse(Console.ReadLine());

            //Console.WriteLine(numbers[1]);
            /////to manipulate and replace the data inside the array

            //string[] daysOfweek = new String[7];
            //daysOfweek[0] = "sun";
            //daysOfweek[1] = "mon";
            //daysOfweek[2] = "tues";
            //daysOfweek[3] = "wed";
            //daysOfweek[4] = "thu";
            //DayOfWeek[5] = "frdy";
            //daysOfweek[6] = "stu";


            //int[] numberStudent = new int[5];

            //Console.WriteLine(daysOfweek.Length);
            //string[] lastname = { "farah" };
            //Console.WriteLine(lastname.Length);


            //int index = examplestringarray.Length;
            //index = index - 2;
            //Console.WriteLine(examplestringarray[index]);

            //string[] examplestringarray = { " this ", "is", "an", "array", "of", "works" };


            //Console.WriteLine(examplestringarray[examplestringarray.Length - 1]);

            //int arraysize = int.Parse(Console.ReadLine());
            //int[] newAray = new int[arraysize];

            //Console.WriteLine(" the array is of length" + newAray.Length);
            
            //string[] birthMonths = { "october", "july", "october", "may" };
            //Console.WriteLine(Array.IndexOf(birthMonths, "october"));
            //int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            //Console.WriteLine(Array.LastIndexOf(numbers, 4));
            //Array.Reverse(numbers);
            //Console.WriteLine(numbers[0]);
            //Array.Sort(numbers);
            //Console.WriteLine(numbers[numbers.Length - 1]);
            /*Declare and initialize a string array of first names. Choose a name to find and print the IndexOf*/

            string[] firstNames = { "yusuf", "kevin", "ali", "david" };
            Console.WriteLine(Array.IndexOf(firstNames, "david"));


            /*Create an array of lucky numbers. Each number should repeat at least once. Choose a lucky number, find and print the last index of it*/
            int[] luckyNumbers = { 1, 3, 3, 3,1 ,1 ,2,2,2 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 3));
            /*Create an array of alphabet characters. Print the first index of the array. Now reverse the array and print the first index*/
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'd' };
            Console.WriteLine(alphabet[0]);
            Array.Reverse(alphabet);
            Console.WriteLine(alphabet[0]);

            S





        }


    }
}
