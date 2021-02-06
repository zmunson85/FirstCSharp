using System;

namespace test_project
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname,lname;
            Console.Write("Enter Your First Name : ");
            fname =Console.ReadLine();
            Console.Write("Enter Your Last Name : ");
            lname = Console.ReadLine();
            Console.Write("Your Full Name Is "+fname+","+lname);
        }
    }
}
