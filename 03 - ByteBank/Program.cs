using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // contaDaGabriela é diferente de contaDaGabrielaCosta pois estão
            // em locais diferentes da memória
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numeroConta = 863452;
            contaDaGabriela.saldo = 100;

            contaDaGabriela.Sacar(50);
            Console.WriteLine(contaDaGabriela.saldo);

            contaDaGabriela.Depositar(1000);
            contaDaGabriela.Sacar(500);
            Console.WriteLine(contaDaGabriela.saldo);

            ContaCorrente contaDaJoana = new ContaCorrente();
            contaDaJoana.titular = "Joana";
            contaDaJoana.agencia = 862;
            contaDaJoana.numeroConta = 863451;
            contaDaJoana.saldo = 100;

            contaDaGabriela.Transferir(50, contaDaJoana);
            Console.WriteLine(contaDaJoana.saldo);


            Console.ReadLine();
        }
    }

}
