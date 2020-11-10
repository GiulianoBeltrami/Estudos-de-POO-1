using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04__ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();
            gabriela.nome = "Gabriela";
            gabriela.cpf = "123.123.123-90";
            gabriela.profissao = "Pedreira";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriela;
            conta.agencia = 563;
            conta.numeroConta = 563863;
        }
    }
}
