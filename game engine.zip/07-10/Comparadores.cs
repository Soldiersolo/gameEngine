using System;

class Comparadores{
//Tudo que eu quiser que apareça no terminal deve ser escrito aqui (dentro da main)
static void Main (string[] args) {
Console.WriteLine("Hello World");

int numero1 = 10;
int numero2 = 3;

//verifica se são iguais 
Console.WriteLine(numero1 == numero2);//FALSE

//verifica se são diferentes
Console.WriteLine(numero1 != numero2);//TRUE

//verifica se é maior
Console.WriteLine(numero1 > numero2);//TRUE

//verifica se é maior ou igual
Console.WriteLine(numero1 >= numero2);

//verifica se é menor que o outro
Console.WriteLine(numero1 < numero2);

//verifica se é menor ou igual
Console.WriteLine(numero1 <= numero2);
}
}