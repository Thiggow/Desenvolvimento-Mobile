using System;
using System.Collections.Generic;

public class Ex3 {

    static void Main() {
        
        string entrada = "maca,banana,manga,limao";
        string[] frutas = entrada.Split(',');
        List<string> frutasL = new List<string>();

        foreach (string fruta in frutas) {

            string primeiraLetraMaiuscula = fruta.Substring(0, 1).ToUpper() + fruta.Substring(1).ToLower();
            frutasL.Add(primeiraLetraMaiuscula);

        }

        foreach (string frutaL in frutasL) {

            Console.WriteLine(frutaL);

        }

    }
}