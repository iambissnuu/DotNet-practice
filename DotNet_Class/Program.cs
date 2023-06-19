using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace DotNet_Class
{

    /*
    class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public int sum(int x, int y)
        {

            return x + y;
        }

        public Person(){

        }

        // parameters are generally in camelCase & properties in PascalCase &
        //for method either one is fine
        public Person(string firstName, int id)
        {
            Name = firstName;
            Id = id;
        }

   
    }

    */

    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Person p1 = new Person();
            p1.Name = "Bishnu";
            p1.Id = 1;
            Person p2 = new Person("Bish",5);
            //
          
            Console.WriteLine("Value for p1 object is: "+p1.Id+" "+p1.Name);
            Console.WriteLine("Value for p2 object is: "+p2.Id+" "+p2.Name);

            Console.ReadKey();

            */

           
            /*
            //Write a program that prints the numbers from 1 to 100.
            //But for multiples of three, print "Fizz" instead of the number,
            //and for the multiples of five,print "Buzz".
            //For numbers that are multiples of both three and five, print "FizzBuzz".

            for(int i=1; i<=100; i++)
            {
                if(i%3 == 0 && i%5 ==0)
                {
                    Console.WriteLine("FizzBuzz");
                }else if(i%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }else if(i%5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else { Console.WriteLine(i); }
            }


            */




            /*
            //Find simple interest
            int principle, time, rate;
            Console.WriteLine("Let's find Simple interest");
            Console.WriteLine("Please Enter the Principle amount: ");
            principle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the time in years: ");
            time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter rate in percentage: ");
            rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe Simple interest calculated is: " + principle * time * rate / 100);
                        
            Console.ReadKey();
            */



            /*
            //a program to take user input
            Console.WriteLine("Please provide your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("\nYour name is: "+name+"\n");
            //Console.ReadKey();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("\tLets add two numbers");
            Console.WriteLine("------------------------------------");
            int num1, num2, sum;
            Console.Write("\n\tplease enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tPlease enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("\tThe sum of two numbers is: " + sum);
            Console.ReadKey();
            */


            /*

            //Write a program that checks whether a given string is a palindrome or not.
            //A palindrome is a word, phrase, number, or other sequence of characters
            //that reads the same forward and backward.

            Console.WriteLine("Write Your Word: ");
            var word = Console.ReadLine();
            Console.WriteLine("Is "+word+" a palindrome?");
            Console.WriteLine("-------Let's see-------");

                int left = 0;
                int right = word.Length - 1;

                if (word[left] == word[right])
                {
                    Console.WriteLine("oh, yes. It is a palindrome");
                }
                else
                {
                    Console.WriteLine("oops! you missed it.");
                }

            */



            /*
            //Write a program to generate the Fibonacci series up to a specified number of terms.
            //The Fibonacci sequence is formed by adding the two previous numbers in the sequence,
            //starting with 0 and 1.

            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first " + num + " fabonacci numbers are listed below: ");

            int first = 0; int second = 1;
            for(int i = 1; i <= num; i++)
            {
                int next = first + second;
                Console.WriteLine(next);

                first = second;
                second = next;
            }
            Console.WriteLine();

            */




        }
    }
}
