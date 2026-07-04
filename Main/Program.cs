using Personagem;
using System;
public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número relativo ao pokemon que deseja escolher:");
        Player player1 = new Player
        {
            Nome = "Charizard",
            Tipo = Player.TipoElemento.Fogo,
            HP = 100,
            Movimentos = ListaMovimentos.MovimentosCharizard.ToList()
        };

        Player player2 = new Player
        {
            Nome = "Venusaur",
            Tipo = Player.TipoElemento.Planta,
            HP = 100
        };

        Player player3 = new Player
        {
            Nome = "Blastoise",
            Tipo = Player.TipoElemento.Agua,
            HP = 100,

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
        Player escolhido;
        switch (escolha)
        {
            case 1:
                escolhido = player1;
                break;
            case 2:
                escolhido = player2;
                break;
            default:
                escolhido = player3;
                break;
        }

        Oponente oponente = new Oponente();

        Console.WriteLine($"Você escolheu o {escolhido.Nome}. Seu oponente é: {oponente.Nome}");
        Console.WriteLine($"Seu HP: {escolhido.HP}. Agora, escolha seu ataque de 1 a 4 no menu:");
        while (escolhido.HP > 0 && oponente.HP > 0)
        {
            Console.WriteLine($"Escolha seu ataque: 1 - {escolhido.movimento1.Nome}, 2 - {escolhido.movimento2.Nome}, 3 - {escolhido.movimento3.Nome}, 4 - {escolhido.movimento4.Nome}");
            escolha = int.Parse(Console.ReadLine());
            while (escolha < 1 || escolha > 4)
            {
                Console.WriteLine("Escolha inválida. Digite um número entre 1 e 4.");
                escolha = int.Parse(Console.ReadLine());
            }
            Movimento ataqueEscolhido;
            switch (escolha)
            {
                case 1:
                    ataqueEscolhido = escolhido.movimento1;
                    break;
                case 2:
                    ataqueEscolhido = escolhido.movimento2;
                    break;
                case 3:
                    ataqueEscolhido = escolhido.movimento3;
                    break;
                default:
                    ataqueEscolhido = escolhido.movimento4;
                    break;
            }
            int chanceAcerto = Random.Shared.Next(1, 101);
            if (chanceAcerto <= ataqueEscolhido.Precisao)
            {
                oponente.HP -= ataqueEscolhido.Forca;
                Console.WriteLine($"Você usou {ataqueEscolhido.Nome}! O oponente perdeu {ataqueEscolhido.Forca} de HP. HP do oponente: {oponente.HP}");
            }
            else
            {
                Console.WriteLine($"Você usou {ataqueEscolhido.Nome}, mas errou!");
            }
            if (oponente.HP <= 0)
            {
                Console.WriteLine("Parabéns! Você derrotou o oponente!");
                break;
            }
            int danoOponente = oponente.Movimento?.Forca ?? 0;
            escolhido.HP -= danoOponente;
            Console.WriteLine($"O oponente atacou usando {oponente.Movimentos[1].Nome}! Você perdeu {danoOponente} de HP. Seu HP: {escolhido.HP}");
            if (escolhido.HP <= 0)
            {
                Console.WriteLine("Você foi derrotado pelo oponente!");
                break;
            }
        }
        Console.ReadLine();
    }
}
