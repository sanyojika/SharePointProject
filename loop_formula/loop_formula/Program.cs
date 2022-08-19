using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_formula
{
    internal class Program
    { 
        public void form()
        {
            string name="radha";
            int age=12;
            string address = "delhi";
            string mobile_no="2343243", qualification="MBA";

            for(int i= 0; i <= 5; i++)
            {
                Console.WriteLine("my name is"+name);
                Console.WriteLine("my age is" + age);
                Console.WriteLine("my address is" + address);
                Console.WriteLine("my qualification is"+qualification);
                Console.WriteLine("my mob no is"+mobile_no);
                Console.WriteLine("my name is" + name);
                Console.WriteLine("my name is" + name);
                Console.WriteLine("my name is" + name);


            }


        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            obj.form();
            Console.ReadLine();
        }
    }
}
