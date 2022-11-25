using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Exceção Tratada.");
            }
            Console.ReadLine();
        }

        static void Metodo()
        {
            try
            {
                TestaDivisao(0);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Exceção Tratada.");

            }
        }

        static void TestaDivisao(int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);
            Dividir(10, divisor);
        }

        public static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }


    }
}
