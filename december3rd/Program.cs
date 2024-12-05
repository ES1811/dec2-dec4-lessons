using System;
namespace december3rd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram=new Program();


            //let us call greeting user method
            //connect method to our instance
            myProgram.GreetingUser();
            
            UserAge();


            myProgram.ClassTeacher();
            HeiMan();


        }

        public void GreetingUser()
        {
            Console.WriteLine("Hello user");
        }

        public static void UserAge()
        {
            Console.WriteLine("My age is 25");
        }

        public void ClassTeacher()
        {
            Console.WriteLine("Today teacher isn't boring");
        }
        public static void HeiMan()
        {
            Console.WriteLine("Hey man");
        }
    }
}