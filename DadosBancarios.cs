using System.Globalization;

namespace Banco
{
    class DadosBancarios
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        
        public DadosBancarios(int numeroconta, string nometitular)
        {
            NumeroConta = numeroconta;
            Nome = nometitular;
            Saldo = 0.00;
        }

        public DadosBancarios(int numeroconta, string nometitular, double saldo) : this(numeroconta, nometitular)
        {
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Saque(double valor)
        {
            Saldo = (Saldo - valor) - 5;
        }

        public override string ToString()
        {
            return $"Conta: {NumeroConta}, Titular: {Nome}, Saldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}