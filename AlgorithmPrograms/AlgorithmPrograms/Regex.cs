using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Regex
    {

        public static void UserInputs()
        {
            Console.WriteLine("enter first name");
            String fName = Utility.readString();
            Console.WriteLine("enter last name");
            String lName = Utility.readString();
            Console.WriteLine("enetr mobile number");
            String l = Utility.readString();
            String str = " Hello <<name>>, We have your full name as <<full name>> in our system." +
                " your contact number is 91-xxxxxxxxxx." +
                " Please,let us know in case of any clarification Thank you BridgeLabz 01/01/2016";
            String sentence = ConvertSentence(fName, lName, l, str);
            Console.WriteLine(sentence);
        }

        public static String ConvertSentence(String fName, String lName, String mobNumber, String message)
        {
            String regexName = "<<name>>";
            String regexLastName = "<<full name>>";
            String regexNumber = "xxxxxxxxxx";
            String regexDate = "01/01/2016";
            DateTime dates = DateTime.Now;
            String date = Convert.ToString(dates);
            //this methos is replace one string
            String replced = message.Replace(regexName, fName)
                .Replace(regexLastName, fName + " " + lName)
                .Replace(regexNumber, mobNumber)
                .Replace(regexDate, date);
            // Console.WriteLine(o);
            return replced;

        }

    }
}
