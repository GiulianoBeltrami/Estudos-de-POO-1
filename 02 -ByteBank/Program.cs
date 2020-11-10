using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02__ByteBank
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

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numeroConta = 863452;

            //como igualar as referências :
            contaDaGabriela = contaDaGabrielaCosta;
            //nesse caso , apontam para o mesmo local na memóriado computador

        }
    }
}
