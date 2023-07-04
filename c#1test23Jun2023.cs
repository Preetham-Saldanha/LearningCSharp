using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class tasks
    {
        static void Main(string[] args)
        {
            //1.To Display the date and time in the format dd-mm-yyy HH:mm.
            
            DateTime now = DateTime.Now;    
            Console.WriteLine(now.ToString(" yyyy-MM-dd HH:mm "));

            //2.To display the age of a given person.

            Console.WriteLine("enter your birth date");
            DateTime dOB = DateTime.Parse( Console.ReadLine() );
            TimeSpan myAge = now.Subtract(dOB);
            double age = Convert.ToDouble(myAge.TotalDays / 365.242199F);
            Console.WriteLine(Math.Floor(age));

            //3.To display each character of a given word

            Console.WriteLine("enter a word");
            string word = Console.ReadLine();
            char[] chararr = word.ToCharArray();
            foreach ( char c in chararr)
            {
                Console.WriteLine(c);

            }

            //4.To search a specific word in a given text
            
            string orignal = "today is the day of joy";
            Console.WriteLine("enter the text you want to search");
            string text = Console.ReadLine();
            Console.WriteLine(orignal.Contains(text)); 


            //5.To insert a word in a given string

            String given = "My name Preetham";
            string inserted = given.Insert(8, "is ");
            Console.Write(inserted);
        }
    }
}