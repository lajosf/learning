using System;

namespace Linq
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string myStringDouble = "108,1";
            double myDouble = myStringDouble.ToDouble();
            Console.WriteLine("Heres is my double :) = " + myDouble);
            Console.ReadLine();
        }
    }

    public static class StringExtension {
        static public double ToDouble(this string data){
            double result = double.Parse(data);
            return result;
        } 
    }
}
