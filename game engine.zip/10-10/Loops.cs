//Loops são 

using System;

class Loops{
//Tudo que eu quiser que apareça no terminal deve ser escrito aqui (dentro da main)
static void Main (string[] args) {

int voltas = 0;


while (voltas < 10)
{
Console.WriteLine($"Ja deu {voltas} voltas");
    voltas = voltas + 1;
    //voltas +=1 AQUI POSSO ADICIONAR QUALQUER VALOR
    //voltas ++
}
}
}