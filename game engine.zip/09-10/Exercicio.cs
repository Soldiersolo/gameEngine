using System;

class Exercicio{
//Tudo que eu quiser que apareça no terminal deve ser escrito aqui (dentro da main)
static void Main (string[] args) {
bool maiorIdade = 16 >= 18;
bool ensinoMedioCompleto = false;
bool naoEstarEmOutraFaculdade = true;
Console.WriteLine($"Você esta apto para fazer faculdade:{maiorIdade && ensinoMedioCompleto && naoEstarEmOutraFaculdade}");
}
}