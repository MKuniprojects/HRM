using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refTest1
{
    class Program
    {
        static void ChangeBool(ref bool b)
        {
            b = !b;
        }
        static void Main(string[] args)
        {
            bool original = false;
            ChangeBool(ref original);

            Console.WriteLine(original);
        }
    }
}
