using System;
using System.Threading.Tasks.Dataflow;
namespace CsharpArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int[] numberArray={3,6,7,4,7,6,9,12,45};

            int numberArraySize=numberArray.Length;
            //Console.WriteLine(numberArraySize);
            //int counter=0;


            for (int i=0;i<numberArraySize;i++)
            {
                //Console.WriteLine(i);
                Console.Write(numberArray[i]);
            }*/



            //int sum=0;

            //for loop
            /* for (int i=0;i<=100;i++)
            {
                Console.WriteLine(i);
                
            }
            */

            /*for (int j=0;j<=100;j++)
            {
                /*if (j%7==0)
                {
                    //Console.WriteLine(j);
                    counter++;
                }

                if (j%2==0)
                {
                    sum+=j;
                    Console.WriteLine(sum);
                } 


            }*/
            
            //Console.WriteLine(counter);


            //string array 
            string[] fruits = {
                "Lemon",
                "Apple",
                "Kiwi",
                "Fig",
                "Date",
                "Banana",
                "Grape",
                "Cherry",
                "Elderberry",
                "Honeydew"
            };

            string[] fruitsCloned = (string[])fruits.Clone();

            Array.Sort(fruitsCloned);
            foreach (string b in fruitsCloned)
            {
                Console.WriteLine(b);
            }

            Array.Sort(fruits);
            foreach (string i in fruits)
            {
                Console.WriteLine(i);
            }

            string[] countries = {
                "Panama",
                "United States",
                "Norway",
                "Spain",
                "Japan",
                "China",
                "South Africa",
                "Egypt"
            };

            Array.Sort(countries);
            foreach (string j in countries)
            {
                Console.WriteLine(j);
            }


            

            /*foreach(int i in numberArray)
            {
                Console.WriteLine(i);
            }*/


        }
    }
}