using System;

class Condicionais{
//Tudo que eu quiser que apareça no terminal deve ser escrito aqui (dentro da main)
static void Main (string[] args) {
      bool temCarteira = true;
      int idade = 19;
      bool maiorIdade = idade >= 18;

//SE eu tenho carteira
if (temCarteira && maiorIdade)
{
 Console.WriteLine("Voce esta apto para dirigir") ;  
} else if (!temCarteira && maiorIdade)
{
    Console.WriteLine("voce e maior de idade, mas nao pode dirigir ");
} else {
    Console.WriteLine("Voce nao pode dirigir");
}
}
}

