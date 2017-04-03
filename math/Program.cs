using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            //int var1 = 5;
            //int var2 = 5;
            //int temp1 = var1++;
            //int temp2 = ++var2;
            int MyVar = 7;
            int MyVar1 = 2;

            //Console.WriteLine("The Temp1 is :{0}\nThe Temp2 is :{1}", temp1, temp2);
            int Temp = MyVar++ / MyVar1--;
            Console.WriteLine("{0}", Temp);
            Console.ReadKey();
        }
    }
}
