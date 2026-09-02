class Program
{
    static void Main(string[] args)
    {
       string opcao = args.Length > 0 
       ? args[0].ToLower()
       : "legivel"; 

        if (opcao == "simples")
        {
            FatoresQualidade.Simples.calaculoSimples.Executar();
        }
        else if (opcao == "legivel")
        {
            FatoresQualidade.Legivel.CalculoLegivel.Executar();
        }
        else if (opcao == "nao-modular")
        {
            FatoresQualidade.NaoModular.CalculoNaoModular.Executar();
        }
        else if (opcao == "manutenivel")
        {
            FatoresQualidade.Manutenivel.CalculoManutenivel.Executar();
        }
        else
        {
            Console.WriteLine("Opção inválida. Use 'legivel' ou 'simples'.");
        }
    }
}