namespace Ex_ContaBancaria
{
    class ContaBancaria
        //teste
    {
        public string Numero { get; private set; }
        public double Saldo { get; private set; }
        public string Titular { get; set; }

        public ContaBancaria(string numero, double saldo, string titular)
        {
            Numero = numero;
            Saldo = saldo;
            Titular = titular;
        }

        public void Depositar(string numero, double saldo, double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void Sacar(string numero, double saldo, double valorSaque)
        {
            Saldo -= valorSaque + 5;
        }

        public override string ToString()
        {
            return "Conta: " + Numero +
                   ", Titular: " + Titular +
                   ", Saldo: $ " + Saldo.ToString("F2");
        }
    }
}
