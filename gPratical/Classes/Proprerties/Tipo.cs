using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gPratical.Classes.Proprerties
{
    public class Tipo
    {
        public string Nome { get; set; }

        public static List<Tipo> GetTipos()
        {
            var tipos = new List<Tipo>();

            tipos.Add(new Tipo { Nome = "Balança" });
            tipos.Add(new Tipo { Nome = "Catraca" });
            tipos.Add(new Tipo { Nome = "Impressora Label" });
            tipos.Add(new Tipo { Nome = "Impressora Laser" });
            tipos.Add(new Tipo { Nome = "Leitor" });
            tipos.Add(new Tipo { Nome = "Monitor" });
            tipos.Add(new Tipo { Nome = "Nobreak" });
            tipos.Add(new Tipo { Nome = "Roteador" });
            tipos.Add(new Tipo { Nome = "Switch" });
            tipos.Add(new Tipo { Nome = "Transformador" });
            tipos.Add(new Tipo { Nome = "Outro" });

            return tipos;
        }
    }
}
