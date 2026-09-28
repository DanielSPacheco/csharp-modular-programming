using System;


class ArrayAlunosAcimaDaMedia{
    public static void Main (string[] args)
{
    int n;
    double [] notas;
    string [] nomes;
    double media = 0;

    Console.WriteLine("Digite a quantidade de alunos: ");
    n = int.Parse(Console.ReadLine());
    notas = new double[n];
    nomes = new string[n];

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Digite o nome do aluno {0}: ", i + 1);
        nomes[i] = Console.ReadLine();
        Console.WriteLine("Digite a nota do aluno {0}: ", i + 1);
        notas[i] = double.Parse(Console.ReadLine());
        media += notas[i];
    }

    media /= n;

    Console.WriteLine("Média da turma: {0:F2}", media);

    Console.WriteLine("Alunos acima da média:");
    for (int i = 0; i < n; i++)
    {
        if (notas[i] > media)
        {
            Console.WriteLine("- {0}: {1:F2}", nomes[i], notas[i]);
        }
    }
}}