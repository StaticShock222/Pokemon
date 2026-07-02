using Personagem;
using System;
public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número relativo ao pokemon que deseja escolher:");

        Player player1 = new Player
        {
            Nome = "Charmander",
            Tipo = Player.TipoElemento.Fogo,
            HP = 100
        };


        Player player2 = new Player
        {
            Nome = "Bulbasaur",
            Tipo = Player.TipoElemento.Planta,
            HP = 100
        };

        Player player3 = new Player
        {
            Nome = "Squirtle",
            Tipo = Player.TipoElemento.Agua,
            HP = 100
        };

        Console.WriteLine($"Pokemon 1: {player1.Nome}, Tipo: {player1.Tipo}, HP: {player1.HP}");
        Console.WriteLine($"Pokemon 2: {player2.Nome}, Tipo: {player2.Tipo}, HP: {player2.HP}");
        Console.WriteLine($"Pokemon 3: {player3.Nome}, Tipo: {player3.Tipo}, HP: {player3.HP}");

        int escolha = int.Parse(Console.ReadLine());
        while (escolha < 1 || escolha > 3)
        {
            Console.WriteLine("Escolha inválida. Digite um número entre 1 e 3.");
            escolha = int.Parse(Console.ReadLine());
        }
        while (escolha == 1)
        {
            Oponente oponente = new Oponente();

        }
    }
}