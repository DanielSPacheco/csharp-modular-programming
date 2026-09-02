namespace FatoresQualidade.Manutenivel;

public static class CalculoPreco
{
    public static double CalcularSubtotal(double precoProduto, double frete)
    {
        return precoProduto + frete;
    }
    public static double AplicarDesconto(double subtotal, double desconto)
    {
        return subtotal - desconto;
    }
    public static double CalcularImpposto(double ValorComDesconto, double aliquotaImposto)
    {
        return ValorComDesconto * aliquotaImposto;
    }
}
    // Start to modularize the code by breaking down the calculations into smaller, reusable methods. This will make the code more maintainable and easier to understand. Each method will handle a specific part of the calculation process, allowing for better organization and potential reuse in other parts of the application.