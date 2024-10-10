using System;

class Exercicio{
//Tudo que eu quiser que apareça no terminal deve ser escrito aqui (dentro da main)
static void Main (string[] args) {
int contagem = 10;

while (contagem >= 0)
{
    
if (contagem == 0)
{
    Console.WriteLine("BOOM");

} else if (contagem % 2 == 0)
{
    Console.WriteLine("TIC");
} else
{
    Console.WriteLine("TAC");
}
 contagem = contagem - 1;
}
}
}