using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOKEDEX
{
    public class Pokemon
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int NumeroPokedex { get; set; }
        public int Geracao { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }

        public List<Pokemon> Evolucoes { get; set; }
    }
}
