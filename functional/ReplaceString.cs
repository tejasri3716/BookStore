using System;
namespace FuctionalPrograms
{
    class ReplaceString
    {
        public static void Replace()
        {
            string name = "Hello <<UserName>>,How are you?";
            Console.WriteLine("enter a name to be replaced");
            string replacename = Utility.readString();
            string replace = name.Replace("<<UserName>>", replacename);
            Console.WriteLine(replace);
         }
     }
}
