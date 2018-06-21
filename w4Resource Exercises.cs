

//Set a struct called "Date" that contains date, including: year, month and day. 
//Also, define a class called "Phone" that contains a name, number, date of birth and address. 
//Need to create an array that contains objects of type Phone and sort them by name, number, and date.

using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security;

namespace testSpaceStackQuestionThing
{
    class Program
    {
        static void Main()
        {
            Phone[] phones = new Phone[]
            {
            new Phone("Jack", "555-555-5555", 1996,02,13, "123 Some Street"),
            new Phone("Jane", "555-555-5553", 1996,04,15, "123 Some Street"),
            new Phone("Lucy", "555-555-5557", 1997,01,03, "123 Some Street")
            };
            
            Console.ReadKey();

        }
        public struct Date
        {
            int Year, Month, Day;
            public Date(int year, int month, int day)
            {
                this.Year = year;
                this.Month = month;
                this.Day = day;
            }
        }
    }

    public struct Date
    {
        public int Year, Month, Day;
        public Date(int[] date)
        {
            this.Year = date[0];
            this.Month = date[1];
            this.Day = date[2];
        }
    }

    class Phone
    {
        public string Name;
        public string Number;
        public Date DoB = new Date();
        public string Address;

        public Phone(string name, string number, int year, int month, int day, string address)
        {
            this.Name = name;
            this.Number = number;
            this.DoB.Year = year;
            this.DoB.Month = month;
            this.DoB.Day = day;
            this.Address = address;
        }

        public static void SortPhones(Phone[] phones)
        {

        }
    }
}




/*
//File Handling #1 -- create a blank file in the disk newly.
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"C:\Users\rloyd\source\repos\w3Resource Exercises\textfiles";
        FileInfo textfile = new FileInfo(path + "\\textfile.txt");
        textfile.Directory.Create();
        FileStream fs = textfile.Create();

        Console.WriteLine($"A new text file as been created at {path}");

         fs.Close();

        Console.ReadKey();
    }
}


/*
//Searching and Sorting #1 -- sort a list of elements using Shell sort.
using System;

class Program
{
    static void Main()
    {
        int[] numarray = new[] { 2, 17, 3, 5, 1, 4, 20, 9, 15, 8, 13, 14, 7, 19, 18, 6 };
        ShellSort(numarray, numarray.Length);

        foreach (var num in numarray)
        {
            Console.Write($"{ num}, ");
        }

        Console.ReadKey();
    }
    static void ShellSort(int[] nums, int length)
    {
        int inc = 3;
        while(inc > 0)
        {
            for (int i = 0; i < length; i++)
            {
                int j = i;
                int temp = nums[i];
                while ((j >= inc) && (nums[j - inc] > temp))
                {
                    nums[j] = nums[j - inc];
                    j = j - inc;
                }
                nums[j] = temp;
            }
            if (inc / 2 != 0)
                inc = inc / 2;
            else if (inc == 1)
                inc = 0;
            else
                inc = 1;
        }

    }
}


/*
//Structure #1 -- declare a simple structure.
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int inp1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter a number: ");
        int inp2 = Convert.ToInt32(Console.ReadLine());
        Simple inpSum = new Simple (inp1, inp2);
        Console.WriteLine($"The sum of {inp1} and {inp2} is {inpSum.Sum()}");
        Console.ReadKey();
    }
    struct Simple
    {
        public int x;
        public int y;

        public Simple(int inX, int inY)
        {
            x = inX;
            y = inY;
        }

        public int Sum ()
        {
            return x + y;
        }
    }
}


/*
//For Loop #5 -- display the cube of the number upto given an integer.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter the number of cubes you would like: ");
        int input = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i < input +1; i++)
        {
            Console.WriteLine($"Number is: {i} and the cube of {i} is: {cube(i)}");
        }
        Console.ReadKey();
    }
    static int cube(int num)
    {
        return num * num * num;
    }
}


/*
//For Loop #4 -- read 10 numbers from keyboard and find their sum and average.
using System;

class Program
{
    static void Main()
    {
        int input = 0;
        double avg = 0;
        for (int i = 1; i < 11; i++)
        {
            Console.Write("\nPlease enter a number: ");
            input = Convert.ToInt32(Console.ReadLine());
            avg = ((avg * (i - 1)) + input) / i;
            Console.WriteLine("\nThe sum of the numbers entered is {0} and the average is {1}.", avg*i, avg);
        }
        Console.ReadKey();
    }
}


/*
//For Loop #3 -- display n terms of natural number and their sum.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter the number of numbers you would like to see: ");
        int input = Convert.ToInt32(Console.ReadLine());
        numSumCount(input);
        Console.ReadKey();
    }
    static void numSumCount(int nums)
    {
        int sum = 0;
        Console.Write("The first {0} natural numbers are: ", nums);
        for (int i = 1; i <= nums; i++)
        {
            Console.Write(i + ", ");
            sum += i;
        }
        Console.WriteLine("\nThe sum of these numbers is: " + sum);
    }
}


/*
//For Loop #2 -- find the sum of first 10 natural numbers
using System;

class Program
{
    static void Main()
    {
        sumNums(10);
        Console.ReadKey();
    }
    static void sumNums (int count)
    {
        int sum = 0;
        for(int i = 1; i <= count; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
}


/*
//For Loop #1 -- display the first 10 natural numbers.
using System;

class Program
{
    static void Main()
    {
        writeNums(10);
        Console.ReadKey();
    }
    static void writeNums(int count)
    {
        for(int i = 0; i < 11; ++i)
        {
            Console.Write(i + " ");
        }
    }
}


/*
//Conditionals #5 --  read the age of a candidate and determine whether it is eligible for casting his/her own vote.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter your age: ");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0}", QualifyAge(input));
        Console.ReadKey();
    }
    static string QualifyAge(int age)
    {
        if (age >= 18)
            return "Congratulations! You are eligible to vote!";
        return "We are very sorry, but you are not eligible to vote :c";
    }
}


/*
//Conditionals #4 -- find whether a given year is a leap year or not
using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a year and I will determine whether it is a leap year or not: ");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.Write("The year {0} {1} a leap year.", input, isLeap(input) == true? "is" : "is not");
        Console.ReadKey();
    }
    static bool isLeap(int year)
    {
        if (year % 4 == 0)
            return true;
        return false;
    }
}


/*
//Conditionals #3 -- check whether a given number is positive or negative.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a number and I will tell you whether it is positive or negative: ");
        int input = Convert.ToInt32(Console.ReadLine());
        isPos(input);
        Console.ReadKey();
    }
    static void isPos (int num)
    {
        if ( num == 0)
            Console.WriteLine($"{0} is neither positive nor negative.");
        else if (num > 0)
            Console.WriteLine($"The number {num} is positive.");
        else if (num < 0)
            Console.WriteLine($"The number {num} is negative.");
    }
}


/*
//Conditionals #2 -- check whether a given number is even or odd.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter an integer and I will tell you whether it is even or odd: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num % 2 == 0)
            Console.WriteLine($"The number {num} is even.");
        else Console.WriteLine($"The number {num} is odd.");
        Console.ReadKey();
    }
}


/*
//Conditionals #1 -- accept two integers and check whether they are equal or not.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter another number: ");
        int input2 = Convert.ToInt32(Console.ReadLine());
        if (input == input2)
            Console.WriteLine("These numbers are equal.");
        else { Console.WriteLine("These numbers are not equal."); }
        Console.ReadKey();
    }
}


/*
//LINQ #5 -- display the characters and frequency of character from giving string.
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a string:" );
        string input = Console.ReadLine();
        var letters = from l in input orderby l group l by l into g select g;
        foreach(var v in letters)
        {
            Console.WriteLine($"\"{v.Key}\" occurs {v.Count()} times.");
        }
        Console.ReadKey();
    }
}


/*
//LINQ #4 -- display the number and frequency of number from giving array. Grouping with a query into var allows
// data to be manipulated like a dictionary, or list, or array apparently.
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = new[] { 8, 3, 2, 5, 1, 9, 6, 4, 3, 5, 2, 9, 1, 2, 8 };
        var numSets = from n in nums orderby n group n by n into g select g;
        foreach (var num in numSets)
        {
            Console.WriteLine($"{num.Key} appears {num.Count()} times");
        }
        Console.ReadKey();
    }
}


/*
//LINQ #3 -- find the number of an array and the square of each number.
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var sqr20plus = from n in nums where n * n > 20 orderby -n select n;
        foreach(int i in sqr20plus)
        {
            Console.WriteLine($"Number = {i}, Square = {i*i}");
        }
        Console.ReadKey();
    }
}


/*
//LINQ #2 -- find the +ve numbers from a list of numbers using two where conditions in LINQ Query.
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = new[] { -5, 1, -3, -2, 3, 9, -8, 10, -14, 6 };
        var posNums = from i in nums where i > 0 where i < 12 orderby i select i;
        foreach(int i in posNums)
        {
            Console.Write($"{i} ");
        }
        Console.ReadKey();
    }
}


/*
//LINQ #1 -- shows how the three parts of a query operation execute.
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //first comes data
        int[] nums = new[] {1,2,3,4,5,6,7,8,9, };
        //then comes LINQ
        var evens = from i in nums where i % 2 == 0 select i;
        //then comes output
        foreach(int i in evens)
        {
            Console.Write($"{i} ");
        }
        Console.ReadKey();
    }
}


/*
//Recursion #10 -- find the Fibonacci numbers for a n numbers of series using recursion.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the number of Fibonacci numbers that you would like to see: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Fibs(num, 0, 1);
        Console.ReadKey();
    }
    static void Fibs (int count, int fib1, int fib2)
    {
        if (count < 1)
            return;
        Console.WriteLine(fib1);
        Fibs(--count, fib2, fib1 + fib2);
    }
}


/*
//Recursion #9 -- find the factorial of a given number using recursion.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Factorial(5,1));
        Console.ReadKey();
    }
    static int Factorial(int num, int prod)
    {
        if (num < 1)
            return prod;
        return num * Factorial(num - 1, prod);
    }
}


/*
//Recursion #8 -- Check whether a given String is Palindrome or not using recursion.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a string and I will tell you if it is a palindrome: ");
        string input = Console.ReadLine();
        Console.WriteLine(isPal(input, 0));
        Console.ReadKey();
    }
    static bool isPal (string input, int ctr)
    {
        if (ctr > input.Length - ctr)
            return true;
        if (input[input.Length - 1 - ctr] != input[0 + ctr])
            return false;
        return isPal(input, ++ctr);        
    }
}


/*
//Recursion #7 -- check whether a number is prime or not using recursion.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number and I will tell you if it is a prime: ");
        int input = Convert.ToInt32(Console.ReadLine());
        int divisor = Convert.ToInt32(Math.Sqrt(input));
        Console.WriteLine(isPrime(input, divisor));
        Console.ReadKey();
    }
    static bool isPrime (int num, int div)
    {
       if (div < 2)
            return true;
       if (num % div == 0)
            return false;
       return isPrime(num, div - 1);
    }
}


/*
//Recursion #6 -- print even or odd numbers in a given range using recursion - solution allows for user choice of even or odd
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
        PrintNums(21, true);
        Console.ReadKey();
    }
    static void PrintNums(int range, bool even)
    {
        if(range > 0)
        {
            if (even == true && range % 2 == 0)
            {
                PrintNums(range - 2, even);
                Console.WriteLine(range);
            }
            if (even == true & range % 2 != 0)
            {
                PrintNums(range - 1, even);
            }
            if (even == false && range % 2 != 0)
            {
                PrintNums(range - 2, even);
                Console.WriteLine(range);
            }
            if (even == false && range % 2 == 0)
            {
                PrintNums(range - 1, even);
            }
        }
    }
}


/*
//Recursion #5 -- count the number of digits in a number using recursion.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine(Count(12345, 0));
        Console.ReadKey();
    }
    static int Count(int num, int digs)
    {
        if (num < 1)    
            return digs;
        digs++;
        return Count(num / 10, digs);
    }
}


/*
//Recursion #4 -- display the individual digits of a given number using recursion
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
        PrintDigs(12345);
        Console.ReadKey();
    }
    static void PrintDigs (int num)
    {
        if (num < 10)
        {
            Console.Write(num);
            return;
        }
        PrintDigs(num / 10);
        Console.Write(" {0}", (num % 10));
    }
}


/*
//Recursion #3 -- find the sum of first n natural numbers using recursion.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine(SumNums(-10));
        Console.ReadKey();
    }
    static int SumNums(int input)
    {
        if (input > 0)
            input += SumNums(input - 1);
        return input;
    }
}


/*
//Recursion #2 -- print numbers from n to 1 using recursion
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
        PrintNums(10);
        Console.ReadKey();
    }
    static void PrintNums(int input)
    {
        if (input > 0)
        {
            Console.WriteLine(input);
            PrintNums(input - 1);
        }
    }
}


 /*
//Recursion #1 -- print the first n natural number using recursion-Revised solution since learning that code
//following the recursive call, will execute back down the stack once the if condition returns false.
//previously I had thought this would be unreachable code. This solution was subsequently shared by someone  else.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Program
{
    public static void Main()
    {
        PrintNums(10);
        Console.ReadKey();
    }
    static void PrintNums(int input)
    {
        if(input > 0)
        {
            PrintNums(input - 1);
            Console.WriteLine(input);
        }
    }
}


/*
//Recursion #4 sample code from site. Learned from it that code following the recursive method will still
//be executed before the return call is executed because it is all on the stack. In this case, it is
//the n % 10 call. exciting stuff!
using System;
public class RecExercise4
{
    static void Main()
    {

        Console.Write("\n\n Recursion : Display the individual digits of a given number :\n");
        Console.Write("------------------------------------------------------------------\n");
        Console.Write(" Input any number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.Write(" The digits in the number {0} are : ", num);
        separateDigits(num);
        Console.Write("\n\n");
        Console.ReadKey();
    }

    static void separateDigits(int n)
    {
        if (n < 10)
        {
            Console.Write("{0}  ", n);
            return;
        }
        separateDigits(n / 10);
        Console.Write(" {0} ", n % 10);
    }
}

/*
//Recursion #4 -- display the individual digits of a given number using recursion
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int input = Convert.ToInt32(Console.ReadLine());
        printDigit(input);
        Console.ReadKey();
    }
    static void printDigit(int num)
    {
        Console.Write("{0}, ", num.ToString()[0]);
        if (num < 10)
            return;
        string chars = num.ToString().Remove(0, 1);
        printDigit(Convert.ToInt32(chars));
    }
}

/*
//Recursion #3 -- find the sum of the first n natural numbers using recursion
using System;
    class Program
    {
        static void Main()
        {
        Console.Write("How many numbers would you like to sum? ");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum of numbers 0 through {0} is: {1}", input, sumNums(input));
        Console.ReadKey();
        }
        static int sumNums(int length)
        {
            if (length < 1)
                return length;
            return length + sumNums(length - 1);
        }
    }


/*
//Recursion #3 -- find the sum of first n natural numbers using recursion
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace cFun
{
    class Program
    {
        static void Main()
        {
            Sum(25);
            Console.ReadKey();
        }

        public static void Sum(int length)
        {
            Stack<int> numStack = new Stack<int>();
            SumNumStack(numStack, length);
        }
        private static void SumNumStack(Stack<int> stackIn, int length)
        {
            stackIn.Push(length);
            if(length < 1)
            {
                while(stackIn.Count() > 0)
                {
                    length += stackIn.Pop();
                }
                Console.WriteLine(length);
                return;
            }
            SumNumStack(stackIn, length - 1);
        }
    }
}


/*
//Recursion #2 -- print numbers from n to 1 using recursion
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cFun
{
    class Program
    {
        static void Main()
        {
            CountDown(20);
            Console.ReadKey();
        }

        public static void CountDown (int length)
        {
            Console.WriteLine(length);
            if (length < 1)
            {
                return;
            }
            CountDown(length - 1);
        }
    }
}


/*
//Recursion #1 -- print the first n natural number using recursion
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cFun
{
    class Program
    {
        public static Stack numStack = new Stack();

        static void Main()
        {
            PrintNums(10);
            Console.ReadKey();
        }
        
        public static void PrintNums (int length)
        {
            if (length < 1)
            {
                while(numStack.Count > 0)
                {
                    Console.WriteLine(numStack.Pop());
                }
                return;
            }
            numStack.Push(length);
            PrintNums(length - 1);
        }
    }
}


/*
//Basic Exercise #62 -- reverse the strings contained in each pair of matching parentheses in a given string
//and also remove the parentheses within the given string.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cFun
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(RemRev("ab(cd(ef)gh)ij"));

            Console.ReadKey();
        }

        public static string RemRev(string str)
        {
            int lastOp = str.LastIndexOf('(');
            if(lastOp == -1)
            {
                return str;
            }
            int firstCl = str.IndexOf(')', lastOp);
            return RemRev(str.Substring(0, lastOp) + new string(str.Substring(lastOp + 1, firstCl - lastOp-1).Reverse().ToArray()) + str.Substring(firstCl + 1));
        }
    }
}



/*
//Basic Exercise #61 -- sort the integers in ascending order without moving the number -5.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Data.SqlTypes;

namespace cFun
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 1, 8, 2, -5, 4, 9, 7, 6 };
            Console.WriteLine(string.Join(",", sort(nums)));

            Console.ReadKey();
        }

        public static int[] sort(int[] num)
        {
            int[] outs = num.Where(x => x != -5).OrderBy(x => x).ToArray();
            int c = 0;
            return num.Select(x => x != -5 ? outs[c++] : -5).ToArray();
        }
    }
}

/*
//Basic Exervise #18 -- check two given integers and return true if one is negative and one is positive.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cFun
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 < 0 ^ num2 < 0);

            Console.ReadKey();
        }
    }
}

/*
//Basic Exercise #62 -- reverse the strings contained in each pair of matching parentheses in a given string 
//and also remove the parentheses within the given string.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cFun
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine(swap(input));

            Console.ReadKey();
        }
        
        public static string swap(string phrase)
        {
            int dex1 = phrase.IndexOf("(");
            int dex2 = phrase.IndexOf(")");
            string sOut1 = phrase.Substring(dex1, dex2-dex1+1);
            phrase = phrase.Remove(dex1, dex2-dex1+1);
            Console.WriteLine(phrase);
            int dex3 = phrase.IndexOf("(");
            int dex4 = phrase.IndexOf(")");
            string sOut2 = phrase.Substring(dex3, dex4 - dex3 +1);
            phrase = phrase.Insert(dex1, sOut2);
            phrase = phrase.Remove(phrase.IndexOf("("), 1);
            phrase = phrase.Remove(phrase.IndexOf(")"), 1);
            dex3 = phrase.IndexOf("(");
            dex4 = phrase.IndexOf(")");
            phrase = phrase.Remove(phrase.IndexOf("("), sOut2.Length);
            phrase = phrase.Insert(dex3, sOut1);
            phrase = phrase.Remove(phrase.IndexOf("("), 1);
            phrase = phrase.Remove(phrase.IndexOf(")"), 1);

            return phrase;
        }
    }
}


/*
//Basic Exercise #61 -- sort the integers in ascending order without moving the number -5.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cFun
{
    class Program
    {
        static void Main()
        {
            int[] tests = new int[] { 3, 8, 2, 4, -5, 7, 6, 9, 1 };
            Console.WriteLine(string.Join(", ", sort(tests)));

            Console.ReadKey();
        }

        public static int[] sort(int[] ints)
        {
            int[] outs = ints.Where(v => v != -5).OrderBy(v => v).ToArray();
            int c = 0;
            return ints.Select(x => x != -5 ? outs[c++] : -5).ToArray();
        }
    }
}

//Baisc Exerise #61 -- This was my first go before I learned this can be addressed much more elegantly with lambda and LINQ!
/*
namespace cFun
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tests = new[] { 3, 8, 2, 4, -5, 7, 6, 9, 1 };
            sort(tests);

            Console.ReadKey();
        }

        public static void sort (int[] ints)
        {
            int[] outs1st = new int[] { };
            int[] outs2nd = new int[] { };
            List<int> outsAll = new List<int>();

            Array.Resize(ref outs1st, Array.IndexOf(ints, -5) + 1);
            Array.Copy(ints, outs1st, Array.IndexOf(ints, -5));

            Array.Resize(ref outs2nd, ints.Length - Array.IndexOf(ints, -5) - 1);
            Array.Copy(ints, Array.IndexOf(ints, -5) + 1, outs2nd, 0, ints.Length - Array.IndexOf(ints, -5)-1);

            Array.Sort(outs1st);
            Array.Sort(outs2nd);

            outsAll.AddRange(outs1st);
            outsAll.Add(-5);
            outsAll.AddRange(outs2nd);

            Console.WriteLine(string.Join(",", outsAll));
        }
    }
}




/*
//Basic Exercise #60 -- calculate the sum of all the intgers of a rectangular matrix except those integers which are located below an intger of value 0.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace cFun
{
    class Program
    {
        //Example code from site. The 'for' loop works because it sums vertically and fails to continue on the first
        //occurence of a 0 in the column due to the " && my_matrix[j][i] > 0" condition.
        public static int sum_matrix_elements(int[][] my_matrix)
        {
            int x = 0;
            for (int i = 0; i < my_matrix[0].Length; i++)
                for (int j = 0; j < my_matrix.Length && my_matrix[j][i] > 0; j++)
                    x += my_matrix[j][i];

            return x;
        }

        public static void Main()
        {
            Console.WriteLine(sum_matrix_elements(
                new int[][] {
                    new int[]{0, 2, 3, 2},
                    new int[]{0, 6, 0, 1},
                    new int[]{4, 0, 3, 0}
                }));
            Console.WriteLine(sum_matrix_elements(
                new int[][] {
                    new int[]{1, 2, 1, 0 },
                    new int[]{0, 5, 0, 0},
                    new int[]{1, 1, 3, 10 }
                }));
            Console.WriteLine(sum_matrix_elements(
                new int[][] {
                    new int[]{1, 1},
                    new int[]{2, 2},
                    new int[]{3, 3},
                    new int[]{4, 4}
                }));

            Console.ReadKey();
        }
    }
}
        /*
        static void Main()
        {
            int[,] nums = new[,] { {0, 2, 3, 2 },
                                   {0, 6, 0, 1 },
                                   {4, 0, 3, 0 } };

            Console.WriteLine(noZero(nums));
            Console.ReadKey();

        }
        //calculate sum of numbers in a matrix which do not fall beneath a 0.
        public static int noZero(int[,] numbers)
        {
            var sum = 0;
            for (var v = 0; v < numbers.GetLength(0); v++)
            {
                for (var w = 0; w <numbers.GetLength(1); w++)
                {
                    if(v == 0)
                    {
                        sum += numbers[v,w];
                        continue;
                    }
                    for (var x = v-1; x >= 0; x--)
                    {
                        if (numbers[x,w] == 0)
                        {
                            break;
                        }
                        sum += numbers[v,w];
                    }
                }
            }
            return sum;
            }
    }
}


/*
//Basic Exercise #59 -- check whether it is possible to create a strictly increasing sequence from a given sequence of integers as an array.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cFun
{
    class Program
    {
        static void Main()
        {
            int[] strIn = new[] {1,3,4,5 };
            Console.WriteLine(allUnique(new int [] { 1, 3, 4, 5 }));
            Console.WriteLine(allUnique(new int[] { 4, 3, 2, 5 }));
            Console.ReadKey();
        }
        //checks if elements of an array may be arranged in a strictly increasing order.
        public static bool allUnique (int[] arrIn)
        {
            Array.Sort(arrIn);
            return (arrIn.Last() - arrIn.First() +1 == arrIn.Length);
        }
    }
}


/*
//Basic Exercise #58 -- Write a C# program which will accept a list of integers and checks how many integers are needed to complete the range
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;

namespace cFun
{
    class Program
    {
        static void Main()
        {
            int[] strIn = new[] { 1, 3, 4, 7, 9 };
            Console.WriteLine(missInts(strIn));
            Console.ReadKey();
        }
        
        public static int missInts (int[] ints)
        {
            int count = 0;
            Array.Sort(ints);
            for (var v = 0; v < ints.Length-1; v++)
            {
                count += ints[v + 1] - ints[v] - 1;
            }
            return count;
        }
    }
}


/*
//Basic Exercise #57 -- find the pair of adjacent elements that has the highest product of an given array of integers.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cFun
{
    class Program
    {
        static void Main()
        {
            int[] iArr = new[] { 1, 2, 3, 4, 8, 1, 9, 3, 5, 2 };
            int prod = 0;
            for (var i = 0; i < iArr.Length - 1; i++)
            {
                prod = Math.Max(iArr[i] * iArr[i + 1], prod);
            }
            Console.WriteLine(prod);
            Console.ReadKey();
        }
    }
}


/*
//Basic Exercise #56 -- check if a given string is a palindrome or not
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cFun
{
    class Program
    {
        static void Main()
        {
            string input;
            Console.Write("Please enter a string and I will tell you whether it is a palindrome or not: ");
            input = Console.ReadLine();
            Console.WriteLine(string.Join("", input.ToCharArray().Reverse()));
            Console.WriteLine(input == string.Join("", input.ToCharArray().Reverse()));
            Console.WriteLine(isPalindrome(input));
            Console.ReadKey();
        }

        public static bool isPalindrome (string str)
        {
            for(var i = 0; i <str.Length; i++)
            {
                if(str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}


/*
//Basic Exercise #55 -- find the pair of adjacent elements that has the largest product of an given array.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;

namespace cFun
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] iAr = new[] { 1, 2, 4, 1, 3, 5, 0, 1 };
            Console.WriteLine(LP(iAr));
            Console.ReadKey();
        }

        public static int LP (int[] array)
        {
            int LProd = 0;
            for (var i = 0; i < array.Length - 1; i++) 
            {
                LProd = (array[i] * array[i + 1]) > LProd ? array[i] * array[i + 1] : LProd;
            }
            return LProd;
        }
    }
}


/*
//Basic Exercise #54 -- get the century from a year
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year and I will tell you the century in which it falls: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int century = year / 100 + (year % 100 == 0? 0:1);
            Console.WriteLine(century);
            Console.ReadKey();
        }
    }
}


/*
//Basic Exercise #53 --  check if an array contains an odd number
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace cFun
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iAr = new[] { 2, 4, 7, 8, 6 };
            for (var i = 0; i < iAr.Length; i++)
            {
                if (iAr[i] % 2 != 0)
                {
                    Console.WriteLine(iAr.Contains(iAr[i]));
                    break;
                }
            }   
            Console.ReadKey();
        }
    }
}


/*
//Basic Exercise #52 -- create a new array of length containing the middle elements of three arrays (each length 3) of integers.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace w3Resource_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iAr1 = new[] { 1, 2, 5 };
            int[] iAr2 = new[] { 0, 3, 8 };
            int[] iAr3 = new[] { -1, 0, 2 };
            int[] iAr4 = new[] { iAr1[1], iAr2[1], iAr3[1] };
            foreach (int i in iAr4) { Console.Write($"{i}, "); }
            Console.ReadKey();
        }
    }
}


/*
//Basic Exerise #51 -- get the larger value between first and last element of an array (length 3) of integers.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace w3Resource_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArr = new[] { 1, 2, 5, 7, 8 };
            var high = 0;
            for (var i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] > high) { high = iArr[i]; }
            }
            Console.WriteLine(high);
            if (iArr.First() > iArr.Last())
            {
                Console.WriteLine(iArr.First());
            }
            else { Console.WriteLine(iArr.Last()); }
            Console.ReadKey();
        }
    }
}


/*
//Basic Exervise #50 -- Write a C# program to rotate an array (length 3) of integers in left direction
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace w3Resource_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArr = new[] { 1, 2, 8 };
            iArr[0] += iArr[1]; iArr[1] += iArr[2];
            iArr[2] -= (iArr[1] - iArr[0]); iArr[0] -= iArr[2]; iArr[1] -= iArr[0];
            Console.WriteLine(string.Join(", ", iArr));
            Console.ReadKey();
        }
    }
}


/*
// Basic Exercise #49 -- Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace w3Resource_Exercises
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] iArr1 = new[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] iArr2 = new[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            Console.WriteLine((iArr1.First() == iArr2.First()) || (iArr1.Last() == iArr2.Last()));
            Console.ReadKey();
        }
    }
}


/*
///Basic Exercise #48 -- Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace w3Resource_Exercises
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] iArr = new[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine((iArr.First() == iArr.Last()) && iArr.Length > 1);
            Console.ReadKey();
        }
    }
}


/*
//Basic Exercise #47 -- Write a C# program to compute the sum of all the elements of an array of integers.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace w3Resource_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArr = new[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine(iArr.Aggregate((a, b) => a +b));
            Console.ReadKey();
        }
    }
}


/*
//Basic Exercise #46 -- Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace w3Resource_Exercise
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] iArray = new[] { 1, 3, 5, 7, 3, 5, 42, 13, 46, 15 };
            Console.WriteLine(lastOrFirst(input, iArray));
            Console.WriteLine((iArray.First() == input) || (iArray.Last() == input));

            Console.ReadKey();
        }

        static public bool lastOrFirst(int inp, int[] iArr)
        {
            if (inp == iArr.First() || inp == iArr.Last())
            {
                return true;
            }
            return false;
        }
    }
}

/*
//Basic Exercise #45
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace w3Resource_Exercises
{
    class Program
    {
        static void Main (string[] args)
        {
            List<int> intArray = new List<int> ();
            Random rnd = new Random();
            int input;


            //populate list
            for (int i = 0; i < 100; i++)
            {
                intArray.Add(i % 5 + rnd.Next(7));
            }

            //populate array
            Console.Write("Stored array: {0}", string.Join(", ", intArray));
            Console.WriteLine();

            Console.Write("Please enter a an integer and I will count the number of times it appears in the stored array: ");
            input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number {0} occurs {1} times in the stored array.", input, intArray.Count(i => i == input));


            Console.ReadKey();

        }
    }
}


/*
//Basic Exercise #44
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml;

namespace w3Resource_Exercises
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter a string and I will make a new one from ever other character:");
            string input = Console.ReadLine();

            var output = from c in input where input.IndexOf(c) % 2 != 0 select c;

            Console.WriteLine(string.Join("", output));

            Console.ReadKey();
        }
    }
}

/*
//Basic Exercise #43
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace w3Resource_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("please enter a string and I will tell you if it begins with a 'w' and is immediately followed by two sets of 'ww': ");
            input = Console.ReadLine();
            Console.WriteLine(Checker(input));
            Console.ReadKey();
        }

        public static bool Checker(string inputString)
        {
            if (inputString.Length > 4 && inputString.StartsWith("w") && inputString.Substring(1,2) == "ww" && inputString.Substring(3,2) == "ww")
            {
                return true;
            }
            return false;
        }
    }
}

/*
//Basic Exercise #42
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace w3Resource_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<char> output = new List<char>();

            Console.WriteLine("Please enter a string: ");
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (i < 4)
                {
                    output.Add(char.ToUpper(input[i]));
                }
                else { output.Add(input[i]); }
            }
            foreach(char c in output)
            {
                Console.Write(c);
            }
            Console.ReadKey();            
        }
    }
}

/*
//Basic Exerise #41
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace w3Resource_Exercises
{
    class Program
    {
        static void Main (string[] args)
        {
            string input;
            char w = 'w';

            Console.WriteLine($"Please enter a string of characters and I will detremine if it contains the character {w} between 1 and 3 times: " );
            input = Console.ReadLine();

            
            //if (input.Contains('w'))
            //{
            //    var ws = from c in input where c == w select c;
            //    Console.WriteLine($"The character '{w}' occurs {ws.Count()} times in the string that you entered.");
            //}
            //else { Console.WriteLine("The string that you entered does not contain a 'w'"); }
            

            var ws = from c in input where c == w select w;

            if (ws.Count() < 4 && ws.Count() > 0)
            {
                Console.WriteLine("The string that you entered contains a 'w' between 1 and 3 times.");
            }
            else { Console.WriteLine("The string that you entered does not contain a 'w' between 1 and 3 times."); }

            Console.ReadKey();
        }
    }
}
    
/*
//Basic Exercise #40
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace w3Resource_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntrl = 20;
            int inp1;
            int inp2;

            Console.WriteLine("Please enter an integer: ");
            inp1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another integer and I will determine which is closer to 20: ");
            inp2 = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(cntrl-inp1) > Math.Abs(cntrl - inp2))
            {
                Console.WriteLine($"{inp2} is closer to {cntrl} than {inp1}.");
            }
            else { Console.WriteLine($"{inp1} is closer to {cntrl} than {inp2}."); }

            Console.ReadKey();
        }
    }
}

/*
//basic exercise # 39
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;

namespace w3Reasource_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[3];
            Queue intQueye = new Queue();
            List<int> intList = new List<int>();

            for(int i = 0; i <3; i++)
            {
                Console.WriteLine("Please enter an integer:");
                intList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Unsorted intList: {0}", string.Join(", ", intList));
            intList.Sort();
            Console.WriteLine("Sorted intList: {0}", string.Join(", ", intList));

            Console.WriteLine($"Largest number {intList[2]}, Smallest number: {intList[0]}");

            Console.ReadKey();
        }
    }
}


/*
//Basic Exercise # 38
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace w3Resource_Exercises
{
    class Program
    {
        static void Main (string[] args)
        {
            string input = "PHP";
            Console.WriteLine(input);

            if (input.StartsWith("PH"))
            {
                string output = input.Substring(0, 2);
                Console.WriteLine(output);
            }

            Console.ReadKey();
        }
    }
}

/*
//Basic Exercise # 37
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3Resource_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string aString = "PHP Tutorial";
            Console.WriteLine(aString);

            //if(Convert.ToString(aString[1]) == "H" && Convert.ToString(aString[2]) == "P")
            if(aString.Contains("HP") && aString.IndexOf("HP") == 1)
            {
                aString = aString.Remove(1, 2);
                Console.WriteLine(aString);

                Console.ReadKey();
            }

        }
    }
}
*/
