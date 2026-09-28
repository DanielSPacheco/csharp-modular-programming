using System;
using System.Collections;

class MainClass {
    public static void Main (string[] args) {
        ArrayList al = new ArrayList();
        Console.WriteLine("AL.Capacity({0})/AL.Count({1})\n", al.Capacity, al.Count);
        al.Add(1);
        Console.WriteLine("AL.Capacity({0})/AL.Count({1})\n", al.Capacity, al.Count);
    }
}

ArrayList al = new ArrayList();
double media = 0;
for (int i = 0. i < 5; i++){
    int valor = int.Parse(Console.ReadLine());
    al.Add(valor);
    media += valor;
}
media /= 5;
foreach (object o in al){
    if ((int)o > media){
        Console.WriteLine(o);
    }
}