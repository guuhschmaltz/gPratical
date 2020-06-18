using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gPratical.Classes
{
    public abstract class Equipamentos
    {
        public class Unit
        {
            [Required(ErrorMessage = "Tipo do equipamento é obrigatório")]
            public string Tipo { get; set; }

            [Required(ErrorMessage = "Marca do equipamento é obrigatório")]
            public string Marca { get; private set; }

            [Required(ErrorMessage = "Modelo do equipamento é obrigatório")]
            public string Modelo { get; private set; }

            [Required(ErrorMessage = "Local é obrigatório")]
            public string Local { get; private set; }

            [Required(ErrorMessage = "Voltagem de entrada é obrigatório")]
            public string VoltagemEntrada { get; private set; }

            [Required(ErrorMessage = "Voltagem de saida é obrigatório")]
            public string VoltagemSaida { get; private set; }

            public string SerialNumber { get; private set; }

            public string Potencia { get; private set; }

            public string Validade{ get; private set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }
        }
        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }
    }
}
