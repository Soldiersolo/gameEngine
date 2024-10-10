using System;

class OpAritmeticos
{
    static void Main(string[] args) {
        int numero1 = 100;
        double numero2 = 50.9;
        //variavel declarada
        double soma;
        //alteração feita
        soma = numero1 + numero2;
        Console.WriteLine(soma);

        double subtração;
        subtração = numero1 - numero2;
        Console.WriteLine(subtração);

        double mustiplicação;
        mustiplicação = numero1 * numero2;
        Console.WriteLine(mustiplicação);

        double divisao;
        divisao = numero1 / numero2;
        Console.WriteLine(divisao);

        double resto;
        resto = numero1 % numero2;
        Console.WriteLine(divisao);

    }
}