using System;

class Exercicio2{
//Tudo que eu quiser que apareça no terminal deve ser escrito aqui (dentro da main)
static void Main (string[] args) {
int bio = 0;
int bio2 = 4;
int bio3 = 0;

int soma = bio + bio2 + bio3;
Console.WriteLine(soma);

int divisao = soma / 3;
Console.WriteLine(divisao);

//parte2

int par1 = 4;
int par2 = 6;
int par3 = 8;
int par4 = 10;
int par5 = 12;
int impar1 = 3;
int impar2 = 7;
int impar3 = 11;
int impar4 = 13;
int impar5 = 17;

int restoPar1 = par1 % 2;
int restoPar2 =  par2 % 2;
int restoPar3 =  par3 % 2;
int restoPar4 =  par4 % 2;
int restoPar5 =  par5 % 2;
int restoImpar1 = impar1 % 2;
int restoImpar2 = impar2 % 2;
int restoImpar3 = impar3 % 2;
int restoImpar4 = impar4 % 2;
int restoImpar5 = impar5 % 2;

Console.WriteLine(restoImpar1);
Console.WriteLine(restoImpar2);
Console.WriteLine(restoImpar3);
Console.WriteLine(restoImpar4);
Console.WriteLine(restoImpar5);
Console.WriteLine(restoPar1);
Console.WriteLine(restoPar2);
Console.WriteLine(restoPar3);
Console.WriteLine(restoPar4);
Console.WriteLine(restoPar5);
//Console.WriteLine();
//Console.WriteLine();
}
}