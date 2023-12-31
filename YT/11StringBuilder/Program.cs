﻿using System.Globalization;
using System.Text;

namespace _11StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StringBuilder sb = new StringBuilder("Random Text"); // default size of string builder is 16
            StringBuilder sb2 = new StringBuilder("More Stuff that is very important", 256);

            Console.WriteLine(sb.ToString());
            Console.WriteLine("Capacity : {0}", sb2.Capacity);
            Console.WriteLine("Length : {0}", sb2.Length);

            sb2.AppendLine("\nMore important text");
            CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-US");

            string bestCust = "Bob Smith";
            sb2.AppendFormat(enUs, "Best Customer : {0}", bestCust);


            Console.WriteLine(sb2.ToString());
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());

            sb2.Clear();
            sb2.Append("Random Text");
            Console.WriteLine(sb.Equals(sb2));

            sb2.Insert(11, " that's great");
            Console.WriteLine(sb2.ToString());
            sb2.Remove(11, 7);
            Console.WriteLine(sb2.ToString());


        }
    }
}