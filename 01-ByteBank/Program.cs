using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numeroConta = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine("Titular: " + contaDaGabriela.titular);
            Console.WriteLine("Agência: " + contaDaGabriela.agencia);
            Console.WriteLine("Número da conta: " + contaDaGabriela.numeroConta);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);
            Console.ReadLine();
        }
    }
}
