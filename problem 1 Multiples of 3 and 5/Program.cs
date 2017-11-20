using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_1_Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> list = Enumerable.Range(1, 999);
            int a = 0;
            foreach (int z in list)
            {
                if (z % 3 == 0 || z % 5 == 0)
                {
                    Console.WriteLine(z);
                    a = a + z;
                }

            }
            Console.WriteLine(a);

            
        }
    }
}
