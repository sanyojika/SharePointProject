using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace information_form
{
    internal class Program

    {

        public void form()
        {

            Console.WriteLine("**********************");
            Console.WriteLine("   INFORMATION FORM    ");
            Console.WriteLine("**********************");
            Console.WriteLine("what is youe name");
            string name = Console.ReadLine();
            Console.WriteLine("what is your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what is your address");
            string add = Console.ReadLine();
            Console.WriteLine("what is your mobile no");
            string mob = Console.ReadLine();
            Console.WriteLine("**********************");
            Console.WriteLine("     INFORMATION    ");
            Console.WriteLine("**********************");
            Console.WriteLine("your name is {0}", name);
            Console.WriteLine("your age is {0}", age);
            Console.WriteLine("your address is{0}", add);
            Console.WriteLine("your mobile_no is{0}", mob);
            Console.WriteLine("enter to submit your form");
            string sub = Console.ReadLine();
            Console.WriteLine("submit{0}", sub);
        } static void Main(string[] args) {
            Program info = new Program();
            info.form();
            Console.ReadLine();
        }
            

        
            


























        }
    }

