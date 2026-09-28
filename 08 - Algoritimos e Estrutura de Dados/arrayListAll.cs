using System;
using System.Collections.Generic;

class ArrayAllTimes {

    public static void Show(ArrayList al) { // Create ArrayList al = new ArrayList();
        Console.WriteLine("Show ArrayList: ");; // Show the content of the ArrayList
        foreach (object o in al) {
            Console.WriteLine(o + " ");
        }
        Console.WriteLine();
    }

    public static void Show(Object[] vetor) {
        Console.WriteLine("Show Object[]: ");
        foreach (object o in vetor) {
            Console.WriteLine(o + " ");
        }
        Console.WriteLine();
    }
}

public static void Main (string[] args) {
    ArrayList al = new ArrayList();

    Console.WriteLine("======================== INSERÇÃO");
    al.Add(15);
    al.Add(3.13159);
    al.Add("AEDs");
    al.Insert(2, 125);// isert 125 at index 2, shifting the rest of the elements to the right
    al.Add(1);
    al.Add(2);
    al.Add(3);
    al.Add(4);
    ArrayAllTimes.Show(al);

    Console.WriteLine("======================== MOSTRAR ELEMENTOS");
    Console.WriteLine("ArrayList[0] = " + al[0]);
    Console.WriteLine("ArrayList[1] = " + al[1]);
    Console.WriteLine("ArrayList[2] = " + al[2]);
    Console.WriteLine("ArrayList[3] = " + al[3]);

    Console.WriteLine("======================== REMOÇÃO");
    al.Remove(3.13159); // Dont happend exception if not found
    al.RemoveAt(1); // here occurs exception if not found
    al.RemoveRange(0, 2); // Remove 2 elements starting from index 0

    Show(al);

    Console.WriteLine("======================== CLEAR");
    al.Clear();
    Console.WriteLine("Capacity{0} / Count{1}", al.Capacity, al.Count);

    Console.WriteLine("======================== COINTAINS");
    for (int i = 0; i < 20; i++) {
        al.Add(i*2);
    }
    if (al.Contains(2) == true) {
        Console.WriteLine("Element 2 not found");
    } else {
        Console.WriteLine("Element 2 not found");
    }
    if (al.Contains(9) == true)
    Console.WriteLine("Element 9 found");
    else
        Console.WriteLine("Element 9 not found");

    Console.WriteLine("======================== INDEXOF");
    al.Add(2);
    Console.WriteLine("IndexOf(2): " + al.IndexOf(2));
    Console.WriteLine("LastIndexOf(2): " + al.LastIndexOf(2));

    Console.WriteLine("======================== REVERSER");
    Show(al);
    al.Reverse();// Reverse the order of the elements in the ArrayList
    Show(al);
    al.Reverse(3, 5); // Reverse the order of the elements in the ArrayList from index 3 to index 5
    Show(al);

    Console.WriteLine("======================== SORT");
    al.Sort(); // Sort the elements in the ArrayList
    Show(al);

    Console.WriteLine("======================== TOARRAY");
    Object[] vetor = al.ToArray(); // Convert the ArrayList to an array of objects
    Show(vetor);

    Console.WriteLine("======================== TRIMTOFIT");
    Console.WriteLine("Capacity{0} / Count{1}", al.Capacity, al.Capacity,al.Count);
    al.TrimToSize(); // Set the capacity to the actual number of elements in the ArrayList
    Console.WriteLine("Capacity{0} / Count{1}", al.Capacity,al.Count);

    Console.WriteLine('======================== BINARYSEARCH');
    int posicao = al.BinarySearch(2);
    ConsoleWriteLine("Posicao do [2]: " + posicao);
    posicao = al.BinarySearch(9);
    ConsoleWriteLine("Posicao do [9]: " + posicao);
}
