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
            while (num >= 1000)
            {
                val += "M";
                num -= 1000;
            }
            if (num >= 900)
            {
                val += "CM";
                num -= 900;
            }
            while (num >= 500)
            {
                val += "D";
                num -= 500;
            }
            if (num >= 400)
            {
                val += "CD";
                num -= 400;
            }
            while (num >= 100)
            {
                val += "C";
                num -= 100;
            }
            if (num >= 90)
            {
                val += "XC";
                num -= (0);
            }
            while (num >= 50)
            {
                val += "L";
                num -= 50;
            }
            if (num >= 40)
            {
                val += "XL";
                num -= 40;
            }
            while (num >= 10)
            {
                val += "X";
                num -= 10;
            }
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
