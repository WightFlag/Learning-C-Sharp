
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Xml;

namespace dBanasTuts
{
    class Program
    {
        static void Main()
        {
            List<Animal> aminals = new List<Animal>           
            {
                new Animal ("a spiderling", 11.2, 1.2),
                new Animal ("a bat", 3.8, 3.2),
                new Animal ("a decaying skeleton", 18.2, 5.6)
            };

            List<Animal> lotsAminals = new List<Animal>();
           
            /*
            using (Stream fs = new FileStream(@"C:\Users\rloyd\Documents\GDevelopment\C#Stuff\animals.xml", FileMode.Append, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializerA = new XmlSerializer(typeof(List<Animal>));
                serializerA.Serialize(fs,aminals);
            }

            aminals = null;
            */
            XmlSerializer serializerB = new XmlSerializer(typeof(List<Animal>));

            using (Stream fs2 = new FileStream(@"C:\Users\rloyd\Documents\GDevelopment\C#Stuff\animals.xml", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                lotsAminals = (List<Animal>)serializerB.Deserialize(fs2);
            }

            lotsAminals.AddRange(aminals);

            foreach(Animal a in lotsAminals)
            {
                Console.WriteLine(a.ToString());
            }

            Console.WriteLine();

            XmlSerializer serializer3 = new XmlSerializer(typeof(List<Animal>));

            using (Stream fs3 = new FileStream(@"C:\Users\rloyd\Documents\GDevelopment\C#Stuff\lotsAminals.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                serializer3.Serialize(fs3, lotsAminals);
            }

            lotsAminals = null;

            XmlSerializer serializer4 = new XmlSerializer(typeof(List<Animal>));

            using (Stream fs4 = new FileStream(@"C:\Users\rloyd\Documents\GDevelopment\C#Stuff\lotsAminals.xml", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                lotsAminals = (List<Animal>)serializer4.Deserialize(fs4);
            }

            foreach (Animal a in lotsAminals)
            {
                Console.WriteLine(a.ToString());
            }

            Console.ReadKey();
        }
    }
}



/*
//Tutorial #18 Serialize
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace dBanasTuts
{
    class Program
    {
        static void Main()
        {
            Animal sarnak = new Animal("Sarnak", 375, 10);

            Stream stream = File.Open("AnimalData.dat", FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, sarnak);
            stream.Close();

            sarnak = null;

            stream = File.Open("AnimalData.dat", FileMode.Open);

            bf = new BinaryFormatter();

            sarnak = (Animal)bf.Deserialize(stream);
            stream.Close();

            Console.WriteLine(sarnak.ToString());

            sarnak.Weight = 542;

            XmlSerializer serializer = new XmlSerializer(typeof(Animal));

            using(TextWriter tw = new StreamWriter(@"C:\Users\rloyd\Documents\GDevelopment\C#Stuff\sarnak.xml"))
            {
                serializer.Serialize(tw, sarnak);
            }

            sarnak = null;

            XmlSerializer deserializer = new XmlSerializer(typeof(Animal));
            TextReader reader = new StreamReader(@"C:\Users\rloyd\Documents\GDevelopment\C#Stuff\sarnak.xml");
            object obj = deserializer.Deserialize(reader);
            sarnak = (Animal)obj;
            reader.Close();

            Console.WriteLine(sarnak.ToString());

            List<Animal> Aminals = new List<Animal>
            {
                new Animal ("Froglok", 4.2, 68),
                new Animal ("Orc", 5.2, 188),
                new Animal ("Gnoll", 6.3, 275)
            };

            using (Stream fs = new FileStream(@"C:\Users\rloyd\Documents\GDevelopment\C#Stuff\animals.xml", FileMode.Create, FileAccess.Write,FileShare.None))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
                serializer2.Serialize(fs, Aminals);
            }

            Aminals = null;

            XmlSerializer serializer3 = new XmlSerializer(typeof(List<Animal>));
            
            using(FileStream fs2 = File.OpenRead(@"C:\Users\rloyd\Documents\GDevelopment\C#Stuff\animals.xml"))
            {
                Aminals = (List<Animal>)serializer3.Deserialize(fs2);
            }

            foreach(Animal a in Aminals)
            {
                Console.WriteLine(a.ToString());
            }

            Console.ReadKey();
        }
    }
}




/*
//Tutorial #16 Threads
using System;
using System.Collections.Generic;
using System.Threading;

namespace dBanasTuts
{
    class Program
    {
        static void Main()
        {
            Thread t = new Thread(()=> CountTo(10));
            t.Start();

            new Thread(() =>
            {
                CountTo(5);
                CountTo(6);
            }).Start();

            Console.ReadKey();
        }

        static void CountTo(int maxNum)
        {
            for (int i = 0; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}



/*
using System;
using System.Collections.Generic;
using System.Threading;

namespace dBanasTuts
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcct acct = new BankAcct(10);
            Thread[] threads = new Thread[15];

            Thread.CurrentThread.Name = "main";

            for(int i = 0; i<15; i++)
            {
                Thread t = new Thread(new ThreadStart(acct.IssueWithdraw));
                t.Name = i.ToString();
                threads[i] = t;
            }

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);

                threads[i].Start();

                Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);
            }

            Console.WriteLine("Current Priority : {0}", Thread.CurrentThread.Priority);

            Console.WriteLine("Thread {0} Ending", Thread.CurrentThread.Name);

            Console.ReadKey();
        }
    }
}



/*
using System;
using System.Collections.Generic;
using System.Threading;

namespace dBanasTuts
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Print1);

            t.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }


            int num = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);
                Thread.Sleep(1000);
                num++;
            }
            Console.WriteLine("Thread ends");

            Console.ReadKey();


        }

        static void Print1()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
        }
    }
}


/*
//Tutorial #12 Generics
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dBanasTuts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();

            animalList.Add(new Animal() { Name = "Ben" });
            animalList.Add(new Animal() { Name = "Fred" });
            animalList.Add(new Animal() { Name = "Beatrice" });

            animalList.Insert(1, new Animal() { Name = "Gerdy" });
            animalList.RemoveAt(1);

            Console.WriteLine("Num of Animals : {0}", animalList.Count());

            foreach(Animal a in animalList)
            {
                Console.WriteLine(a.Name);
            }

            int x = 5, y = 4;

            Animal.GetSum(ref x, ref y);

            string strx = "5", stry = "4";

            Animal.GetSum(ref strx, ref stry);

            Rectangle<int> rec1 = new Rectangle<int>(20, 50);

            Console.WriteLine(rec1.GetArea());

            Rectangle<string> rec2 = new Rectangle<string>("20", "50");

            Console.WriteLine(rec2.GetArea());

            Arithmetic add, sub, addSub;

            add = new Arithmetic(Add);
            sub = new Arithmetic(Sub);
            addSub = add + sub;

            Console.WriteLine($"Add 6 & 10");
            add(6, 10);

            Console.WriteLine($"Add & Subtract 10 & 4");
            addSub(10, 4);

            Console.ReadKey();
        }

        public struct Rectangle<T>
        {
            private T width;
            private T length;

            public T Width
            {
                get { return width; }
                set { width = value; }
            }

            public T Length
            {
                get { return length; }
                set { length = value; }
            }

            public Rectangle(T w, T l)
            {
                width = w;
                length = l;
            }

            public string GetArea()
            {
                double dblWidth = Convert.ToDouble(Width);
                double dblLength = Convert.ToDouble(Length);
                return string.Format($"{Width} * {Length} = {dblWidth * dblLength}");
            }
        }

        public delegate void Arithmetic(double num1, double num2);

        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1+num2}");
        }

        public static void Sub(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1-num2}");
        }
    }
}

/*
//Tutorial #9 Abstract Classes

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;


using System;
using System.Globalization;
using dBanTuts;

namespace dBanasTuts
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            foreach(Shape s in shapes)
            {
                s.GetInfo();
                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());

                Circle testCirc = s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("This isn't a circle.");
                }
                if (s is Circle)
                {
                    Console.WriteLine("This isn't a rectangle.");
                }
                Console.WriteLine();

                object circ1 = new Circle(4);
                Circle circ2 = (Circle)circ1;

                Console.WriteLine("The {0} Area is {1:f2}.", circ2.Name, circ2.Area());
            }

            Console.ReadKey();
        }
    }
}


/*
 * //Tutorial #17 File I/O -- Practice
 * 
class Program
{
    static void Main()
    {
        string path = @"C:\Users\rloyd\source\repos\dBanTuts\textfiles";
        for (int i = 1; i < 4; i++)
        {
            FileInfo file = new FileInfo(path + "\\imagefile" + Convert.ToString(i) + ".jpeg");
            //renames files in a folder to a serialization of the files' current directory
            File.Move(path + "\\textfile" + Convert.ToString(i) + ".txt", path + 
                file.DirectoryName.Substring(file.DirectoryName.LastIndexOf("\\"), file.DirectoryName.Length-file.DirectoryName.LastIndexOf("\\")) + i + ".txt");
            //file.Directory.Create();
            //file.Create();            
        }

        Console.ReadKey();
    }
}


/*
//Tutorial #17 File I/O
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace dBanTuts
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo currDir = new DirectoryInfo(".");
            DirectoryInfo myDir = new DirectoryInfo(@"C:\Users\rloyd\Documents\GDevelopment\C#Stuff");

            Console.WriteLine(myDir.FullName);
            Console.WriteLine(myDir.Name);
            Console.WriteLine(myDir.Parent);
            Console.WriteLine(myDir.Attributes);
            Console.WriteLine(myDir.CreationTime);

            //DirectoryInfo dataDir = new DirectoryInfo(@"C:Users\rloyd\testDir");

            string[] custs =
            {
                "John Doe",
                "Jane Doe",
                "Larry Doe"
            };

            string textFilePath = @"C:\Users\rloyd\Documents\GDevelopment\C#Stuff\textfile1.txt";

            File.WriteAllLines(textFilePath, custs);

            foreach(string cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customer: {cust}");
            }

            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\rloyd\Documents\GDevelopment\C#Stuff");

            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            Console.WriteLine("Matches: {0}", txtFiles.Length);

            foreach (FileInfo file in txtFiles)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }

            string textFilePath2 = @"C:\Users\rloyd\Documents\GDevelopment\C#Stuff\textfile2.txt";

            FileStream fs = File.Open(textFilePath2, FileMode.Create);

            string randString = "This is a random string";

            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            fs.Write(rsByteArray, 0, rsByteArray.Length);

            fs.Position = 0;

            byte[] fileByteArray = new byte[rsByteArray.Length];

            for(int i = 0;  i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }

            Console.WriteLine(Encoding.Default.GetString(fileByteArray));

            fs.Close();

            string textFilePath3 = @"C:\Users\rloyd\Documents\GDevelopment\C#Stuff\textfile3.txt";

            StreamWriter sw = File.CreateText(textFilePath3);

            sw.Write("this is a random thingy ");
            sw.WriteLine("sentence");
            sw.WriteLine("This is another sentence.");

            sw.Close();

            StreamReader sr = File.OpenText(textFilePath3);

            Console.WriteLine("Peak : {0}", Convert.ToChar(sr.Peek()));

            Console.WriteLine("1st String : {0}", sr.ReadLine());

            Console.WriteLine("Everything : {0}", sr.ReadToEnd());

            sr.Close();

            string textFilePath4 = @"C:\Users\rloyd\Documents\GDevelopment\C#Stuff\textfile4.dat";

            FileInfo datFile = new FileInfo(textFilePath4);

            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            string randText = "Random Text";
            int myAge = 33;
            double height = 6.00;

            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(height);

            bw.Close();

            BinaryReader br = new BinaryReader(datFile.OpenRead());

            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());

            br.Close();


            //Directory.Delete(@"C:users\rloyd\testDair");

            Console.ReadKey();
        }
    }
}

*/
