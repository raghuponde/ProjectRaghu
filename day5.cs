
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printdemo
{
     class Program
    {
        static void Main(string[] args)
        {

            int x, y, z;
            Console.WriteLine("enter values in x and y ...");
            x = Convert.ToInt32(Console.ReadLine());
            y=int.Parse(Console.ReadLine());
            z = x + y;
            Console.WriteLine("The sum of {0} and {1} is {2}", x, y, z);
            Console.WriteLine("The sum of {0,7} and {1,8} is {2,7}", x, y, z);
            Console.WriteLine("The sum of "+ x+", "+y+", "+z);
            Console.WriteLine($"The sum of {x}  and {y} and {z}");

            // print constants 
            Console.WriteLine("{0}", 34.56);
            Console.WriteLine("Febuary has {0} or {1}", 28, 29);
          
            //taking values in a single line 
            Console.WriteLine("enter values in single line comm seeprated ");
            string input = Console.ReadLine();
            int m, n;
            m = Convert.ToInt32(input.Split(',')[0]);
            n = Convert.ToInt32(input.Split(',')[1]);
            Console.WriteLine($"The sum of {m} and {n} is {m + n}");
            Console.WriteLine("enter values in single line and chooose your delimiters");
            string input1= Console.ReadLine();
            char[] chars = new char[] { ',','-','$','.' };
            int m1, n1;
            m1 = Convert.ToInt32(input1.Split(chars)[0]);
            n1 = Convert.ToInt32(input1.Split(chars)[1]);
            Console.WriteLine($"The sum of {m1} and {n1} is {m1 + n1}");
            Console.WriteLine($"int max value :{int.MaxValue}\n int min value : {int.MinValue}");
            Console.WriteLine($"byte max value :{byte.MaxValue}\n int min value : {byte.MinValue}");
            //some more data type 
            decimal kk = 345.45M;// for decimal use convention M
            float ss = 23.567F; // for float convention F i have to use 
            double jj = 34590.678;
            string name = "sudha";
            char ch = 'A';
            

            Console.WriteLine($"{kk}--{ss}--{jj}--{name}--{ch}");
            Console.ReadLine();

        }
    }
}
