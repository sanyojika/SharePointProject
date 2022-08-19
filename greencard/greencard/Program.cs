using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greencard
{
    internal class Program
    {
        int x,y, name, age, country;
        public void form()
        {
            for (int i = 0; i < 2; i++)
            {
               
                if(x == y)
                {
                    Console.WriteLine("THEN YOUR ARE AMERICAN");
                   
                    Console.WriteLine("enter your name");
                    string name=Console.ReadLine();
                    Console.WriteLine("enter your age");
                    string age=Console.ReadLine();
                    Console.WriteLine("enter your country");
                    string country=Console.ReadLine();
                    Console.WriteLine("your name is{0}", name);
                    Console.WriteLine("your age is{0}", age);
                    Console.WriteLine("your country is{0}", country);

                }
                else
                 {
                    Console.WriteLine("you are not eligible for green card");
                }
                Console.ReadLine();
            }




        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.form();
        }
    }
}
