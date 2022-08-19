using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace power_of_a_number
{
    internal class Program
    {

    public void Form()

        {
            Console.WriteLine("a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("b");
            int b = Convert.ToInt32(Console.ReadLine());
            int res = 1;
            for (int i = 1; i <=b; i++)
            {
                

              
                res = a*res;           

                

            }
            Console.WriteLine(res);

        }
        static void Main(string[] args)
        {
            
             Program jj = new Program();
            jj.Form();
            Console.ReadLine();

            
        }
    }
}
