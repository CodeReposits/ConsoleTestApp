using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleTestApp
{
    public class NumToRoman : IConvert
    {
        private RomanSettings _rSettings;
        
        public void setRomanSettings(RomanSettings _rSettings)
        {
            this._rSettings = _rSettings;
        }        

        public bool isValid(string strInput, out int result)
        {
            bool isNumeric = int.TryParse(strInput, out int numResult);
            result = numResult;

            bool isRange = numResult <= this._rSettings.MaxValue && numResult > 0;

            if (isNumeric && isRange)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Input value  is not in right format");
                Console.Read();
                return false;
            }
        }       

        public string ToRoman(int num)
        {
            Dictionary<string, int> _romanValues = this._rSettings.RomanValues;
            StringBuilder result = new StringBuilder();

            foreach (var value in _romanValues)
            {
                while (num >= value.Value)
                {
                    result.Append(value.Key);
                    num -= value.Value;
                }
            }
            return result.ToString();
        }
    }
}
