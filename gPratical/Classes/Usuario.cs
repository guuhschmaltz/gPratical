using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gPratical.Classes
{
    public abstract class Usuario
    {
        public class Unit
        {
            [Required(ErrorMessage = "Nome do Cliente é obrigatório")]
            [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 100 caracteres")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "Data de nascimento é obrigatório")]
            public DateTime DataDeNascimento { get; private set; }

            [Required(ErrorMessage = "Telefone é obrigatório")]
            public string Telefone { get; private set; }

            [Required(ErrorMessage = "Cargo é obrigatório")]
            public string Cargo { get; private set; }

            [Required(ErrorMessage = "Setor é obrigatório")]
            public string Setor { get; private set; }

            [Required(ErrorMessage = "Endereco é obrigatório")]
            public string Endereco { get; private set; }

            [Required(ErrorMessage = "Estado é obrigatório")]
            public string Estado { get; private set; }

            [Required(ErrorMessage = "Cidade é obrigatório")]
            public string Cidade { get; private set; }

            [Required(ErrorMessage = "Bairro é obrigatório")]
            public string Bairro { get; private set; }

            [Required(ErrorMessage = "Genero é obrigatório")]
            public string Genero { get; private set; }

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
