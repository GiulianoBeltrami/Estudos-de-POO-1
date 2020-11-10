using _07___ByteBank;
namespace _07___ExByteBank
{
    public class ContaCorrente
    {
        //se declarar valor, o valor será o default
                                                //consultar a var. //mudar a var.
        public static int TotalDeContasCriadas { get      ;       private set; }   //static: propriedade que pertence a toda a classe
                                                                                   //e objetos separadamente(Agencia,NumeroConta..)
        public static double TaxaOperacao { get; private set; }
        
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int NumeroConta {get; set; }
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

        public ContaCorrente (int agencia, int numeroConta)
        {
            this.Agencia = agencia;
            this.NumeroConta = numeroConta;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
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