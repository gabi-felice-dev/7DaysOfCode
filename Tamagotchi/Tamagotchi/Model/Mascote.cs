using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Mascote
    {
        public List<Abilities> Habilidades { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public string Nome { get; set; }
        public int Alimentacao { get; set; }
        public int Humor { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
