using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib=NumberToRoman.Library.NumberToRoman;
namespace NumberRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuee;

            do

            {
                Console.WriteLine("Please Enter the Arabic number to convert into Roman Numeral");
            int GivenNumber = Convert.ToInt32(Console.ReadLine());
            if (GivenNumber>=4000 || GivenNumber<=0)
            {
                Console.WriteLine("Please enter a number between 0 and 4000");
            }
            else
            {
                Console.WriteLine(lib.GetRoman(GivenNumber));
            }
                Console.WriteLine("do you want to covert other number(yes/no)");

                continuee = Console.ReadLine();

            }

            while (continuee == "yes");

        }
    }
}
