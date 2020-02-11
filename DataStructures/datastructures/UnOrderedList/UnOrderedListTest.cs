using System;
using System.Text;
using System.IO;

namespace DataStructures
{
    class UnOrderedListTest
    {
        public static void ReadInputFromFile()
        {
            UnOrderedList<String> ul = new UnOrderedList<String>();
            string[] lines = File.ReadAllLines(@"C:\Users\BridgeLabz\source\repos\Input.txt");
            Console.WriteLine("Contents of Input.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                ul.Add(line);
            }
            Console.WriteLine("\n");
            Console.WriteLine("enter any one of the option listed below to execute");
            Console.WriteLine("1.Size");
            Console.WriteLine("2.Search");
            Console.WriteLine("3.Index");
            Console.WriteLine("4.IsEmpty");
            Console.WriteLine("5.Append");
            Console.WriteLine("6.Remove");
            Console.WriteLine("7.Insert");
            Console.WriteLine("8.Pop Using Position");
            Console.WriteLine("9.Pop");
            int option = Utility.readInt();
            switch (option)
            {
                case 1:
                    int n = ul.Size();
                    Console.WriteLine(n);
                    break;
                case 2:
                    Console.WriteLine("enter a string to search in the list");
                    String s1 = Utility.readString();
                    Boolean result = ul.Search(s1);
                    Console.WriteLine(result);
                    break;
                case 3:
                    Console.WriteLine("enter a string to check the index from the list");
                    String s = Utility.readString();
                    int pos = ul.Index(s);
                    Console.WriteLine(pos);
                    break;
                case 4:
                    Boolean res = ul.IsEmpty();
                    Console.WriteLine("list is not empty: " + res);
                    break;
                case 5:
                    Console.WriteLine("enter a string to append into list");
                    String s3 = Utility.readString();
                    ul.Append(s3);
                    FileStream aFile = new FileStream(@"C:\Users\BridgeLabz\source\repos\Input.txt",
                        FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine(s3);
                    ul.PrintList();
                    sw.Close();
                    aFile.Close();
                    break;
                case 6:
                    Console.WriteLine("enter a string to remove from the list");
                    String s4 = Utility.readString();
                    ul.Remove(s4);
                    ul.PrintList();
                    break;
                case 7:
                    Console.WriteLine("enter a string to insert at a specified position");
                    String s5 = Utility.readString();
                    Console.WriteLine("enter position at which you want to insert the string");
                    int position = Utility.readInt();
                    ul.Insert(position, s5);
                    ul.PrintList();
                    break;
                case 8:
                    Console.WriteLine("enter position at which u want to remove the item");
                    int num = Utility.readInt();
                    ul.Pop(num);
                    ul.PrintList();
                    break;
                case 9:
                    string s2 = ul.Pop();
                    Console.WriteLine("poped item  is" + s2);
                    ul.PrintList();
                    break;
                default:
                    Console.WriteLine("enter correct option");
                    break;
            }
        }
        public static void Test()
        {
            UnOrderedList<String> ul = new UnOrderedList<String>();

            string[] lines = File.ReadAllLines(@"C:\Users\BridgeLabz\source\repos\Input.txt");
            Console.WriteLine("Contents of Input.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                ul.Add(line);
            }
            Console.WriteLine("entera word to search");
            string s = Utility.readString();
            bool b = ul.Search(s);
            if (b)
            {
                ul.Remove(s);
            }
            else
            {
                ul.Append(s);
                FileStream aFile = new FileStream(@"C:\Users\BridgeLabz\source\repos\Input.txt",
                       FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(aFile);
                sw.WriteLine(s);
            }
        }
    }
}
