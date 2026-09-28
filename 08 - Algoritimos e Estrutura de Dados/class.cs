using System;
using System.Collections;

class Aluno {
    public int matricula;
    public string nome;
    public string email;

    public Aluno(){
        this.nome = "";
        this.email = "";
        this.matricula = 0;
    }
    public Aluno(string nome, int matricula, string email){
        this.nome = nome;
        this.matricula = matricula;
        this.email = email;
    }
    public void Mostrar(){
        Console.WriteLine(nome + " (mat " + matricula + ") -- " + email);
    }
}
