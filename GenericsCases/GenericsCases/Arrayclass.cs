using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCases
{
    internal class Arrayclass
    {
        public  void toprint(int[] inputArry)
        {
            foreach (int element in inputArry)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------");
        }
        public  void toprint(double[] inputArry)
        {
            foreach (double element in inputArry)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------");
        }
        public void toprint(char[] inputArry)
        {
            foreach (char element in inputArry)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------");
        }
    }
}
