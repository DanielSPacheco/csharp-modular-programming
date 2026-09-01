namespace FatoresQualidade.Simples;

public static class calaculoSimples
{
    public static void Executar()
    {
        double a = 100;
        double b = 50;
        double c = 10;

        double x = a + b;
        double y = x - c;
        double z = y * 0.1;

        Console.WriteLine("Valor: " + z); // Output: Valor: 14
    }
}

// Model using simple variable names and direct calculations - shows the in a programing context can be dificult to understand the purpose of the calculations without proper naming conventions and comments.