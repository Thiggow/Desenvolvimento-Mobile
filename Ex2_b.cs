using System;
using System.Collections.Generic;

public class Ex2_b {
    static void Main() {
        
        List<string> convidados = new List<string>();
        
        for (int i = 0; i < 10; i ++) {

            Console.WriteLine("Digite o {0}º convidado: ", i + 1);
            convidados.Add(Console.ReadLine());

        }

        Console.WriteLine("\n\nLista de convidados:");
        foreach (string convidado in convidados) {

            Console.WriteLine(convidado);

        }
    }
}