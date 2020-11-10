
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05__ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Saldo = 1000;
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
