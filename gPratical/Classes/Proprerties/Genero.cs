using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gPratical.Classes
{
    public class Genero
    {
        public string Nome { get; set; }

        public static List<Genero> GetGeneros()
        {
            var generos = new List<Genero>();
            generos.Add(new Genero { Nome = "Masculino" });
            generos.Add(new Genero { Nome = "Feminino" });
            generos.Add(new Genero { Nome = "Outro" });
            return generos;
        }
    }
}
