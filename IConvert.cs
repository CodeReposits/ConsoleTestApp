using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace ConsoleTestApp
{
    public interface IConvert
    {
        void setRomanSettings(RomanSettings romanSettings);

        bool isValid(string strInput, out int result);

        string ToRoman(int num);
    }    

    public class Context
    {       
        public IConvert convert = null;

        public Context(IConvert convert)
        {
            this.convert = convert;        
        }
    }


}
