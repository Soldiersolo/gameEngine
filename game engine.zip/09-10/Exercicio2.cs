using System;

class Exercicio{
//Tudo que eu quiser que apareça no terminal deve ser escrito aqui (dentro da main)
static void Main (string[] args) {
//EXERCICIO 1
bool lampadaLigada = false;
if (lampadaLigada)
{
    Console.WriteLine("A lampada esta ligada");
} else
{
    Console.WriteLine("A lampada esta desligada");
}

//EXERCICIO 2

//EXERCICIO 3
string time = "inter";
switch (time)
{
    case "inter": 
    Console.WriteLine("o melhor");
    break;
    case "gremio":
    Console.WriteLine("lixo");
    break;
    case "vasco":
    Console.WriteLine("masoquista?");
    default: Console.WriteLine("sem graça");
}
}
}