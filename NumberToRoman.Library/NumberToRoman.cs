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
            
            while (num >= 1)
            {
                val += "I";
                num -= 1;
            }
            return val;
           
        }
    }
}
