using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToRoman.Library
{
    public class NumberToRoman
    {
        public static string GetRoman(int num)
        {
            string val = "";
            if (num >= 9)
            {
                val += "IX";
                num -= 9;
            }
            while (num >= 5)
            {
                val += "V";
                num -= 5;
            }
            if (num >= 4)
            {
                val += "IV";
                num -= 4;
            }


            while (num >= 1)
            {
                val += "I";
                num -= 1;
            }
            return val;
           
        }
    }
}
