namespace _04__ByteBank 
{
    public class ContaCorrente
    {
        //se declarar valor, o valor será o default
        public Cliente titular;
        public int agencia, numeroConta;
        public double saldo;

        //funcao
        public bool Sacar(double valor)
        {
            if (valor > this.saldo)
            {
                //não pode sacar pois não tem saldo
                return false;
            }

            //pode sacar pois tem saldo
            this.saldo -= valor;
            return true;

        }

        //void quer dizer que não possui retorno
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor > this.saldo)
            {
                //não pode transferir pois não tem saldo
                return false;
            }
            //não precisa de else pois caso o if seja positivo já sairá da função
            //pode transferir pois tem saldo
            this.saldo -= valor; // diminui o valor transferido do saldo da conta
            contaDestino.Depositar(valor); // deposita o valor transferido em outra conta
            return true;

        }

    }
}

//classe é a planta de uma casa
//objeto é a casa, algo físico