using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace from12
{
    internal class Program
    {
        public void form_2()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("enter your name");
                string name=Console.ReadLine();
                Console.WriteLine("enter your mobile_no");
                string mob=Console.ReadLine();
                Console.WriteLine("enter your age");
                int age=Convert.ToInt32(Console.ReadLine());
                
                
                Console.WriteLine(name);
                Console.WriteLine("my name is {0}", age);
                Console.WriteLine("my name is {0}", mob);
                




            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.form_2();
            Console.ReadLine();

        }
    }
}
