namespace Personagem
{
    public class Player
    {
        public enum TipoElemento
        {
            Fogo,
            Agua,
            Planta,
            Eletrico
        }
        public string Nome { get; set; }
        public TipoElemento Tipo { get; set; }
        public int HP { get; set; }
        public int Ataque { get; set; }

    }
}
