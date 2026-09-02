namespace FatoresQualidade.NaoModular;

public static class CalculoNaoModular
{
    public static void Executar()
    {
        double precoProduto = 100;
        double frete = 50;
        double desconto = 10;

        double subtotal = precoProduto + frete;
        double totalComDesconto = subtotal - desconto;
        double valorImposto = totalComDesconto * 0.1;

        Console.WriteLine("Resultado final: " + valorImposto);
    }
}

// Here we change the value of the variables, but only one execution for all the logic and now the code is smaller and more readable, but still not modular. The calculations are still performed in a single method, making it harder to maintain and test individual components.