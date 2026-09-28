class ReferenceExample{
    public static void Main(string[] args){
        Aluno a1 = null, a2 = null;
        a1 = new Aluno("aa", 1, "a@a.com"); a2 = a1; // Object a2 is a reference to the same object as a1
        a2.matricula = 3; // don't change the reference, but change the object that both a1 and a2 point to
        a1.Mostrar();
        a2.Mostrar();
    }
}