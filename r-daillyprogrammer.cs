using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace r_dailyprogrammer
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("This is just a test");
            Console.WriteLine("this is another test");
            Console.WriteLine("here is one more");
            Console.WriteLine("trying this out");
            Console.WriteLine("okay, here we go");
        }
    }
}

/*
//[2018-05-16] Challenge #361 [Intermediate] ElsieFour low-tech cipher - link: https://www.reddit.com/r/dailyprogrammer/comments/8jvbzg/20180516_challenge_361_intermediate_elsiefour/
//utlizes Marker.cs and KeyTable.cs. Uncomment those too to run.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace r_dailyprogrammer
{
    class Program
    {
        public static KeyTable cKey = new KeyTable();

        static void Main(string[] args)
        {
            string encryptedIn;
            string keyIn;

            Console.WriteLine("Type /quit at any time to end decryptions.");

            while(true)
            {
                Console.WriteLine("Please enter an encrypted text string");
                encryptedIn = Console.ReadLine();
                if (encryptedIn == "/quit") { break; };

                Console.WriteLine("Please enter the associated key");
                keyIn = Console.ReadLine();
                if (keyIn == "/quit") { break; };

                Console.WriteLine();
                Decrypt(encryptedIn, keyIn);
                Console.WriteLine();
            }            
            Console.WriteLine("\n press any key to continue...");
            Console.ReadKey();
        }

        public static void Decrypt(string encrypted, string key)
        {
            Marker cMarker = new Marker();
            Marker pText = new Marker();
            Marker cText = new Marker();
            Queue decrypted = new Queue();

            cKey.Populate(key);

            cMarker.Text = cKey.Table[0, 0];

            for (int i = 0; i < encrypted.Length; i++)
            {
                cText.Text = encrypted[i];

                cText.Update();
                pText.Update(cText);
                
                pText.MoveNeg(KeyTable.cRange.IndexOf(cMarker.Text) % 6, KeyTable.cRange.IndexOf(cMarker.Text) / 6);

                decrypted.Enqueue(pText.Text);
                cKey.Permute(cKey.Table, pText, cText, cMarker);
            }

            Console.Write("Decrypted message: ");
            for(int i = 0; i < encrypted.Length; i++)
            {
                Console.Write(decrypted.Dequeue());
            }
            Console.WriteLine();
        }
    }
}

//[2018-04-23] Challenge #358 [Easy] Decipher The Seven Segments
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;
using System.IO.Pipes;

namespace r_dailyprogrammer
{
    class Program
    {
        static Dictionary<char, string[]> numDic = new Dictionary<char, string[]>()
            {
                {'1', new [] {"   ","  |","  |" } },
                {'2', new [] {" _ "," _|","|_ "} },
                {'3', new [] {" _ ", " _|", " _|"} },
                {'4', new [] {"   ", "|_|", "  |"} },
                {'5', new [] {" _ ", "|_ ", " _|" } },
                {'6', new [] {" _ ", "|_ ", "|_|" } },
                {'7', new [] {" _ ", "  |", "  |" } },
                {'8', new [] {" _ ", "|_|", "|_|" } },
                {'9', new [] {" _ ", "|_|", " _|" } },
                {'0', new [] {" _ ", "| |", "|_|" } }
            };

        static Dictionary<string, char> numDic2 = new Dictionary<string, char>()
            {
                {"     |  |", '1' },
                {" _  _||_ ", '2' },
                {" _  _| _|", '3' },
                {"   |_|  |", '4' },
                {" _ |_  _|", '5' },
                {" _ |_ |_|", '6' },
                {" _   |  |", '7' },
                {" _ |_||_|", '8' },
                {" _ |_| _|", '9' },
                {" _ | ||_|", '0' }
            };

        static Stack<string> numStack = new Stack<string>();

        static Queue<string> numQueue = new Queue<string>();

        static void Main(string[] args)
        {
            string uInput;
            string sInput1;
            string sInput2;
            string sInput3;
            string path = Path.Combine(Environment.CurrentDirectory, "numbersDoc.txt");

            StreamReader file = new StreamReader(path);

            Console.WriteLine("Please enter a number");
            uInput = Convert.ToString(Console.ReadLine());

            ToAnalog(uInput);

            Console.WriteLine($"Reading from {path}");

            sInput1 = file.ReadLine();
            sInput2 = file.ReadLine();
            sInput3 = file.ReadLine();

            Console.WriteLine(sInput1);
            Console.WriteLine(sInput2);
            Console.WriteLine(sInput3);

            Console.WriteLine();

            ToDigital(sInput1, sInput2, sInput3);

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("press any key to continue...");
            Console.ReadKey();
        }

        static void ToAnalog(string number)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {
                    if (numDic.ContainsKey(number[j]))
                    {
                        numStack.Push(numDic[number[j]][i]);
                    }
                }
                numStack.Reverse();
                do
                {
                    Console.Write("{0}", numStack.Pop());
                } while (numStack.Count() > 0);
                Console.WriteLine();

            }
        }

        static void ToDigital (string s1, string s2, string s3)
        {
            for (int i = 0; i < s1.Length/3; i++)
            {
                numQueue.Enqueue(string.Join(s2.Substring(i * 3, 3), s1.Substring(i * 3, 3), s3.Substring(i * 3, 3)));
            }
            do
            {
                Console.Write(numDic2[numQueue.Dequeue()]);
            } while (numQueue.Count() > 0);
        }
    }
}


/*
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;

namespace r_dailyprogrammer
{
    //[2018-05-09] Challenge #360 [Intermediate] Find the Nearest Aeroplane

    class Program
    { 
        static void Main(string[] args)
        {
            Location uLocation = new Location();
            Interaction uInteraction = new Interaction();
            Shape earth = new Shape();
            string loc1 = " ";
            string loc2 = " ";
            double elevation;

            Console.WriteLine("Please enter all coordinates in the following 15 character format: yy.yyyy,xx.xxxx");
            loc1 = uInteraction.GetLoc("1");
            loc2 = uInteraction.GetLoc("2");
            elevation = uInteraction.GetHeight();
            earth.Sphere(uLocation.GetX(loc1), uLocation.GetY(loc1), uLocation.GetX(loc2), uLocation.GetY(loc2), elevation);

            Console.WriteLine("press enter to continue...");
            Console.ReadLine();
        }
    }

    class Interaction
    {
        static char[] uInputParam = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',', '.' };
        static int maxInputLength = 15;


        public string GetLoc(string locNum)
        {
            string loc = "";

            while (true)
            {
                Console.WriteLine("Please enter the latitude and longitude of location #{0}: ", locNum);
                loc = Console.ReadLine();
                if (Validate(loc)) return loc;
                Console.WriteLine("Invalid coordinates.");
            }
        }

        public double GetHeight()
        {
            string uInput;
            
            while (true)
            {
                Console.WriteLine("Please enter an elevation: ");
                uInput = (Console.ReadLine());
                if (ValidateH(uInput)) return double.Parse(uInput);
                Console.WriteLine("Invalid height in kilometers.");
                                
            }
        }

        public static bool Validate(string input) //checks user input against input parameters
        {
            if (input.Length != maxInputLength) return false;
            if (!input.Contains(",")) return false;

            for (int i = 0; i < input.Length; i++)
            {
                if (Array.IndexOf(uInputParam, input[i]) == -1) return false;
            }
            return true;
        }
        
        public static bool ValidateH(string input)
        {
            if (input.Contains(",")) return false;
            for (int i = 0; i < input.Length; i++)
            {
                if (Array.IndexOf(uInputParam, input[i]) == -1) return false;
            }
            return true;
        }
    }

    class Location
    {
        double yCoord;          //latitude
        double xCoord;          //longitude

        public double GetX(string input)
        {
            int index = input.IndexOf(',');

            xCoord = Convert.ToDouble(input.Substring(0, index));

            return (xCoord);
        }
        public double GetY(string input)
        {
            int index = input.IndexOf(',') + 1;

            yCoord = Convert.ToDouble(input.Substring(index, (input.Length - index)));

            return (yCoord);
        }
    }

    class Shape
    {
        double xChord;          //x chord length - distance along x-axis (difference in longitude along given latitude)
        double yChord;          //y chord length - distance along y-axis (difference in latitude along given longitude)
        double hypChord;        //hypotenuse chord length - direct distance between points
        double arcLength;       //actual distance between points on sphere

        double thetaSph;        //angle of separation between points on sphere
        double thetaChrd;       //angle of separation between point on sphere and point above
        double elevation;       //distance of object from face of sphere

        public void Sphere(double lat1, double long1, double lat2, double long2, double height)
        {
            double radius = 6371;   //of earth
            thetaSph = Math.Abs((lat1 - lat2));         //calculates x angle as absolute value of delta between long values.
            thetaSph = thetaSph * Math.PI / 180;        //converts to radian for subsequent Math.Sin operation
            yChord = (2 * (radius * (Math.Sin(thetaSph / 2))));
            Console.WriteLine("The Chord length of the X component is: {0:.00} km", yChord);

            thetaSph = Math.Abs((long1 - long2));       //calculates x angle as absolute value of delta between long values.
            thetaSph = thetaSph * Math.PI / 180;        //converts to radian for subsequent Math.Sin operation
            xChord = (2 * (radius * (Math.Sin(thetaSph / 2))));
            Console.WriteLine("The Chord length of the Y component is: {0:.00} km", xChord);

            hypChord = Math.Sqrt((xChord * xChord + yChord * yChord));

            Console.WriteLine("The chord length between points on the surface is {0:.00} km", hypChord);
            Console.WriteLine("The real distance between the points is: {0:.00} km", (Math.Sqrt((height * height) + (hypChord * hypChord))));
        }

    }
}
    //[2018-04-30] Challenge #359 [Easy] Regular Paperfold Sequence Generator - COMPLETE
    /*
    class Program
    {


        static void Main(string[] args)
        {
            string s1 = "1";
            string s1Check = "1101100111001001110110001100100111011001110010001101100011001001110110011100100111011000110010001101100111001000110110001100100111011001110010011101100011001001110110011100100011011000110010001101100111001001110110001100100011011001110010001101100011001001110110011100100111011000110010011101100111001000110110001100100111011001110010011101100011001000110110011100100011011000110010001101100111001001110110001100100111011001110010001101100011001000110110011100100111011000110010001101100111001000110110001100100";
            int h = 3;
            int k = 0;

            Console.WriteLine(s1);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < h; j += 2)
                {
                    if (k == 0)
                    {
                        s1 = s1.Insert(j, "1");
                        k = 1;
                    }
                    else
                    {
                        s1 = s1.Insert(j, "0");
                        k = 0;
                    }
                }
                Console.WriteLine(s1);
                h = (2 * s1.Length + 1);
            }

            Console.WriteLine("\n" + string.Compare(s1, s1Check, false) + "\n");

            Console.WriteLine("press enter to continue...");
            Console.ReadLine();
        }

    }*/

// [2018-05-14] Challenge #361 [Easy] Tally Program - COMPLETE
/*
class Program
{
    static int[] scores = { 0, 0, 0, 0, 0 };
    static string input;
    static string choice;
    static string[] pWins = { "a", "b", "c", "d", "e" };
    static string[] pLosses = { "A", "B", "C", "D", "E" };
    static int scoreChange;

    static void Main(string[] args)
    {


        do
        {
            Console.WriteLine("Would you liek to begin tracking scores? y/n (type exit to exit at anytime!)");
            choice = Console.ReadLine();

            if (string.Compare(choice, "y", true) == 0)
            {
                Console.WriteLine("okay! let's DO itttt!!!!...");
                do
                {
                    Console.WriteLine("enter player wins as (a,b,c,d,e) and losses as (A,B,C,D,E):");
                    input = Console.ReadLine();

                    scoreChange = UpdateScore(input, scores.Length);

                    if (scoreChange > 0)
                    {
                        Console.WriteLine("okay! +1 to {0}", input);
                    }
                    if (scoreChange < 0)
                    {
                        Console.WriteLine("okay! -1 to {0}", input);
                    }

                    if ((string.Compare(input, "scores", true) == 0))
                    {
                        displayScore(scores.Length);
                    }


                } while( string.Compare(input, "exit", true) != 0);
            }
            else if (string.Compare(choice, "n", true) == 0)
            {
                Console.WriteLine("okay then...");
            }
            else if ((string.Compare(choice, "exit", true)) != 0)
            {
                Console.WriteLine("That ain't a proper answer to a y/n question!!");
            }
        } while (string.Compare(choice, "exit", true) != 0);

        Console.WriteLine("press enter to continue...");
        Console.ReadLine();            
    }

    private static int UpdateScore(string input, int length)
    {

        for (int i = 0; i < length; i++)
        {
            if ((string.Compare(input, pWins[i], false) == 0))
            {
                scores[i]++;
                scoreChange = 1;
                return (scoreChange);
            }
            else if ((string.Compare(input, pWins[i], true) == 0))
            {
                scores[i]--;
                scoreChange = -1;
                return (scoreChange);
            }               
        }
        return (0);
    }

    static void displayScore(int length)
    {
        Console.WriteLine("new scores are: ");
        Console.WriteLine("player | score");

        for(int i = 0; i < length; i++)
        {
            Console.WriteLine("  {0}   |   {1}", pWins[i], scores[i]);
        }

    }
}
}*/
