using _07___ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___ExByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123,3241566);
            conta.Titular = new Cliente();
            conta.Titular.nome = "joao";
            Console.WriteLine(ContaCorrente.TaxaOperacao);
            Console.ReadLine();

        }
    }
}
