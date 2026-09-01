namespace FatoresQualidade.Legivel;

public static class CalculoLegivel
{
    public static void Executar()
    {
        double precoProduto = 100;
        double frete = 50;
        double desconto = 10;
        double aliquotaImposto = 0.1;

        double subtotal = precoProduto + frete;
        double totalComDesconto = subtotal - desconto;
        double valorImposto = totalComDesconto * aliquotaImposto;

        Console.WriteLine("Valor final do Imposto: " + valorImposto); // Output: Resultado final: 14
    }
}

// Model using descriptive variable names and clear output message - demonstrates how proper naming conventions and comments can enhance code readability and understanding of the calculations being performed.