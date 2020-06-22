using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gPratical.Classes
{
        public class Estado
        {
            public string Nome { get; set; }

            public static List<Estado> GetEstados()
            {
                var estados = new List<Estado>();
                estados.Add(new Estado { Nome = "Acre" });
                estados.Add(new Estado { Nome = "Alagoas"});
                estados.Add(new Estado { Nome = "Amapá"});
                estados.Add(new Estado { Nome = "Amazonas "});
                estados.Add(new Estado { Nome = "Bahia"});
                estados.Add(new Estado { Nome = "Ceará"});
                estados.Add(new Estado { Nome = "Distrito Federal"});
                estados.Add(new Estado { Nome = "Espírito Santo "});
                estados.Add(new Estado { Nome = "Goiás"});
                estados.Add(new Estado { Nome = "Maranhão"});
                estados.Add(new Estado { Nome = "Mato Grosso "});
                estados.Add(new Estado { Nome = "Mato Grosso do Sul"});
                estados.Add(new Estado { Nome = "Minas Gerais"});
                estados.Add(new Estado { Nome = "Pará"});
                estados.Add(new Estado { Nome = "Paraíba"});
                estados.Add(new Estado { Nome = "Paraná"});
                estados.Add(new Estado { Nome = "Pernambuco"});
                estados.Add(new Estado { Nome = "Piauí"});
                estados.Add(new Estado { Nome = "Rio de Janeiro"});
                estados.Add(new Estado { Nome = "Rio Grande do Norte"});
                estados.Add(new Estado { Nome = "Rio Grande do Sul"});
                estados.Add(new Estado { Nome = "Rondônia"});
                estados.Add(new Estado { Nome = "Roraima"});
                estados.Add(new Estado { Nome = "Santa Catarina"});
                estados.Add(new Estado { Nome = "São Paulo"});
                estados.Add(new Estado { Nome = "Sergipe"});
                estados.Add(new Estado { Nome = "Tocantins"});

                return estados;
            }
        }
    }
