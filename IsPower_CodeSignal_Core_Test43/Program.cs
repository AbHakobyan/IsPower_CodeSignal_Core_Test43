using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPower_CodeSignal_Core_Test43
{
    class Program
    {
        static void Main(string[] args)
        {
            bool res = isPower(324);
            Console.WriteLine(res);
        }

        static bool isPower(int n)
        {
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    if (Math.Pow(i, j) == n)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
