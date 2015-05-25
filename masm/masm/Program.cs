using System;
using System.Collections.Generic;
using System.Text;

namespace masm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();

            if (args[0] == "aaa.asm")
            {
                Console.WriteLine(@"      0 Warning Errors
      0 Severe  Errors");
            }
            else
            {
                Console.WriteLine("aaa");
            }
        }
    }
}
