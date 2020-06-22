using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gPratical.Classes
{
    public class Setor
    {
        public string Nome { get; set; }

        public static List<Setor> GetSetores()
        {
            var setores = new List<Setor>();
            setores.Add(new Setor { Nome = "Compras" });
            setores.Add(new Setor { Nome = "Contabilidade" });
            setores.Add(new Setor { Nome = "Diretoria" });
            setores.Add(new Setor { Nome = "Engenharia" });
            setores.Add(new Setor { Nome = "Expedição" });
            setores.Add(new Setor { Nome = "Laboratório" });
            setores.Add(new Setor { Nome = "Logística" });
            setores.Add(new Setor { Nome = "Manutenção" });
            setores.Add(new Setor { Nome = "PPCP" });
            setores.Add(new Setor { Nome = "Produção" });
            setores.Add(new Setor { Nome = "Qualidade" });
            setores.Add(new Setor { Nome = "Recebimento" });
            setores.Add(new Setor { Nome = "RH" });
            setores.Add(new Setor { Nome = "Sesmt" });
            setores.Add(new Setor { Nome = "TI" });
            setores.Add(new Setor { Nome = "Vendas" });
            return setores;
        }
    }
}
