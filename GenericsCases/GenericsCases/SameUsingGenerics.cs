using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class SameUsingGenerics
{
    public  void secondgeneric<T>(T[] inputArry)
    {
        foreach (var element in inputArry)
        {
            Console.WriteLine(element);
        }
        Console.WriteLine("----------------------");
    }



}


