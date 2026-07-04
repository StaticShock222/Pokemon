using System;
using System.Collections.Generic;
using System.Text;

namespace Personagem
{
    public class Oponente
    {
        public string Nome { get; set; } = "Pikachu";
        
        public int HP { get; set; } = 100;
        public Movimento Movimento { get; set; }
        public List<Movimento> Movimentos { get; set; } = new List<Movimento>
        {
            new Movimento
            {
                Nome = "Trovão",
                Tipo = "Eletrico",
                Precisao = 90,
                Forca = 22,
                PP = 15,
                MaxPP = 15
            },
            new Movimento
            {
                Nome = "Choque do Trovão",
                Tipo = "Elétrico",
                Precisao = 100,
                Forca = 16,
                PP = 30,
                MaxPP = 30
            },
            new Movimento
            {
                Nome = "Investida de Fio",
                Tipo = "Elétrico",
                Precisao = 100,
                Forca = 10,
                PP = 35,
                MaxPP = 35
            },
            new Movimento
            {
                Nome = "Agilidade",
                Tipo = "Elétrico",
                Precisao = 100,
                Forca = 8,
                PP = 30,
                MaxPP = 30
            }
        };
    }
}
