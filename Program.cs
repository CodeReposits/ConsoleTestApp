using Newtonsoft.Json;
using System;
using System.Configuration;
using System.IO;
using Unity;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            
            // resolving Dependencies
            Context context = Container._unityContainer.Resolve<Context>();

            //IConvert 
            var Conver = context.convert;

            //Passing settings to object
            Conver.setRomanSettings(GetRomanSettings());
            
            if (Conver.isValid(input, out int result))
            {                
                string romanNumString = Conver.ToRoman(result);
                Console.WriteLine(romanNumString);
                Console.Read();
            }         
        }

        static RomanSettings GetRomanSettings()
        {            
            RomanSettings _rSettings;
            var filePath =  ConfigurationSettings.AppSettings["rFileName"].ToString();

            /// Load Settings 
            using (StreamReader sr = new StreamReader(filePath))
            {
                string JsonText = sr.ReadToEnd();
                _rSettings = JsonConvert.DeserializeObject<RomanSettings>(JsonText);
            }            

            return _rSettings;
        }
    }
}
