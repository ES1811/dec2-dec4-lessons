using System;
using System.Runtime.InteropServices;
namespace novoid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result=MakeMeTwo(2);
            
            Console.WriteLine(result);

        
            
        }
        //here methods will be placed

        public static int MakeMeTwo(int anyNumber)
        {
            return anyNumber*2;
        }

       

    }
}