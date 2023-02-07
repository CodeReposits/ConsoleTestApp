using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    interface IConvertNumer
    {
        string ConvertToRomanNumeric(int num);
    }

    public class ConverToRoman : IConvertNumer
    {
        public string ConvertToRomanNumeric(int num)
        {
            return num.ToString();
        }
    }

}
