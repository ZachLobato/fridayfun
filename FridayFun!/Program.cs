using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayFun_
{
    class Program
    {
        static void Main(string[] args)
        {

            Cuts test = new Cuts();

            for (int i = 0; i<=100; i++){
                Console.Out.WriteLine(i + " " + test.minimumNumberOfCuts(i));
            }

            Console.ReadLine();
        }
    }
}
