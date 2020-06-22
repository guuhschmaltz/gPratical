using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gPratical.Classes.Proprerties
{
    public class Voltagem
    {
        public string Nome { get; set; }

        public static List<Voltagem> GetVoltagensEntrada()
        {
            var voltagem = new List<Voltagem>();

            voltagem.Add(new Voltagem { Nome = "110" });
            voltagem.Add(new Voltagem { Nome = "220" });
            voltagem.Add(new Voltagem { Nome = "BiVolt" });
            voltagem.Add(new Voltagem { Nome = "Selecionavel" });

            return voltagem;
        }
        public static List<Voltagem> GetVoltagensSaida()
        {
            var voltagem = new List<Voltagem>();

            voltagem.Add(new Voltagem { Nome = "110" });
            voltagem.Add(new Voltagem { Nome = "220" });
            voltagem.Add(new Voltagem { Nome = "Selecionavel" });

            return voltagem;
        }
    }
}
