namespace _05__ByteBank 
{
    public class ContaCorrente
    {
        //se declarar valor, o valor será o default
        public Cliente titular { get; set; }
        public int agencia { get; set; }
        public int numeroConta{get;set;}

        private double _saldo;

        public double Saldo 
        {
            get 
            {
                return _saldo;
            }
            set 
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }
        //funcao
        public bool Sacar(double valor)
        {
            if (valor > this._saldo)
            {
                //não pode sacar pois não tem saldo
                return false;
            }

            //pode sacar pois tem saldo
            this._saldo -= valor;
            return true;

        }

        //void quer dizer que não possui retorno
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor > this._saldo)
            {
                //não pode transferir pois não tem saldo
                return false;
            }
            //não precisa de else pois caso o if seja positivo já sairá da função
            //pode transferir pois tem saldo
            this._saldo -= valor; // diminui o valor transferido do saldo da conta
            contaDestino.Depositar(valor); // deposita o valor transferido em outra conta
            return true;

        }

    }
}

//classe é a planta de uma casa
//objeto é a casa, algo físico