using System;

namespace Allee_ClassActivity01
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            Console.WriteLine("Enter a string of words and i will count it.");
            string myInput = Console.ReadLine();
            int numberOfWords = wordCounter(myInput);
            
            //2
            Console.WriteLine("Enter your first and last name and i will return the initials.");
            string myInput2 = Console.ReadLine();
            string initials = initialReturner(myInput2);
            Console.WriteLine(initials);

            //3
            Console.WriteLine("Enter a string and i will return it backwards.");
            string myInput3 = Console.ReadLine();
            string reverseString = backwardStringReturner(myInput3);
            Console.WriteLine(reverseString);

            //4
            Console.WriteLine("Enter a number and i will return the sum of all numbers divisible by five upto the given number.");
            string myInput4 = Console.ReadLine();
            int  answer = multipleOf5Sum(Int32.Parse(myInput4));
            Console.WriteLine(answer);

            //5
            Console.WriteLine(Math.Pow(3, 4));
        }

        static int wordCounter(string givenStr)
        {


            int countWords = 0;
            string[] words = givenStr.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                countWords++;
            }
            Console.WriteLine($"there are {countWords} words in the given string.");
            return countWords;
        }

        static string initialReturner(string givenStr)
        {
            string[] firstAndLast = givenStr.Split(" ");
            string first = firstAndLast[0];
            string last = firstAndLast[1];
            string initials = first.Substring(0, 1) + last.Substring(0,1);
            return initials;
        }


        static string backwardStringReturner(string givenStr)
        {
            Char [] myArray = givenStr.ToCharArray();
            Array.Reverse(myArray);
            return new string(myArray);
        }

        static int multipleOf5Sum (int givenInt)
            //first n numbers that ARE multiples of 5
        {
            int sum = 0;
            int count = 1;
            // while there are more multiples of 5 to add together
            while(givenInt != 0)  // how do i not declare a new var here???
            {
                //if the number in question is divisible by 5
                if (count % 5 == 0)
                {
                    // add that number to the sum
                    sum += count;
                    // reduce the number of multiples of 5 to grab
                    givenInt--;
                }
                //goto next number
                count++;
            }
            return sum;
        }
    }

}
