using System;

class Variaveis{
//Tudo que eu quiser que apareça no terminal deve ser escrito aqui (dentro da main)
static void Main (string[] args) {
Console.WriteLine("Hello World");

//aq vou criar uma variavel de número inteiro
/*int numero = 15
Console.WriteLine(numero);
Console.WriteLine(numero + 30);
Console.WriteLine(numero + 10);
Console.WriteLine(numero + 90);
*/
int idade = 16;//numeros inteiros
double altura = 1.73; //numeros decimais (com) ponto
string nome = "Brayan Gabriel Bitencourt de Oliveira";  //texto
char inicial = 'B';  //um unico caractere
bool aprovado = true; //um caractere booleano que só tem 2 valores

Console.WriteLine($"Olá, meu nome é {nome}, tenho {altura} de altura, tenho {idade} anos de idade. Estou aprovado na escola? {aprovado}");

}
}
