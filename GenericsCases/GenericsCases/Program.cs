// See https://aka.ms/new-console-template for more information
using System;
namespace generic
{
    class program
    {
        public static void Main(string[] args)
        {
            var log = NLog.LogManager.GetCurrentClassLogger();
            log.Info("This is generics nlog file");
            GenericsCases.Arrayclass program = new GenericsCases.Arrayclass();
            int[] intArry = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArry = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArry = { 'H', 'A', 'R', 'I', 'N', 'I' };

            program.toprint(intArry);
            program.toprint(doubleArry);
            program.toprint(charArry);

            SameUsingGenerics sameUsingGenerics = new SameUsingGenerics();
            sameUsingGenerics.secondgeneric<int>(intArry);
            sameUsingGenerics.secondgeneric<double>(doubleArry);
            sameUsingGenerics.secondgeneric<char>(charArry);
        }
        }
    
}
