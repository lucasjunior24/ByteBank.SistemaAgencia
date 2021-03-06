using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class ContaCorrente : IComparable
    {
        public static int TaxaOperacao;  
        public static int TotalDeContasCriadas { get; private set; }
        public static int ContadorTransferenciasNaoPermitidas { get; private set; }
        public Cliente Titular { get; set; }
        public int Numero { get; }
        public int Agencia { get; }
        private double _saldo = 100;
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

        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0)
            {
                throw new ArgumentException("O argumento agência deve ser maior que 0.", nameof(agencia));
            }
            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }    

        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", valor.ToString());
            }
            if(_saldo < valor)
            {
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a trasferência.", nameof(valor));
            }
            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não reaizada", ex);
            }
            contaDestino.Depositar(valor);
        }

        public override bool Equals(object obj)
        {
            ContaCorrente outraConta = obj as ContaCorrente;

            if(outraConta == null)
            {
                return false;
            }

            return Numero == outraConta.Numero && Agencia == outraConta.Agencia;
        }

        public int CompareTo(object obj)
        {
            var outraConta = obj as ContaCorrente;
            if (outraConta == null) return -1;

            if (Numero < outraConta.Numero) return -1;
            if (Numero == outraConta.Numero) return 0;
            return 1;
        }
    }
}
