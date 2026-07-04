using System;
using System.Collections.Generic;
using System.Text;

namespace Personagem
{
    public static class ListaMovimentos
    {
        public static List<Movimento> MovimentosCharizard { get; set; } = new List<Movimento>
        {
            new Movimento{Nome = "Lança Chamas", Tipo = "Fogo", Precisao = 80, Forca = 20, PP = 15, MaxPP = 15},
            new Movimento{Nome = "Fúria do Dragão", Tipo = "Fogo", Precisao = 70, Forca = 100, PP = 10, MaxPP = 10},
            new Movimento{Nome = "Voar", Tipo = "Normal", Precisao = 100, Forca = 80, PP = 15, MaxPP = 15},
            new Movimento{Nome = "Investida", Tipo = "Normal", Precisao = 100, Forca = 50, PP = 20, MaxPP = 20},
        };
        public static List<Movimento> MovimentosBlatoise{ get; set; } = new List<Movimento>
        {
            new Movimento{Nome = "Lança Chamas", Tipo = "Fogo", Precisao = 80, Forca = 20, PP = 15, MaxPP = 15},
            new Movimento{Nome = "Fúria do Dragão", Tipo = "Fogo", Precisao = 70, Forca = 100, PP = 10, MaxPP = 10},
            new Movimento{Nome = "Voar", Tipo = "Normal", Precisao = 100, Forca = 80, PP = 15, MaxPP = 15},
            new Movimento{Nome = "Investida", Tipo = "Normal", Precisao = 100, Forca = 50, PP = 20, MaxPP = 20},
        };
    }
}
