using System;

public class Exercicio1
{

 public static void Main()
 {
    int convidadosNoivo = 300;
    int convidadosNoiva = 600;
    int convidadosPresentesNoivo = 400;
    int convidadosPresentesNoiva = 400;
    bool x = true;

    if (convidadosNoivo < convidadosNoiva) {

        Console.WriteLine("O noivo convidou menos pessoas que a noiva.");

    } if (convidadosNoivo > convidadosNoiva) {

        Console.WriteLine("O noivo convidou mais pessoas que a noiva.");

    } if (convidadosNoiva == convidadosNoivo) {

        Console.WriteLine("O número de convidados da noiva e do noivo são iguais");

    } if (convidadosPresentesNoivo <= convidadosNoivo || convidadosPresentesNoiva >= convidadosNoiva) {

        Console.WriteLine("Há penetras na festa");

    }  if (convidadosNoivo != convidadosPresentesNoivo && !x == false) {

        Console.WriteLine("O número de convidados e convidados presentes do noivo são diferentes");

    }

 }
};