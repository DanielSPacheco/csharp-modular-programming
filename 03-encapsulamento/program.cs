class Program
{
    static void Main()
    {
        ContaBancaria conta1 = new ContaBancaria(2000.0);

        conta1.Depositar(500.0);

        conta1.Sacar(300.0);

        bool saqueRealizado = conta1.Sacar(3000.0);

        Console.WriteLine(saqueRealizado);
        
        Console.WriteLine(conta1.ConsultarSaldo()); 
    }
}