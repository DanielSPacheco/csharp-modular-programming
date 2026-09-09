class ContaBancaria
{
    private double saldo; // The balance is private to prevent direct access from outside the class, ensuring encapsulation.

    public ContaBancaria(double saldoInicial)
    {
        saldo = saldoInicial;
    }
    public double ConsultarSaldo()
    {
        return saldo;
    }
       public void Depositar(double valor) // Prevents invalid deposits by checking if the value is greater than zero
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }
    public bool Sacar(double valor) // Allows withdrawal only when the requested amount is available.
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            return true;
            
        }
        return false;
    }
}

