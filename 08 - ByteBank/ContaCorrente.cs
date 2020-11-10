using System;
using _08___ByteBank;
using _08___ByteBank.Exception;


namespace _08___ByteBank
{
    public class ContaCorrente
    {
        //se declarar valor, o valor será o default
                                                //consultar a var. //mudar a var.
        public static int TotalDeContasCriadas { get      ;       private set; } //static: propriedade que pertence a toda a classe
                                                                                 //e objetos separadamente(Agencia,NumeroConta..)
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }
        public int NumeroConta { get; } //o set se torna somente leitura e só pode ser alterado no construtor
        public int NumeroAgencia { get; }     
        public int ContadorDeSaquesNaoPermitidos { get; private set; }
        public int ContadorDeTrasnferenciasNaoPermitidas { get; private set; }
        public ContaCorrente(int agencia, int numeroConta)
        {
            if (agencia <= 0 || numeroConta <= 0)
            {
                if (agencia <=0)
                    throw new ArgumentException("A Agencia da conta deve ser maior que zero.",nameof(agencia));
                if (numeroConta <= 0)
                    throw new ArgumentException("O número da conta deve ser maior que zero.", nameof(numeroConta));
            }
            else
            {
                this.NumeroAgencia = agencia;
                this.NumeroConta = numeroConta;
                TotalDeContasCriadas++;
                TaxaOperacao = 30 / TotalDeContasCriadas;
            }
        }
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
        public void Sacar(double valor)
        {
            if (valor > this._saldo)
            {    //não pode sacar pois não tem saldo
                ContadorDeSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException("Valor maior que o saldo no banco.");
            }
            if (valor < 0)
                throw new ArgumentException("Valor menor que zero.",nameof(valor));
                //pode sacar pois tem saldo
                this._saldo -= valor;
               
        }
        //void quer dizer que não possui retorno
        public void Depositar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor de deposito menor que zero.", nameof(valor));
            this._saldo += valor;
        }
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException) 
            {
                ContadorDeTrasnferenciasNaoPermitidas++;
                throw;
            }
            //não precisa de else pois caso o if seja positivo já sairá da função
            //pode transferir pois tem saldo
            contaDestino.Depositar(valor); // deposita o valor transferido em outra conta
        }
    }
}

//classe é a planta de uma casa
//objeto é a casa, algo físico