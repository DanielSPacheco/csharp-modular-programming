class ContaBancaria
{
    public string Titular;
    public double Saldo;
    
    public ContaBancaria(string titular, double saldo)
    {
        Titular = titular;
        Saldo = saldo;
    }
    public void Sacar(double valor)
    {
    Saldo -= valor;
    }
    public void Depositar(double valor)
    {
        Saldo += valor;
    }
    public double ConsultarSaldo()
    {
        return Saldo;
    }
}   
class Program
{
    static void Main()
    {
        ContaBancaria conta1 = new ContaBancaria("Daniel", 2000);
        conta1.Sacar(500);
        conta1.Depositar(1000);
        ContaBancaria conta2 = new ContaBancaria("Maria", 500);
        ContaBancaria conta3 = new ContaBancaria("João", 3000);

        Console.WriteLine("Conta 1:");
        Console.WriteLine("Titular: " + conta1.Titular);
        Console.WriteLine("Saldo: " + conta1.ConsultarSaldo());

        Console.WriteLine();

        Console.WriteLine("Conta 2:");
        Console.WriteLine("Titular: " + conta2.Titular);
        Console.WriteLine("Saldo: " + conta2.Saldo);

        Console.WriteLine();

        Console.WriteLine("Conta 3:");
        Console.WriteLine("Titular: " + conta3.Titular);
        Console.WriteLine("Saldo: " + conta3.Saldo);
    }
}