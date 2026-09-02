namespace FatoresQualidade.Manutenivel;

public static class CalculoManutenivel
{
    public static void Executar()
    {
        double precoProduto = 100;
        double frete = 100;
        double desconto = 50;
        double aliquotaImposto = 0.12;

        double subtotal = CalculoPreco.CalcularSubtotal(precoProduto, frete);

        double ValorComDesconto = CalculoPreco.AplicarDesconto(subtotal, desconto);

        double valorImposto = CalculoPreco.CalcularImpposto(ValorComDesconto, aliquotaImposto);

        Console.WriteLine("Valor final do Imposto: " + valorImposto);
    }
}

// Now we have a modular and maintainable code structure. The calculations are broken down into smaller, reusable components, and the variable names are descriptive, making it easier to understand and maintain the code.

