using System;

public class Ex2_a {
    static void Main() {
        
        string[] convidados = new string[10];

        Console.WriteLine("Digite o nome dos 10 convidados:");

        for (int i = 0; i < 10; i++) {

            Console.Write("Convidado {0}: ", i + 1);
            convidados[i] = Console.ReadLine();

        }

        Console.WriteLine("\nLista de convidados:");
        foreach (string convidado in convidados) {

            Console.WriteLine(convidado);
            
        }
    }
}