namespace Personagem
{
    public class Player
    {
        public Movimento movimento1;
        public Movimento movimento2;
        public Movimento movimento3;
        public Movimento movimento4;

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
